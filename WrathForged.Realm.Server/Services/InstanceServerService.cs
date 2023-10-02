// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Realm.Server.Services
{
    public class InstanceServerService : IPacketService
    {
        private readonly WorldDatabase _worldDatabase;
        private readonly AuthDatabase _authDatabase;

        public InstanceServerService(WorldDatabase worldDatabase, AuthDatabase authDatabase)
        {
            _worldDatabase = worldDatabase;
            _authDatabase = authDatabase;
        }

        public Dictionary<uint, InstanceServerRegistration> InstanceServers { get; } = new();

        [PacketHandler(PacketScope.System, ForgedCoreOpCode.AddInstanceServer)]
        public void RegisterInstanceServer(ClientSocket socket, InstanceServerRegistration serverRegistration) => InstanceServers[serverRegistration.Id] = serverRegistration;

        [PacketHandler(PacketScope.System, ForgedCoreOpCode.AddInstanceServer)]
        public void UnregisterInstanceServer(ClientSocket socket, InsanceServerShutdown serverShutdown) => InstanceServers.Remove(serverShutdown.Id);
    }
}
