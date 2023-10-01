// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Auth;
using WrathForged.Database.Models.World;
using WrathForged.Models.Core.Comm;
using WrathForged.Serialization.Models;

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

        [PacketHandler(PacketScope.System, ForgedCoreOpCode.AddInstanceServer)]
        public void HandleForgePacket(ClientSocket socket, InstanceServerRegistration serverRegistration)
        {
            _authDatabase.
        }
    }
}
