// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using Serilog;
using WrathForged.Common.Networking;
using WrathForged.Serialization;

namespace WrathForged.Common
{
    public class ForgedModelDeserialization
    {
        public enum DeserializationResult
        {
            Success,
            Failure,
            UnknownPacket
        }

        private readonly ILogger _logger;
        public Dictionary<PacketScope, Dictionary<uint, MethodInfo>> DeserializationMethodsCache = new();

        public ForgedModelDeserialization(ILogger logger)
        {
            var methodsWithAttribute = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .SelectMany(type => type.GetMethods(BindingFlags.Static | BindingFlags.Public))
                .Where(method => method.GetCustomAttributes(typeof(DeserializeDefinitionAttribute), false).Length > 0);

            foreach (var method in methodsWithAttribute)
            {
                var attribute = (DeserializeDefinitionAttribute)method.GetCustomAttributes(typeof(DeserializeDefinitionAttribute), false).First();
                if (!DeserializationMethodsCache.TryGetValue(attribute.Scope, out var scopeDictionary))
                {
                    scopeDictionary = new Dictionary<uint, MethodInfo>();
                    DeserializationMethodsCache[attribute.Scope] = scopeDictionary;
                }

                foreach (var packetId in attribute.PacketIDs)
                {
                    scopeDictionary[packetId] = method;
                }
            }

            _logger = logger;
        }

        public DeserializationResult TryDeserialize(PacketScope scope, uint packetId, PacketBuffer buffer, out object? packet)
        {
            if (!DeserializationMethodsCache.TryGetValue(scope, out var scopeDictionary))
            {
                packet = null;
                return DeserializationResult.UnknownPacket;
            }

            if (!scopeDictionary.TryGetValue(packetId, out var method))
            {
                packet = null;
                return DeserializationResult.UnknownPacket;
            }

            try
            {
                packet = method.Invoke(null, new object[] { buffer.Reader });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Failed to deserialize packet {PacketId} for scope {Scope}", packetId, scope);
                packet = null;
            }

            return packet != null ? DeserializationResult.Success : DeserializationResult.Failure;
        }
    }
}