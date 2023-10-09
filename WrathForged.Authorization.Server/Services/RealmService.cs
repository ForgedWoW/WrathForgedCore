// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Serilog;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Common.Serialization;
using WrathForged.Database.Models.Auth;
using WrathForged.Models.Auth;
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Authorization.Server.Services
{
    public class RealmService(ClassFactory classFactory, ILogger logger, ForgedModelSerializer forgedModelSerializer) : IPacketService
    {
        private readonly ClassFactory _classFactory = classFactory;
        private readonly ILogger _logger = logger;
        private readonly ForgedModelSerializer _forgedModelSerializer = forgedModelSerializer;

        [PacketRoute(PacketScope.ClientToAuth, AuthServerOpCode.REALM_LIST)]
        public void RealmRequest(WoWClientSession session)
        {
            _logger.Debug("Realm list request from {Address}", session.Network.ClientSocket.IPEndPoint.Address.ToString());
            var packet = session.Network.NewClientMessage(new PacketId(AuthServerOpCode.REALM_LIST, PacketScope.AuthToClient), PacketHeaderType.OnlyOpCode);

            var response = new RealmListResponse();

            using var authDb = _classFactory.Resolve<AuthDatabase>();

            foreach (var realm in authDb.Realmlists.ToList())
            {
                byte numChars = 0;

                if (session.Security.Account != null)
                    numChars = authDb.Realmcharacters.Where(r => r.Realmid == realm.Id && r.Acctid == session.Security.Account.Id).FirstOrDefault()?.Numchars ?? 0;

                var realmStatus = RealmStatus.Open;

                if (realm.AllowedSecurityLevel > 0 && session.Security.Account != null && session.Security.CurrentRealmRole.SecurityLevel < realm.AllowedSecurityLevel)
                    realmStatus = RealmStatus.Locked;

                var authRealm = new AuthRealm
                {
                    Type = (RealmType)realm.Icon,
                    Status = realmStatus,
                    Flags = (RealmFlags)realm.Flag,
                    Name = realm.Name,
                    Address = realm.Address + ":" + realm.Port,
                    Population = realm.Population,
                    Characters = numChars,
                    Category = (RealmCategory)realm.Timezone,
                    RealmId = (byte)realm.Id,
                    Version = new RealmClientVersion
                    {
                        Major = 3,
                        Minor = 3,
                        Revision = 5,
                        Build = 12340
                    }
                };

                response.Realms.Add(authRealm);
            }

            var pw = new PrimitiveWriter();
            pw.Write(0);
            pw.Write((short)response.Realms.Count);
            _forgedModelSerializer.Serialize(pw, response);

            packet.Writer.Write((short)pw.BaseStream.Length);
            packet.Writer.Write(pw);

            session.Network.ClientSocket.EnqueueWrite(packet);
        }
    }
}
