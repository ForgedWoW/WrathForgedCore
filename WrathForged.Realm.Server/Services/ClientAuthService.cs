// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Text;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common;
using WrathForged.Common.Cryptography;
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Auth;
using WrathForged.Models.Auth;
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Realm.Server.Services
{
    public class ClientAuthService(IConfiguration configuration, ILogger logger, ClassFactory classFactory, RandomUtilities random) : IPacketService
    {
        private readonly IConfiguration _configuration = configuration;
        private readonly ILogger _logger = logger;
        private readonly ClassFactory _classFactory = classFactory;
        private byte[] _authSeed = random.RandomBytes(4);

        [PacketRoute(PacketScope.ClientToRealm, RealmServerOpCode.CMSG_AUTH_SESSION)]
        public void AuthSession(WoWClientSession session, RealmAuthSessionRequest realmAuthSessionRequest)
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

            var realmId = _configuration.GetDefaultValue("RealmId", 1);

            if (realmId != realmAuthSessionRequest.RealmId)
            {
                session.Network.Send(new RealmAuthErrorResponse() { Code = ResponseCodes.REALM_LIST_REALM_NOT_FOUND });
                session.Network.ClientSocket.Disconnect();
                return;
            }

            var t = new byte[4] { 0x00, 0x00, 0x00, 0x00 };

            var serverDigest = HashUtil.ComputeHash(Encoding.ASCII.GetBytes(realmAuthSessionRequest.AccountName),
                                                    t,
                                                    realmAuthSessionRequest.LocalChallenge,
                                                    _authSeed,
                                                    session.Security.SessionKey);

            if (!serverDigest.SequenceEqual(realmAuthSessionRequest.Digest))
            {
                session.Network.Send(new RealmAuthErrorResponse() { Code = ResponseCodes.AUTH_FAILED });
                session.Network.ClientSocket.Disconnect();
                return;
            }
        }
    }
}
