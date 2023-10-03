using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Auth;
using WrathForged.Models.Auth;
using WrathForged.Models.Auth.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Authorization.Server.Services
{
    public class RealmService(ClassFactory classFactory) : IPacketService
    {
        private readonly ClassFactory _classFactory = classFactory;

        [PacketRoute(PacketScope.ClientToAuth, AuthServerOpCode.REALM_LIST)]
        public void RealmRequest(WoWClientSession session)
        {
            var packet = session.Network.NewClientMessage(new Models.Networking.PacketId(AuthServerOpCode.REALM_LIST, PacketScope.AuthToClient));

            var response = new RealmListResponse();

            using var authDb = _classFactory.Resolve<AuthDatabase>();

            foreach (var realm in authDb.Realmlists.ToList())
            {
                byte numChars = 0;

                if (session.Security.Account != null)
                    numChars = authDb.Realmcharacters.Where(r => r.Realmid == realm.Id && r.Acctid == session.Security.Account.Id).FirstOrDefault()?.Numchars ?? 0;

                var authRealm = new AuthRealm
                {
                    Type = (RealmType)realm.Icon,
                    Status = RealmStatus.Open,
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

            session.Network.ClientSocket.EnqueueWrite(packet);
        }
    }
}
