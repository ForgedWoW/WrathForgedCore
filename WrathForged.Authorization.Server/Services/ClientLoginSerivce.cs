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
            var packet = new WoWClientPacketOut(AuthServerOpCode.AUTH_LOGON_CHALLENGE);

            if (account == null)
            {
                LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, packet);
                return;
            }

            var ipString = session.ClientSocket.IPEndPoint.Address.ToString();

            if (account.Locked && account.LastIp != ipString)
            {
                LoginFailed(session, AuthStatus.WOW_FAIL_UNLOCKABLE_LOCK, packet);
                return;
            }

            var banState = _banValidator.GetBanState(account.Id, ipString);

            switch (banState)
            {
                case BanValidator.BanType.Banned:
                    LoginFailed(session, AuthStatus.WOW_FAIL_BANNED, packet);
                    return;

                case BanValidator.BanType.Suspended:
                    LoginFailed(session, AuthStatus.WOW_FAIL_SUSPENDED, packet);
                    return;
            }
        }

        private void LoginFailed(WoWClientSession session, AuthStatus status, WoWClientPacketOut packet)
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

            new AuthResponse()
            {
                Status = status
            }.Serialize(packet.Writer);

            session.ClientSocket.EnqueueWrite(packet);
        }
    }
}