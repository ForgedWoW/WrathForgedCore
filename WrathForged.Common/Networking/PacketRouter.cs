// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using WrathForged.Models.Networking;
using WrathForged.Serialization;

namespace WrathForged.Common.Networking
{
    public class PacketRouter
    {
        public Dictionary<PacketScope, Dictionary<int, List<MethodInfo>>> DeserializationMethodsCache = new();

        public PacketRouter()
        {
            var methodsWithAttribute = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .SelectMany(type => type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
                .Where(method => method.GetCustomAttributes(typeof(PacketHandlerAttribute), false).Length > 0);

            foreach (var method in methodsWithAttribute)
            {
                var attribute = (PacketHandlerAttribute)method.GetCustomAttributes(typeof(PacketHandlerAttribute), false).First();
                if (!DeserializationMethodsCache.TryGetValue(attribute.Scope, out var scopeDictionary))
                {
                    scopeDictionary = new Dictionary<int, List<MethodInfo>>();
                    DeserializationMethodsCache[attribute.Scope] = scopeDictionary;
                }

                if (!scopeDictionary.TryGetValue(attribute.Id, out var methodList))
                {
                    methodList = new List<MethodInfo>();
                    scopeDictionary[attribute.Id] = methodList;
                }

                methodList.Add(method);
            }
        }

        public void Route(WoWClientSession session, PacketId packetId, object packet)
        {
            if (packet == null)
                return;

            if (!DeserializationMethodsCache.TryGetValue(packetId.Scope, out var scopeDictionary))
                return;

            if (!scopeDictionary.TryGetValue(packetId.Id, out var methodList))
                return;

            foreach (var method in methodList)
                method.Invoke(null, new object[] { session, packet });
        }
    }
}