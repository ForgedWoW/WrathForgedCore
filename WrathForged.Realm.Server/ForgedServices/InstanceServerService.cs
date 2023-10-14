// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.Collections.Concurrent;
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Auth;
using WrathForged.Database.Models.World;
using WrathForged.Models.Core.Enum;
using WrathForged.Models.Core.Packets;
using WrathForged.Serialization.Models;

namespace WrathForged.Realm.Server.ForgedServices;

public class InstanceServerService(WorldDatabase worldDatabase, AuthDatabase authDatabase) : IPacketService
{
    private readonly WorldDatabase _worldDatabase = worldDatabase;
    private readonly AuthDatabase _authDatabase = authDatabase;

    public ConcurrentDictionary<uint, InstanceServerRegistration> InstanceServers { get; } = [];
    public ConcurrentDictionary<uint, ConcurrentDictionary<uint, List<InstanceServerRegistration>>> InstanceServersByMapAndDifficulty { get; } = [];

    [PacketRoute(PacketScope.System, ForgedCoreOpCode.AddInstanceServer)]
    public void RegisterInstanceServer(ClientSocket socket, InstanceServerRegistration serverRegistration)
    {
        InstanceServers[serverRegistration.Id] = serverRegistration;

        foreach (var map in serverRegistration.MapIDs)
            foreach (var difficulty in map.Difficulties)
                InstanceServersByMapAndDifficulty.GetOrAdd(map.MapId, _ => new ConcurrentDictionary<uint, List<InstanceServerRegistration>>())
                        .GetOrAdd(difficulty, _ => new List<InstanceServerRegistration>())
                        .Add(serverRegistration);
    }

    [PacketRoute(PacketScope.System, ForgedCoreOpCode.AddInstanceServer)]
    public void UnregisterInstanceServer(ClientSocket socket, InstanceServerShutdown serverShutdown)
    {
        _ = InstanceServers.TryRemove(serverShutdown.Id, out var serverRegistration);

        if (serverRegistration != null)
            foreach (var map in serverRegistration.MapIDs)
                foreach (var difficulty in map.Difficulties)
                    if (InstanceServersByMapAndDifficulty.TryGetValue(map.MapId, out var difficultyDict))
                    {
                        if (difficultyDict.TryGetValue(difficulty, out var servers))
                        {
                            _ = servers.Remove(serverRegistration);

                            if (servers.Count == 0)
                                _ = difficultyDict.TryRemove(difficulty, out _);
                        }

                        if (difficultyDict.IsEmpty)
                            _ = InstanceServersByMapAndDifficulty.TryRemove(map.MapId, out _);
                    }
    }
}
