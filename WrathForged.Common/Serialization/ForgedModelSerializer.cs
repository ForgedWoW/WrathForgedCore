﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections;
using System.Diagnostics.Metrics;
using System.Reflection;
using Serilog;
using WrathForged.Common.Networking;
using WrathForged.Common.Observability;
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
    private readonly Histogram<double> _deserializeTime;
    private readonly Histogram<double> _serializeTime;
    private readonly Meter _meter;

    public ForgedModelSerializer(ILogger logger, ScriptLoader assemblyLoader, ClassFactory classFactory, MeterFactory meterFactory)
    {
        var classesWithAttribute = assemblyLoader.GetAllTypesWithClassAttribute<ForgedSerializableAttribute>();
        _meter = meterFactory.GetOrCreateMeter(MeterKeys.WRATHFORGED_COMMON);
        _deserializeTime = _meter.CreateHistogram<double>("DeserializationTime", "Time", "Time to deserialize a packet");
        _serializeTime = _meter.CreateHistogram<double>("SerializationTime", "Time", "Time to serialize a packet");

        // Build the deserialization cache
        foreach (var cls in classesWithAttribute)
        {
            var attribute = (ForgedSerializableAttribute)cls.GetCustomAttributes(typeof(ForgedSerializableAttribute), false).First();

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

            _deserializationMethodsCacheByType[cls] = propertyAttributes;

            if (!_systemScope.TryGetValue(cls, out var propertyAttr))
                _systemScope[cls] = propertyAttributes;

            Queue<PacketScope> scopes = new();
            scopes.Enqueue(attribute.Scope);

            // cache all scopes.
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

                if (!_deserializationMethodsCache.TryGetValue(attribute.Scope, out var scopeDictionary))
                {
                    scopeDictionary = [];
                    _deserializationMethodsCache[attribute.Scope] = scopeDictionary;
                }

                foreach (var packetId in attribute.PacketIDs)
                    scopeDictionary[packetId] = (cls, propertyAttributes);
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

        var t = obj.GetType();
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
        var startTimestamp = DateTime.UtcNow;
        foreach (var prop in deserializationDefinition)
        {
            if (prop.ConditionalSerialization != null && !prop.ConditionalSerialization.ShouldDeserialize(obj, prop, deserializationDefinition))
                continue;

            try
            {
                if (prop.ReflectedProperty.PropertyType.IsArray ||
                    (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) ||
                    (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(HashSet<>)))
                {
                    SerializeCollection(writer, prop, deserializationDefinition, obj);
                    continue;
                }

                var propertyValue = prop.ReflectedProperty.GetValue(obj);
                SerializeProperty(writer, prop, deserializationDefinition, obj, propertyValue);
            }
            catch
            {
                _logger.Error("Failed to serialize property {PropertyName} for packet {Name}.", prop.ReflectedProperty.Name, obj.GetType().Name);
                throw;
            }
        }
        _serializeTime.Record((DateTime.UtcNow - startTimestamp).TotalMilliseconds);
    }

    public DeserializationResult TryDeserialize<T>(PacketBuffer buffer, out T packet)
    {
        var startTimestamp = DateTime.UtcNow;
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
                try
                {
                    if (prop.ConditionalSerialization != null && !prop.ConditionalSerialization.ShouldDeserialize(instance, prop, propertyMetas))
                        continue;

                    var isCollection = prop.ReflectedProperty.PropertyType.IsArray ||
                                       (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) ||
                                       (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(HashSet<>));

                    var result = isCollection ? DeserializeCollection(buffer, prop, collectionSizes)
                                     : prop.ReflectedProperty.PropertyType.IsEnum && !IsStringEnum(prop)
                                         ? _forgedTypeCodeSerializers[ForgedTypeCode.Enum].Deserialize(buffer, prop, collectionSizes)
                                         : DeserializeProperty(buffer, prop, collectionSizes);

                    if (result != null)
                        prop.ReflectedProperty.SetValue(instance, EvaluateSpecialCasting(prop, result));
                }
                catch
                {
                    _logger.Error("Failed to deserialize property {PropertyName} for packet {Name}.", prop.ReflectedProperty.Name, t.Name);
                    throw;
                }
            }

            packet = instance;
            var ms = (DateTime.UtcNow - startTimestamp).TotalMilliseconds;
            _deserializeTime.Record(ms);
            return DeserializationResult.Success;
        }
        catch (EndOfStreamException eos)
        {
            _logger.Error(eos, "Failed to deserialize packet {Name} end of stream.", t.Name);
            packet = default!;
            return DeserializationResult.EndOfStream;
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
        var startTimestamp = DateTime.UtcNow;
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
                try
                {
                    if (prop.ConditionalSerialization != null && !prop.ConditionalSerialization.ShouldDeserialize(instance, prop, deserializationDefinition.Item2))
                        continue;

                    var isCollection = prop.ReflectedProperty.PropertyType.IsArray ||
                                       (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) ||
                                       (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(HashSet<>));

                    var result = isCollection ? DeserializeCollection(buffer, prop, collectionSizes)
                                     : prop.ReflectedProperty.PropertyType.IsEnum && !IsStringEnum(prop)
                                         ? _forgedTypeCodeSerializers[ForgedTypeCode.Enum].Deserialize(buffer, prop, collectionSizes)
                                         : DeserializeProperty(buffer, prop, collectionSizes);

                    if (result != null)
                        prop.ReflectedProperty.SetValue(instance, EvaluateSpecialCasting(prop, result));
                }
                catch
                {
                    _logger.Error("Failed to deserialize property {PropertyName} for packet {PacketId} for scope {Scope}", prop.ReflectedProperty.Name, packetId, scope);
                    throw;
                }
            }

            packet = instance ?? default!;
            var ms = (DateTime.UtcNow - startTimestamp).TotalMilliseconds;
            _deserializeTime.Record(ms);
            return DeserializationResult.Success;
        }
        catch (EndOfStreamException eos)
        {
            _logger.Error(eos, "Failed to deserialize packet {Name} with packet id: {PacketId} for scope: {Scope}. End of stream.", deserializationDefinition.Item1.Name, packetId, scope);
            packet = default!;
            return DeserializationResult.EndOfStream;
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Failed to deserialize packet {Name} with packet id: {PacketId} for scope {Scope}", deserializationDefinition.Item1.Name, packetId, scope);
        }

        packet = default!;
        return DeserializationResult.Error;
    }

    private object? DeserializeCollection(PacketBuffer buffer, PropertyMeta prop, Dictionary<uint, int> collectionSizes)
    {
        var collectionSize = buffer.GetCollectionSize(prop, collectionSizes);
        Type targetType = prop.ReflectedProperty.PropertyType;

        if (targetType.IsArray)
        {
            var elementType = targetType.GetElementType();

            if (elementType == null)
                return null;

            // common case that can save a lot of time.
            if (elementType == typeof(byte))
                return buffer.Reader.ReadBytes(collectionSize);

            Array array = Array.CreateInstance(elementType, collectionSize);
            for (var i = 0; i < collectionSize; i++)
            {
                array.SetValue(EvaluateSpecialCasting(prop, DeserializeProperty(buffer, prop, collectionSizes)), i);
            }
            return array;
        }
        else if (targetType.IsGenericType && targetType.GetGenericTypeDefinition() == typeof(List<>))
        {
            var elementType = targetType.GetGenericArguments()[0];
            var listType = typeof(List<>).MakeGenericType(elementType);

            if (Activator.CreateInstance(listType) is not IList list)
                return null;

            for (var i = 0; i < collectionSize; i++)
            {
                list.Add(EvaluateSpecialCasting(prop, DeserializeProperty(buffer, prop, collectionSizes)));
            }
            return list;
        }
        else if (targetType.IsGenericType && targetType.GetGenericTypeDefinition() == typeof(HashSet<>))
        {
            var elementType = targetType.GetGenericArguments()[0];
            var hashSetType = typeof(HashSet<>).MakeGenericType(elementType);
            var hashSet = Activator.CreateInstance(hashSetType) as dynamic;

            if (hashSet == null)
                return null;

            for (var i = 0; i < collectionSize; i++)
            {
                hashSet.Add(EvaluateSpecialCasting(prop, DeserializeProperty(buffer, prop, collectionSizes)));
            }
            return hashSet;
        }
        else
        {
            return null;
        }
    }


    private void SerializeCollection(PrimitiveWriter writer, PropertyMeta prop, List<PropertyMeta> otherMeta, object obj)
    {
        int i = 0;

        writer.SerializeCollectionSize(prop, otherMeta, obj);

        // common case that can save a lot of time.
        if (prop.ReflectedProperty.PropertyType == typeof(byte[]))
        {
            if (prop.ReflectedProperty.GetValue(obj) is byte[] bytes)
                writer.Write(bytes);
            return;
        }

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
        else if (propertyType.IsEnum)
        {
            forgedTypeSerialization = _forgedTypeCodeSerializers[ForgedTypeCode.Enum];
            return true;
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

        if (IsStringEnum(prop))
        {
            if (Enum.TryParse(prop.ReflectedProperty.PropertyType, val.ToString(), true, out var result) && result != null)
                return result;
            else
                return Activator.CreateInstance(prop.ReflectedProperty.PropertyType); // default enum value if we fail to parse.
        }

        return val;
    }

    private static bool IsStringEnum(PropertyMeta prop)
    {
        return prop.ReflectedProperty.PropertyType.IsEnum &&
                       (prop.SerializationMetadata.OverrideType is ForgedTypeCode.String or
                                                                   ForgedTypeCode.ASCIIString or
                                                                   ForgedTypeCode.CString or
                                                                   ForgedTypeCode.PascalString or
                                                                   ForgedTypeCode.FourCCString);
    }
}