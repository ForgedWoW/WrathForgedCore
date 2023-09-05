// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using Microsoft.Extensions.Configuration;
using WrathForged.Authorization.Server.Validators;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Auth;
using WrathForged.Models.Auth;
using WrathForged.Models.Auth.Enum;

namespace WrathForged.Authorization.Server.Services
{
    public class ClientLoginSerivce : IPacketService
    {
        private readonly IConfiguration _configuration;
        private readonly BanValidator _banValidator;
        private readonly ClassFactory _classFactory;
        private readonly Dictionary<IPAddress, LoginTracker> _loginTracker = new();

        public ClientLoginSerivce(IConfiguration configuration, BanValidator banValidator, ClassFactory classFactory)
        {
            _configuration = configuration;
            _banValidator = banValidator;
            _classFactory = classFactory;
        }

        [PacketHandler(Serialization.PacketScope.Auth, AuthServerOpCode.AUTH_LOGON_CHALLENGE)]
        public void ChallangeRequest(WoWClientSession session, AuthLogonChallengeRequest authLogonChallenge)
        {
            using var authDatabase = _classFactory.Resolve<AuthDatabase>();

            var account = authDatabase.Accounts.FirstOrDefault(x => x.Username == authLogonChallenge.Identity || x.RegMail == authLogonChallenge.Identity);

            if (account == null)
            {
                session.ClientSocket.EnqueueWrite();
                return;
            }
        }

        private void LoginFailed(WoWClientSession session, AuthStatus status)
        {
            if (!_loginTracker.TryGetValue(session.ClientSocket.IPEndPoint.Address, out var tracker))
            {
                tracker = new LoginTracker();
                _loginTracker[session.ClientSocket.IPEndPoint.Address] = tracker;
            }

            tracker.Attempts++;
            tracker.LastAttempt = DateTime.UtcNow;

            if (_configuration.GetDefaultValue("MaxLoginAttempts", 5) <= tracker.Attempts)
            {
            }
        }
    }
}