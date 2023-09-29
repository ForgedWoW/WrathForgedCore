// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Networking;
using WrathForged.Database.Models.World;
using WrathForged.Models.Core.Comm;
using WrathForged.Serialization.Models;

namespace WrathForged.Realm.Server.Services
{
    public class InstanceServerService : IPacketService
    {
        private readonly WorldDatabase _worldDatabase;

        public InstanceServerService(WorldDatabase worldDatabase) => _worldDatabase = worldDatabase;

        [PacketHandler(PacketScope.System, ForgedCoreOpCode.AddInstanceServer)]
        public void HandleForgePacket(ClientSocket socket, InstanceServerRegistration serverRegistration)
        {

        }
    }
}
