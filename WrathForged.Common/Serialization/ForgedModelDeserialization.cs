// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using Serilog;
using WrathForged.Common.Networking;
using WrathForged.Common.Scripting;
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
        //                          Scope                  OpCode  ObjType         PropertyName, SerializationMetadata
        private readonly Dictionary<PacketScope, Dictionary<uint, (Type, Dictionary<string, (SerializablePropertyAttribute, PropertyInfo)>)>> _deserializationMethodsCache = new();

        public ForgedModelDeserialization(ILogger logger, ScriptLoader assemblyLoader)
        {
            var classesWithAttribute = assemblyLoader.GetAllTypesWithClassAttribute<ForgedSerializableAttribute>();

            foreach (var cls in classesWithAttribute)
            {
                var attribute = (ForgedSerializableAttribute)cls.GetCustomAttributes(typeof(ForgedSerializableAttribute), false).First();

                if (!_deserializationMethodsCache.TryGetValue(attribute.Scope, out var scopeDictionary))
                {
                    scopeDictionary = new Dictionary<uint, (Type, Dictionary<string, (SerializablePropertyAttribute, PropertyInfo)>)>();
                    _deserializationMethodsCache[attribute.Scope] = scopeDictionary;
                }

                foreach (var packetId in attribute.PacketIDs)
                {
                    var propertyAttributes = new Dictionary<string, (SerializablePropertyAttribute, PropertyInfo)>();

                    foreach (var prop in cls.GetProperties())
                    {
                        var propAtt = prop.GetCustomAttribute<SerializablePropertyAttribute>();

                        if (propAtt != null)
                            propertyAttributes[prop.Name] = (propAtt, prop);
                    }

                    scopeDictionary[packetId] = (cls, propertyAttributes);
                }
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
                    prop.Value.Item2.SetValue(instance, buffer);
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
    }
}