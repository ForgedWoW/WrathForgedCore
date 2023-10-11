// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Auth;
using WrathForged.Models.Auth;
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Realm.Server.Services
{
    public class ClientAuthService(IConfiguration configuration, ILogger logger, ClassFactory classFactory) : IPacketService
    {
        private readonly IConfiguration _configuration = configuration;
        private readonly ILogger _logger = logger;
        private readonly ClassFactory _classFactory = classFactory;

        [PacketRoute(PacketScope.ClientToRealm, RealmServerOpCode.CMSG_AUTH_SESSION)]
        public void PingRequest(WoWClientSession session, RealmAuthSessionRequest realmAuthSessionRequest)
        {
            using var authDatabase = _classFactory.Locate<AuthDatabase>();

            session.Security.Account = authDatabase.Accounts.Find(realmAuthSessionRequest.AccountName);

            if (session.Security.Account == null)
            {
                session.Network.Send(new RealmAuthErrorResponse() { Code = ResponseCodes.AUTH_UNKNOWN_ACCOUNT });
                session.Network.ClientSocket.Disconnect();
                return;
            }

            session.Security.Account.LastIp = session.Network.ClientSocket.IPEndPoint.Address.ToString();
            session.Security.Account.LastLogin = DateTime.UtcNow;
            authDatabase.Update(session.Security.Account);
            authDatabase.SaveChanges();

            session.Security.SessionKey = session.Security.Account.SessionKeyAuth ?? new byte[32];

        }
    }
}
