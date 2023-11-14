// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Linq.Expressions;
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

    private readonly Dictionary<PacketScope, Dictionary<uint, List<(Delegate, PacketRouteAttribute, IPacketService)>>> _packetHandlerCache = [];
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

                _packetHandlerCache.AddToList(attribute.Scope, attribute.Id, (CreateDelegate(method, parameters, handler), attribute, handler));
            }
        }
    }

    public RouteType GetRouteType(PacketScope scope, uint id)
    {
        return !_hasPacketArg.TryGetValue(scope, out var scopeDictionary)
            ? RouteType.None
            : !scopeDictionary.TryGetValue(id, out var hasPacketArg) ? RouteType.None : hasPacketArg;
    }

    public bool Route(IWoWClientSession socket, PacketId packetId)
    {
        if (!_packetHandlerCache.TryGetValue(packetId.Scope, out var scopeDictionary))
        {
            return false;
        }

        if (!scopeDictionary.TryGetValue(packetId.Id, out var methodList))
        {
            return false;
        }

        foreach (var (handlerDelegate, attribute, _) in methodList)
        {
            if (!attribute.DirectReader)
            {
                _ = handlerDelegate.DynamicInvoke(socket);
                return true;
            }
        }

        return false;
    }

    public bool RouteDirect(IWoWClientSession socket, PacketId packetId, PacketBuffer packetBuffer)
    {
        if (!_packetHandlerCache.TryGetValue(packetId.Scope, out var scopeDictionary))
        {
            return false;
        }

        if (!scopeDictionary.TryGetValue(packetId.Id, out var methodList))
        {
            return false;
        }

        foreach (var (handlerDelegate, attribute, _) in methodList)
        {
            if (attribute.DirectReader)
            {
                _ = handlerDelegate.DynamicInvoke(socket, packetBuffer);
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

        foreach (var (handlerDelegate, _, _) in methodList)
        {
            _ = handlerDelegate.DynamicInvoke(socket, packet);
        }
    }

    public void Route(IWoWClientSession session, PacketId packetId, object packet)
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

        foreach (var (handlerDelegate, attribute, service) in methodList)
        {
            if (attribute.RequireAuthentication && session.Security.IsAuthenticated)
                continue;

            if (attribute.RequiredRoles.Length > 0 && attribute.RequiredRoles.Any(r => !session.Security.HasPermission(r)))
                continue;

            if (attribute.RequiredSecurityLevel > 0 && !session.Security.IsAtLeastSecurityLevel(attribute.RequiredSecurityLevel))
                continue;

            _ = handlerDelegate.DynamicInvoke(session, packet);
        }
    }

    private Delegate CreateDelegate(MethodInfo method, ParameterInfo[] parameters, object target)
    {
        var paramExpressions = new ParameterExpression[parameters.Length];

        // Create an expression for each parameter
        for (var i = 0; i < parameters.Length; i++)
        {
            paramExpressions[i] = Expression.Parameter(parameters[i].ParameterType, parameters[i].Name);
        }

        // Create a method call expression
        Expression callExpr;
        if (method.IsStatic)
        {
            // For static methods, don't use an instance expression
            callExpr = Expression.Call(null, method, paramExpressions);
        }
        else
        {
            // For instance methods, use a constant expression for the target instance
            var instanceExpr = Expression.Constant(target);
            callExpr = Expression.Call(instanceExpr, method, paramExpressions);
        }

        // Compile the expression into a delegate
        return Expression.Lambda(callExpr, paramExpressions).Compile();
    }
}