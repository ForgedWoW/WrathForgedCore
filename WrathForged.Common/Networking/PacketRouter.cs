// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using WrathForged.Models.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Networking;

public class PacketRouter
{
    public enum RouteType
    {
        None,
        DeserializedPacket,
        DirectPacket,
        NoPacket
    }

    private readonly Dictionary<PacketScope, Dictionary<uint, List<(MethodInfo, PacketRouteAttribute, IPacketService)>>> _packetHandlerCache = [];
    private readonly Dictionary<PacketScope, Dictionary<uint, RouteType>> _hasPacketArg = [];

    public PacketRouter(ClassFactory classFactory)
    {
        var packetHandlers = classFactory.LocateAll<IPacketService>();

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
                                                                    ? RouteType.NoPacket
                                                                    : parameters[1].ParameterType == typeof(PacketBuffer)
                                                                    ? RouteType.DirectPacket
                                                                    : RouteType.DeserializedPacket);
                _packetHandlerCache.AddToList(attribute.Scope, attribute.Id, (method, attribute, handler));
            }
        }
    }

    public RouteType GetRouteType(PacketScope scope, uint id)
    {
        if (!_hasPacketArg.TryGetValue(scope, out var scopeDictionary))
        {
            return RouteType.None;
        }

        if (!scopeDictionary.TryGetValue(id, out var hasPacketArg))
        {
            return RouteType.None;
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
                if (method.Item1.IsStatic)
                    _ = method.Item1.Invoke(null, new object[] { socket });
                else
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
                if (method.Item1.IsStatic)
                    _ = method.Item1.Invoke(null, new object[] { socket, packetBuffer });
                else
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
            if (method.Item1.IsStatic)
                _ = method.Item1.Invoke(null, new object[] { socket, packet });
            else
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
            if (method.Item2.RequireAuthentication && session.Security.AuthenticationState != WoWClientSession.AuthState.LoggedIn)
                continue;

            if (method.Item1.IsStatic)
                _ = method.Item1.Invoke(null, new object[] { session, packet });
            else
                _ = method.Item1.Invoke(method.Item3, new object[] { session, packet });
        }
    }
}