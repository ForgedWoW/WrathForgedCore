// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using System.Numerics;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Authorization.Server.Validators;
using WrathForged.Common;
using WrathForged.Common.Cryptography;
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Auth;
using WrathForged.Models.Auth;
using WrathForged.Models.Auth.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Authorization.Server.Services
{
    public class ClientLoginSerivce : IPacketService
    {
        private readonly IConfiguration _configuration;
        private readonly BanValidator _banValidator;
        private readonly ClassFactory _classFactory;
        private readonly RandomUtilities _randomUtilities;
        private readonly ILogger _logger;
        private readonly Dictionary<IPAddress, LoginTracker> _loginTracker = new();

        public ClientLoginSerivce(IConfiguration configuration, BanValidator banValidator, ClassFactory classFactory, RandomUtilities randomUtilities,
                                  ILogger logger)
        {
            _configuration = configuration;
            _banValidator = banValidator;
            _classFactory = classFactory;
            _randomUtilities = randomUtilities;
            _logger = logger;
        }

        [PacketHandler(PacketScope.Auth, AuthServerOpCode.AUTH_LOGON_CHALLENGE)]
        public async void ChallangeRequest(WoWClientSession session, AuthLogonChallengeRequest authLogonChallenge)
        {
            using var authDatabase = _classFactory.Resolve<AuthDatabase>();

            var account = authDatabase.Accounts.FirstOrDefault(x => x.Username == authLogonChallenge.Identity || x.RegMail == authLogonChallenge.Identity);
            var packet = session.NewClientMessage(AuthServerOpCode.AUTH_LOGON_CHALLENGE);

            if (account == null)
            {
                _logger.Debug("Failed login attempt for {Identity} from {Address}. Account not found.", authLogonChallenge.Identity, session.ClientSocket.IPEndPoint.Address);
                LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, packet);
                return;
            }

            var ipString = session.ClientSocket.IPEndPoint.Address.ToString();

            if (account.Locked && account.LastIp != ipString)
            {
                _logger.Debug("Failed login attempt for {Identity} from {Address}. Account locked to IpAddress {LockedIp}", authLogonChallenge.Identity, session.ClientSocket.IPEndPoint.Address, account.LastIp);
                LoginFailed(session, AuthStatus.WOW_FAIL_LOCKED_ENFORCED, packet);
                return;
            }

            var banState = _banValidator.GetBanState(account.Id, ipString);

            switch (banState)
            {
                case BanValidator.BanType.Banned:
                    _logger.Debug("Failed login attempt for {Identity} from {Address}. Account banned.", authLogonChallenge.Identity, session.ClientSocket.IPEndPoint.Address);
                    LoginFailed(session, AuthStatus.WOW_FAIL_BANNED, packet);
                    return;

                case BanValidator.BanType.Suspended:
                    _logger.Debug("Failed login attempt for {Identity} from {Address}. Account suspended.", authLogonChallenge.Identity, session.ClientSocket.IPEndPoint.Address);
                    LoginFailed(session, AuthStatus.WOW_FAIL_SUSPENDED, packet);
                    return;
            }

            _logger.Debug("Login attempt for {Identity} from {Address}. Assigning session token.", authLogonChallenge.Identity, session.ClientSocket.IPEndPoint.Address);
            session.Account = account;
            session.SessionKey = _randomUtilities.RandomBytes(16);
            account.SessionKeyAuth = session.SessionKey;
            session.PasswordAuthenticator = new PasswordAuthenticator(new SecureRemotePassword(account.Username, new BigInteger(account.SessionKeyAuth), true));
            session.State = WoWClientSession.AuthState.AwaitingCredentials;

            _ = await authDatabase.SaveChangesAsync();
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
                _logger.Debug("Too many failed login attempts from {Address}. Disconnecting.", session.ClientSocket.IPEndPoint.Address);
                session.ClientSocket.Disconnect();
                return;
            }

            packet.WriteObject(new AuthResponse()
            {
                Status = status
            });

            session.ClientSocket.EnqueueWrite(packet);
        }
    }
}