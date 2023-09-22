// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using Serilog;
using WrathForged.Common.Networking;
using WrathForged.Common.Scripting;
using WrathForged.Common.Serialization.Serializers;
using WrathForged.Serialization;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization
{
    public class ForgedModelDeserialization
    {
        private readonly ILogger _logger;

        /// <summary>
        ///     A cache of all the deserialization definitions for each object and their properties
        /// </summary>
        // Scope OpCode ObjType PropertyName, SerializationMetadata
        private readonly Dictionary<PacketScope, Dictionary<uint, (Type, List<PropertyMeta>)>> _deserializationMethodsCache = new();

        private readonly Dictionary<Type, IForgedTypeSerialization> _serializers = new();
        private readonly Dictionary<ForgedTypeCode, IForgedTypeSerialization> _forgedTypeCodeSerializers = new();

        public ForgedModelDeserialization(ILogger logger, ScriptLoader assemblyLoader, ClassFactory classFactory)
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

        public DeserializationResult TryDeserialize(PacketScope scope, int packetId, PacketBuffer buffer, out object? packet)
        {
            if (!_deserializationMethodsCache.TryGetValue(scope, out var scopeDictionary))
            {
                packet = null;
                return DeserializationResult.UnknownPacket;
            }

            if (!scopeDictionary.TryGetValue((uint)packetId, out var deserializationDefinition))
            {
                packet = null;
                return DeserializationResult.UnknownPacket;
            }

            try
            {
                var instance = Activator.CreateInstance(deserializationDefinition.Item1);

                foreach (var prop in deserializationDefinition.Item2)
                {
                    var isCollection = prop.Property.PropertyType.IsArray || (prop.Property.PropertyType.IsGenericType && prop.Property.PropertyType.GetGenericTypeDefinition() == typeof(List<>));
                    var result = isCollection ? ProcessCollection(buffer, prop)
                        : prop.Property.PropertyType.IsEnum
                        ? ProcessEnum(buffer, prop)
                        : ProcessProperty(buffer, prop);

                    if (result != null)
                        prop.Property.SetValue(instance, result);
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

        private object? ProcessEnum(PacketBuffer buffer, PropertyMeta prop)
        {
        }

        private object? ProcessCollection(PacketBuffer buffer, PropertyMeta prop)
        {
        }

        private object? ProcessProperty(PacketBuffer buffer, PropertyMeta prop)
        {
            return _forgedTypeCodeSerializers.TryGetValue(prop.Attribute.OverrideType, out var forgedTypeSerialization) ||
                       _serializers.TryGetValue(prop.Property.PropertyType, out forgedTypeSerialization)
                ? forgedTypeSerialization?.Deserialize(buffer, prop.Attribute)
                : null;
        }
    }
}