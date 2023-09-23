// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections;
using System.Reflection;
using Serilog;
using WrathForged.Common.Networking;
using WrathForged.Common.Scripting;
using WrathForged.Common.Serialization.Serializers;
using WrathForged.Serialization;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization
{
    public class ForgedModelSerializer
    {
        private readonly ILogger _logger;

        /// <summary>
        ///     A cache of all the deserialization definitions for each object and their properties
        /// </summary>
        // Scope OpCode ObjType PropertyName, SerializationMetadata
        private readonly Dictionary<PacketScope, Dictionary<uint, (Type, List<PropertyMeta>)>> _deserializationMethodsCache = new();

        private readonly Dictionary<Type, IForgedTypeSerialization> _serializers = new();
        private readonly Dictionary<ForgedTypeCode, IForgedTypeSerialization> _forgedTypeCodeSerializers = new();

        public ForgedModelSerializer(ILogger logger, ScriptLoader assemblyLoader, ClassFactory classFactory)
        {
            var classesWithAttribute = assemblyLoader.GetAllTypesWithClassAttribute<ForgedSerializableAttribute>();

            // Build the deserialization cache
            foreach (var cls in classesWithAttribute)
            {
                var attribute = (ForgedSerializableAttribute)cls.GetCustomAttributes(typeof(ForgedSerializableAttribute), false).First();

                if (!_deserializationMethodsCache.TryGetValue(attribute.Scope, out var scopeDictionary))
                {
                    scopeDictionary = new Dictionary<uint, (Type, List<PropertyMeta>)>();
                    _deserializationMethodsCache[attribute.Scope] = scopeDictionary;
                }

                foreach (var packetId in attribute.PacketIDs)
                {
                    var propertyAttributes = new List<PropertyMeta>();

                    foreach (var prop in cls.GetProperties())
                    {
                        var propAtt = prop.GetCustomAttribute<SerializablePropertyAttribute>();

                        if (propAtt != null)
                            propertyAttributes.Add(new PropertyMeta(propAtt, prop));
                    }

                    propertyAttributes.Sort();
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

        public void Serialize(PacketScope scope, uint packetId, PrimitiveWriter writer, object obj)
        {
            if (!_deserializationMethodsCache.TryGetValue(scope, out var scopeDictionary) ||
                !scopeDictionary.TryGetValue(packetId, out var deserializationDefinition))
            {
                return;
            }

            foreach (var prop in deserializationDefinition.Item2)
            {
                if (prop.ReflectedProperty.PropertyType.IsArray ||
                                       (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) ||
                                       (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(HashSet<>)))
                {
                    SerializeCollection(writer, prop, deserializationDefinition.Item2, obj);
                    continue;
                }

                SerializeProperty(writer, prop, deserializationDefinition.Item2, obj);
            }
        }

        public DeserializationResult TryDeserialize(PacketScope scope, uint packetId, PacketBuffer buffer, out object? packet)
        {
            if (!_deserializationMethodsCache.TryGetValue(scope, out var scopeDictionary))
            {
                packet = null;
                return DeserializationResult.UnknownPacket;
            }

            if (!scopeDictionary.TryGetValue(packetId, out var deserializationDefinition))
            {
                packet = null;
                return DeserializationResult.UnknownPacket;
            }

            try
            {
                var instance = Activator.CreateInstance(deserializationDefinition.Item1);
                Dictionary<uint, uint> collectionSizes = new();
                foreach (var prop in deserializationDefinition.Item2)
                {
                    var isCollection = prop.ReflectedProperty.PropertyType.IsArray ||
                                        (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) ||
                                        (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(HashSet<>));

                    var result = isCollection ? DeserializeCollection(buffer, prop, collectionSizes)
                        : prop.ReflectedProperty.PropertyType.IsEnum
                        ? _forgedTypeCodeSerializers[ForgedTypeCode.Enum].Deserialize(buffer, prop, collectionSizes)
                        : DeserializeProperty(buffer, prop, collectionSizes);

                    result = EvaluateSpecialCasting(buffer, prop, result);

                    if (result != null)
                        prop.ReflectedProperty.SetValue(instance, result);
                }

                packet = instance;
                return DeserializationResult.Success;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Failed to deserialize packet {PacketId} for scope {Scope}", packetId, scope);
            }

            packet = null;
            return DeserializationResult.Error;
        }

        private object? DeserializeCollection(PacketBuffer buffer, PropertyMeta prop, Dictionary<uint, uint> collectionSizes)
        {
            var collectionSize = buffer.GetCollectionSize(prop, collectionSizes);
            List<object?> collection = new();
            for (var i = 0; i < collectionSize; i++)
                collection.Add(EvaluateSpecialCasting(buffer, prop, DeserializeProperty(buffer, prop, collectionSizes)));

            return prop.ReflectedProperty.PropertyType.IsArray
                    ? collection.ToArray()
                    : prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)
                    ? collection
                    : collection.ToHashSet();
        }

        private void SerializeCollection(PrimitiveWriter writer, PropertyMeta prop, List<PropertyMeta> otherMeta, object obj)
        {
            var collection = (IEnumerable)obj;
            writer.SerializeCollectionSize(prop, otherMeta, obj);
            foreach (var item in collection)
                SerializeProperty(writer, prop, otherMeta, item);
        }

        private object? DeserializeProperty(PacketBuffer buffer, PropertyMeta prop, Dictionary<uint, uint> collectionSizes)
        {
            return _forgedTypeCodeSerializers.TryGetValue(prop.SerializationMetadata.OverrideType, out var forgedTypeSerialization) ||
                       _serializers.TryGetValue(prop.ReflectedProperty.PropertyType, out forgedTypeSerialization)
                ? forgedTypeSerialization?.Deserialize(buffer, prop, collectionSizes)
                : null;
        }

        private void SerializeProperty(PrimitiveWriter writer, PropertyMeta prop, List<PropertyMeta> otherMeta, object obj)
        {
            if (_forgedTypeCodeSerializers.TryGetValue(prop.SerializationMetadata.OverrideType, out var forgedTypeSerialization) ||
                            _serializers.TryGetValue(prop.ReflectedProperty.PropertyType, out forgedTypeSerialization))
            {
                forgedTypeSerialization?.Serialize(writer, prop, otherMeta, obj);
            }
        }

        private object? EvaluateSpecialCasting(PacketBuffer buffer, PropertyMeta prop, object? val)
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
}