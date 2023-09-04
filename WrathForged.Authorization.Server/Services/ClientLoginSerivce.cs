// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using Microsoft.Extensions.Configuration;
using WrathForged.Authorization.Server.Validators;
using WrathForged.Common;
using WrathForged.Common.Networking;
using WrathForged.Models.Auth;
using WrathForged.Models.Auth.Enum;

namespace WrathForged.Authorization.Server.Services
{
    public class ClientLoginSerivce : IPacketService
    {
        private readonly IConfiguration _configuration;
        private readonly BanValidator _banValidator;
        private readonly Dictionary<IPAddress, LoginTracker> _loginTracker = new();

        public ClientLoginSerivce(IConfiguration configuration, BanValidator banValidator)
        {
            _configuration = configuration;
            _banValidator = banValidator;
        }

        [PacketHandler(Serialization.PacketScope.Auth, AuthServerOpCode.AUTH_LOGON_CHALLENGE)]
        public void ChallangeRequest(WoWClientSession session, AuthLogonChallengeRequest authLogonChallenge)
        {
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