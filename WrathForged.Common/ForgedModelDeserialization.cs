﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using WrathForged.Serialization;

namespace WrathForged.Common
{
    public class ForgedModelDeserialization
    {
        public Dictionary<uint, MethodInfo> DeserializationMethodsCache = new();

        public ForgedModelDeserialization()
        {
            var methodsWithAttribute = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .SelectMany(type => type.GetMethods(BindingFlags.Static | BindingFlags.Public))
                .Where(method => method.GetCustomAttributes(typeof(DeserializeDefinitionAttribute), false).Length > 0);

            foreach (var method in methodsWithAttribute)
            {
                var attribute = (DeserializeDefinitionAttribute)method.GetCustomAttributes(typeof(DeserializeDefinitionAttribute), false).First();
                foreach (var packetId in attribute.PacketIDs)
                {
                    DeserializationMethodsCache[packetId] = method;
                }
            }
        }
    }
}