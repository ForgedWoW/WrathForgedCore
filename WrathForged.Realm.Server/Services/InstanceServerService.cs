// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using WrathForged.Common.Networking;
using WrathForged.Database.Models.Auth;
using WrathForged.Database.Models.World;
using WrathForged.Models.Core.Comm;
using WrathForged.Serialization.Models;

namespace WrathForged.Realm.Server.Services
{
    public class InstanceServerService(WorldDatabase worldDatabase, AuthDatabase authDatabase) : IPacketService
    {
        private readonly WorldDatabase _worldDatabase = worldDatabase;
        private readonly AuthDatabase _authDatabase = authDatabase;

        public Dictionary<uint, InstanceServerRegistration> InstanceServers { get; } = new();

        [PacketRoute(PacketScope.System, ForgedCoreOpCode.AddInstanceServer)]
        public void RegisterInstanceServer(ClientSocket socket, InstanceServerRegistration serverRegistration) => InstanceServers[serverRegistration.Id] = serverRegistration;

        [PacketRoute(PacketScope.System, ForgedCoreOpCode.AddInstanceServer)]
        public void UnregisterInstanceServer(ClientSocket socket, InsanceServerShutdown serverShutdown) => InstanceServers.Remove(serverShutdown.Id);
    }
}
