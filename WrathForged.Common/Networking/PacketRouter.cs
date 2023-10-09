// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using Serilog;
using WrathForged.Models.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Networking;

public class PacketRouter
{
    public enum RoutType
    {
        None,
        DeserializedPacket,
        DirectPacket,
        NoPacket
    }

    private Dictionary<PacketScope, Dictionary<uint, List<(MethodInfo, PacketRouteAttribute, IPacketService)>>> _packetHandlerCache = new();
    private readonly Dictionary<PacketScope, Dictionary<uint, RoutType>> _hasPacketArg = new();
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
                var parameters = method.GetParameters();
                var attribute = (PacketRouteAttribute)method.GetCustomAttributes(typeof(PacketRouteAttribute), false).First();
                _hasPacketArg.Add(attribute.Scope, attribute.Id, parameters.Length == 1
                                                                    ? RoutType.NoPacket
                                                                    : parameters[1].ParameterType == typeof(PacketBuffer)
                                                                    ? RoutType.DirectPacket
                                                                    : RoutType.DeserializedPacket);
                _packetHandlerCache.AddToList(attribute.Scope, attribute.Id, (method, attribute, handler));
            }
        }

        _logger = logger;
    }

    public RoutType GetRouteType(PacketScope scope, uint id)
    {
        if (!_hasPacketArg.TryGetValue(scope, out var scopeDictionary))
        {
            return RoutType.None;
        }

        if (!scopeDictionary.TryGetValue(id, out var hasPacketArg))
        {
            return RoutType.None;
        }

        return hasPacketArg;
    }

    public bool Route(WoWClientSession socket, PacketId packetId)
    {
        if (!_packetHandlerCache.TryGetValue(packetId.Scope, out var scopeDictionary))
        {
            return false;
        }

        if (!scopeDictionary.TryGetValue(packetId.Id, out var methodList))
        {
            return false;
        }

        foreach (var method in methodList)
        {
            if (!method.Item2.DirectReader)
            {
                _ = method.Item1.Invoke(method.Item3, new object[] { socket });
                return true;
            }
        }

        return false;
    }

    public bool RouteDirect(WoWClientSession socket, PacketId packetId, PacketBuffer packetBuffer)
    {
        if (!_packetHandlerCache.TryGetValue(packetId.Scope, out var scopeDictionary))
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
                _ = method.Item1.Invoke(method.Item3, new object[] { socket, packetBuffer });
                return true;
            }
        }

        return false;
    }

    public void Route(ClientSocket socket, PacketId packetId, object packet)
    {
        if (packet == null)
        {
            return;
        }

        if (!_packetHandlerCache.TryGetValue(packetId.Scope, out var scopeDictionary))
        {
            return;
        }

        if (!scopeDictionary.TryGetValue(packetId.Id, out var methodList))
        {
            return;
        }

        foreach (var method in methodList)
        {
            _ = method.Item1.Invoke(method.Item3, new object[] { socket, packet });
        }
    }

    public void Route(WoWClientSession session, PacketId packetId, object packet)
    {
        if (packet == null)
        {
            return;
        }

        if (!_packetHandlerCache.TryGetValue(packetId.Scope, out var scopeDictionary))
        {
            return;
        }

        if (!scopeDictionary.TryGetValue(packetId.Id, out var methodList))
        {
            return;
        }

        foreach (var method in methodList)
        {
            _ = method.Item1.Invoke(method.Item3, new object[] { session, packet });
        }
    }
}