// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using Serilog;
using WrathForged.Models.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Networking
{
    public class PacketRouter
    {
        public Dictionary<PacketScope, Dictionary<uint, List<(MethodInfo, PacketRouteAttribute)>>> PacketHandlerCache = new();
        private readonly ILogger _logger;

        public PacketRouter(ClassFactory classFactory, ILogger logger)
        {
            var packetHandlers = classFactory.ResolveAll<IPacketService>();

            foreach (var handler in packetHandlers)
            {
                var type = handler.GetType();
                var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .Where(method => method.GetCustomAttributes(typeof(PacketRouteAttribute), false).Length > 0);

                foreach (var method in methods)
                {
                    var attribute = (PacketRouteAttribute)method.GetCustomAttributes(typeof(PacketRouteAttribute), false).First();
                    if (!PacketHandlerCache.TryGetValue(attribute.Scope, out var scopeDictionary))
                    {
                        scopeDictionary = [];
                        PacketHandlerCache[attribute.Scope] = scopeDictionary;
                    }

                    if (!scopeDictionary.TryGetValue(attribute.Id, out var methodList))
                    {
                        methodList = [];
                        scopeDictionary[attribute.Id] = methodList;
                    }

                    methodList.Add((method, attribute));
                }
            }
            _logger = logger;
        }

        public bool RouteDirect(ClientSocket socket, PacketId packetId, PacketBuffer packetBuffer)
        {
            if (!PacketHandlerCache.TryGetValue(packetId.Scope, out var scopeDictionary))
            {
                return false;
            }

            if (!scopeDictionary.TryGetValue(packetId.Id, out var methodList))
            {
                return false;
            }

            foreach (var method in methodList)
            {
                if (method.Item2.DirectReader)
                {
                    _ = method.Item1.Invoke(null, new object[] { socket, packetId, packetBuffer });
                    return true;
                }
            }

            return false;
        }

        public bool RouteDirect(ClientSocket socket, PacketId packetId, byte[] packetBuffer)
        {
            if (!PacketHandlerCache.TryGetValue(packetId.Scope, out var scopeDictionary))
            {
                return false;
            }

            if (!scopeDictionary.TryGetValue(packetId.Id, out var methodList))
            {
                return false;
            }

            bool evented = false;

            foreach (var method in methodList)
            {
                if (method.Item2.DirectReader)
                {
                    _ = method.Item1.Invoke(null, new object[] { socket, packetId, new PacketBuffer(packetBuffer, _logger) });
                    evented = true;
                }
            }

            return evented;
        }

        public void Route(ClientSocket socket, PacketId packetId, object packet)
        {
            if (packet == null)
            {
                return;
            }

            if (!PacketHandlerCache.TryGetValue(packetId.Scope, out var scopeDictionary))
            {
                return;
            }

            if (!scopeDictionary.TryGetValue(packetId.Id, out var methodList))
            {
                return;
            }

            foreach (var method in methodList)
            {
                _ = method.Item1.Invoke(null, new object[] { socket, packet });
            }
        }

        public void Route(WoWClientSession session, PacketId packetId, object packet)
        {
            if (packet == null)
            {
                return;
            }

            if (!PacketHandlerCache.TryGetValue(packetId.Scope, out var scopeDictionary))
            {
                return;
            }

            if (!scopeDictionary.TryGetValue(packetId.Id, out var methodList))
            {
                return;
            }

            foreach (var method in methodList)
            {
                _ = method.Item1.Invoke(null, new object[] { session, packet });
            }
        }
    }
}