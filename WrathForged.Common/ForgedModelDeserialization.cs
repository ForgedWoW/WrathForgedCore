﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using Serilog;
using WrathForged.Common.Networking;
using WrathForged.Serialization;

namespace WrathForged.Common
{
    public class ForgedModelDeserialization
    {
        private readonly ILogger _logger;
        public Dictionary<PacketScope, Dictionary<int, MethodInfo>> DeserializationMethodsCache = new();

        public ForgedModelDeserialization(ILogger logger)
        {
            var methodsWithAttribute = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .SelectMany(type => type.GetMethods(BindingFlags.Instance | BindingFlags.Public))
                .Where(method => method.GetCustomAttributes(typeof(DeserializeDefinitionAttribute), false).Length > 0);

            foreach (var method in methodsWithAttribute)
            {
                var attribute = (DeserializeDefinitionAttribute)method.GetCustomAttributes(typeof(DeserializeDefinitionAttribute), false).First();
                if (!DeserializationMethodsCache.TryGetValue(attribute.Scope, out var scopeDictionary))
                {
                    scopeDictionary = new Dictionary<int, MethodInfo>();
                    DeserializationMethodsCache[attribute.Scope] = scopeDictionary;
                }

                foreach (var packetId in attribute.PacketIDs)
                {
                    scopeDictionary[packetId] = method;
                }
            }

            _logger = logger;
        }

        public DeserializationResult TryDeserialize(PacketScope scope, int packetId, PacketBuffer buffer, out object? packet)
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
                // Create an array to hold the parameters for the method invocation
                var parameters = new object?[] { buffer.Reader }; // Assuming the method has one input and one out parameter

                // Invoke the method
                if (method.DeclaringType == null)
                {
                    packet = null;
                    return DeserializationResult.UnknownPacket;
                }

                packet = Activator.CreateInstance(method.DeclaringType);
                var result = method.Invoke(packet, parameters);

                // Retrieve the out parameter's value from the array
                packet = parameters[1];

                if (result != null)
                    return (DeserializationResult)result; // Assuming the method returns a DeserializationResult
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Failed to deserialize packet {PacketId} for scope {Scope}", packetId, scope);
                packet = null;
            }

            return DeserializationResult.Error;
        }
    }
}