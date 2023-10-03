// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections;
using System.Reflection;
using Serilog;
using WrathForged.Common.Networking;
using WrathForged.Common.Scripting;
using WrathForged.Common.Serialization.Serializers;
using WrathForged.Models;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization;

public class ForgedModelSerializer
{
    private readonly ILogger _logger;

    /// <summary>
    ///     A cache of all the deserialization definitions for each object and their properties
    /// </summary>
    // Scope OpCode ObjType PropertyName, SerializationMetadata
    private readonly Dictionary<PacketScope, Dictionary<uint, (Type, List<PropertyMeta>)>> _deserializationMethodsCache = new();
    private readonly Dictionary<Type, List<PropertyMeta>> _deserializationMethodsCacheByType = new();
    private readonly Dictionary<Type, List<PropertyMeta>> _systemScope = new();
    private readonly Dictionary<Type, IForgedTypeSerialization> _serializers = new();
    private readonly Dictionary<ForgedTypeCode, IForgedTypeSerialization> _forgedTypeCodeSerializers = new();

    public ForgedModelSerializer(ILogger logger, ScriptLoader assemblyLoader, ClassFactory classFactory)
    {
        var classesWithAttribute = assemblyLoader.GetAllTypesWithClassAttribute<ForgedSerializableAttribute>();

        // Build the deserialization cache
        foreach (var cls in classesWithAttribute)
        {
            var attribute = (ForgedSerializableAttribute)cls.GetCustomAttributes(typeof(ForgedSerializableAttribute), false).First();
            Queue<PacketScope> scopes = new();
            scopes.Enqueue(attribute.Scope);

            while (scopes.TryDequeue(out var scope))
            {
                if (scope == PacketScope.All)
                {
                    foreach (var s in (PacketScope[])Enum.GetValues(typeof(PacketScope)))
                    {
                        if (s == PacketScope.All)
                            continue;

                        scopes.Enqueue(s);
                    }
                }

                if (!_systemScope.TryGetValue(cls, out var propertyAttr))
                {
                    propertyAttr = [];

                    foreach (var prop in cls.GetProperties())
                    {
                        var propAtt = prop.GetCustomAttribute<SerializablePropertyAttribute>();
                        IConditionalSerialization? conditionalAtt = null;

                        foreach (var att in prop.GetCustomAttributes())
                            if (att is IConditionalSerialization conditionalSerialization)
                            {
                                conditionalAtt = conditionalSerialization;
                                break;
                            }

                        if (propAtt != null)
                            propertyAttr.Add(new PropertyMeta(propAtt, prop, conditionalAtt));
                    }

                    propertyAttr.Sort();
                    _systemScope[cls] = propertyAttr;
                }

                if (!_deserializationMethodsCache.TryGetValue(attribute.Scope, out var scopeDictionary))
                {
                    scopeDictionary = [];
                    _deserializationMethodsCache[attribute.Scope] = scopeDictionary;
                }

                foreach (var packetId in attribute.PacketIDs)
                {
                    var propertyAttributes = new List<PropertyMeta>();

                    foreach (var prop in cls.GetProperties())
                    {
                        var propAtt = prop.GetCustomAttribute<SerializablePropertyAttribute>();
                        IConditionalSerialization? conditionalAtt = null;

                        foreach (var att in prop.GetCustomAttributes())
                            if (att is IConditionalSerialization conditionalSerialization)
                            {
                                conditionalAtt = conditionalSerialization;
                                break;
                            }

                        if (propAtt != null)
                            propertyAttributes.Add(new PropertyMeta(propAtt, prop, conditionalAtt));
                    }

                    propertyAttributes.Sort();
                    scopeDictionary[packetId] = (cls, propertyAttributes);
                    _deserializationMethodsCacheByType[cls] = propertyAttributes;
                }
            }
        }

        var serializers = classFactory.ResolveAll<IForgedTypeSerialization>();

        foreach (var s in serializers)
        {
            foreach (var t in s.SupportedTypes)
                _serializers[t] = s;

            foreach (var tc in s.SupportedForgedTypeCodes)
                _forgedTypeCodeSerializers[tc] = s;
        }

        _logger = logger;
    }

    public void Serialize<T>(PrimitiveWriter writer, T obj)
    {
        if (obj == null)
            return;

        var t = typeof(T);
        if (_deserializationMethodsCacheByType.TryGetValue(t, out var deserializationDefinition))
            Serialize(writer, obj, deserializationDefinition);
    }

    public void Serialize(PacketScope scope, uint packetId, PrimitiveWriter writer, object obj)
    {
        if (!_deserializationMethodsCache.TryGetValue(scope, out var scopeDictionary) ||
            !scopeDictionary.TryGetValue(packetId, out var deserializationDefinition))
        {
            return;
        }

        Serialize(writer, obj, deserializationDefinition.Item2);
    }

    private void Serialize(PrimitiveWriter writer, object obj, List<PropertyMeta> deserializationDefinition)
    {
        foreach (var prop in deserializationDefinition)
        {
            if (prop.ReflectedProperty.PropertyType.IsArray ||
                (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) ||
                (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(HashSet<>)))
            {
                SerializeCollection(writer, prop, deserializationDefinition, obj);
                continue;
            }

            SerializeProperty(writer, prop, deserializationDefinition, obj, prop.ReflectedProperty.GetValue(obj));
        }
    }

    public DeserializationResult TryDeserialize<T>(PacketBuffer buffer, out T packet)
    {
        var t = typeof(T);

        if (!_systemScope.TryGetValue(t, out var propertyMetas))
        {
            packet = default!;
            return DeserializationResult.UnknownPacket;
        }

        try
        {
            var instance = Activator.CreateInstance<T>();

            if (instance == null)
            {
                packet = default!;
                return DeserializationResult.Error;
            }

            Dictionary<uint, int> collectionSizes = [];
            foreach (var prop in propertyMetas)
            {
                if (prop.ConditionalSerialization != null && !prop.ConditionalSerialization.ShouldDeserialize(instance, prop, propertyMetas))
                    continue;

                var isCollection = prop.ReflectedProperty.PropertyType.IsArray ||
                                   (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) ||
                                   (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(HashSet<>));

                var result = isCollection ? DeserializeCollection(buffer, prop, collectionSizes)
                                 : prop.ReflectedProperty.PropertyType.IsEnum
                                     ? _forgedTypeCodeSerializers[ForgedTypeCode.Enum].Deserialize(buffer, prop, collectionSizes)
                                     : DeserializeProperty(buffer, prop, collectionSizes);

                result = EvaluateSpecialCasting(prop, result);

                if (result != null)
                    prop.ReflectedProperty.SetValue(instance, result);
            }

            packet = instance;
            return DeserializationResult.Success;
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Failed to deserialize packet {PacketId}", t.Name);
        }

        packet = default!;
        return DeserializationResult.Error;
    }

    public DeserializationResult TryDeserialize(PacketScope scope, uint packetId, PacketBuffer buffer, out object packet)
    {
        if (!_deserializationMethodsCache.TryGetValue(scope, out var scopeDictionary))
        {
            packet = default!;
            return DeserializationResult.UnknownPacket;
        }

        if (!scopeDictionary.TryGetValue(packetId, out var deserializationDefinition))
        {
            packet = default!;
            return DeserializationResult.UnknownPacket;
        }

        try
        {
            var instance = Activator.CreateInstance(deserializationDefinition.Item1);

            if (instance == null)
            {
                packet = default!;
                return DeserializationResult.Error;
            }

            Dictionary<uint, int> collectionSizes = [];
            foreach (var prop in deserializationDefinition.Item2)
            {
                if (prop.ConditionalSerialization != null && !prop.ConditionalSerialization.ShouldDeserialize(instance, prop, deserializationDefinition.Item2))
                    continue;

                var isCollection = prop.ReflectedProperty.PropertyType.IsArray ||
                                   (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) ||
                                   (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(HashSet<>));

                var result = isCollection ? DeserializeCollection(buffer, prop, collectionSizes)
                                 : prop.ReflectedProperty.PropertyType.IsEnum
                                     ? _forgedTypeCodeSerializers[ForgedTypeCode.Enum].Deserialize(buffer, prop, collectionSizes)
                                     : DeserializeProperty(buffer, prop, collectionSizes);

                result = EvaluateSpecialCasting(prop, result);

                if (result != null)
                    prop.ReflectedProperty.SetValue(instance, result);
            }

            packet = instance ?? default!;

            return DeserializationResult.Success;
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Failed to deserialize packet {PacketId} for scope {Scope}", packetId, scope);
        }

        packet = default!;
        return DeserializationResult.Error;
    }

    private object? DeserializeCollection(PacketBuffer buffer, PropertyMeta prop, Dictionary<uint, int> collectionSizes)
    {
        var collectionSize = buffer.GetCollectionSize(prop, collectionSizes);
        List<object?> collection = [];
        for (var i = 0; i < collectionSize; i++)
            collection.Add(EvaluateSpecialCasting(prop, DeserializeProperty(buffer, prop, collectionSizes)));

        return prop.ReflectedProperty.PropertyType.IsArray
                   ? collection.ToArray()
                   : prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)
                       ? collection
                       : collection.ToHashSet();
    }

    private void SerializeCollection(PrimitiveWriter writer, PropertyMeta prop, List<PropertyMeta> otherMeta, object obj)
    {
        int i = 0;

        writer.SerializeCollectionSize(prop, otherMeta, obj);

        if (prop.ReflectedProperty.GetValue(obj) is IEnumerable collection)
            foreach (var item in collection)
            {
                SerializeProperty(writer, prop, otherMeta, obj, item);
                i++;
            }

        if (prop.SerializationMetadata.FixedCollectionSize > i)
        {
            for (; i < prop.SerializationMetadata.FixedCollectionSize; i++)
                SerializeProperty(writer, prop, otherMeta, obj, 0);
        }
    }

    private object? DeserializeProperty(PacketBuffer buffer, PropertyMeta prop, Dictionary<uint, int> collectionSizes)
    {
        return TryGetSerializerFromType(prop, out var forgedTypeSerialization)
                   ? forgedTypeSerialization?.Deserialize(buffer, prop, collectionSizes)
                   : null;
    }

    private void SerializeProperty(PrimitiveWriter writer, PropertyMeta prop, List<PropertyMeta> otherMeta, object obj, object? val)
    {
        if (TryGetSerializerFromType(prop, out var forgedTypeSerialization))
        {
            forgedTypeSerialization?.Serialize(writer, prop, otherMeta, obj, val);
        }
    }

#pragma warning disable CS8601
    private bool TryGetSerializerFromType(PropertyMeta prop, out IForgedTypeSerialization forgedTypeSerialization)
    {
        Type propertyType = prop.ReflectedProperty.PropertyType;

        if (propertyType.IsArray)
        {
            var elementType = propertyType.GetElementType() ?? typeof(int); // this should never happen, its to keep the compiler happy.

            return _serializers.TryGetValue(elementType, out forgedTypeSerialization);
        }
        else if (propertyType.IsGenericType &&
                 (propertyType.GetGenericTypeDefinition() == typeof(List<>) ||
                  propertyType.GetGenericTypeDefinition() == typeof(HashSet<>)))
        {
            return _serializers.TryGetValue(propertyType.GetGenericArguments()[0], out forgedTypeSerialization);
        }
        else
        {
            return _forgedTypeCodeSerializers.TryGetValue(prop.SerializationMetadata.OverrideType, out forgedTypeSerialization) ||
                   _serializers.TryGetValue(propertyType, out forgedTypeSerialization);
        }
    }

#pragma warning restore CS8601

    private static object? EvaluateSpecialCasting(PropertyMeta prop, object? val)
    {
        if (val == null)
            return null;

        // check of its a enum we need to parse its value from a string.
        return prop.ReflectedProperty.PropertyType.IsEnum &&
               (prop.SerializationMetadata.OverrideType is ForgedTypeCode.String or
                                                           ForgedTypeCode.ASCIIString or
                                                           ForgedTypeCode.CString or
                                                           ForgedTypeCode.PascalString or
                                                           ForgedTypeCode.FourCCString) &&
               Enum.TryParse(prop.ReflectedProperty.PropertyType, (string)val, true, out var result) &&
               result != null
                   ? result
                   : val;
    }
}