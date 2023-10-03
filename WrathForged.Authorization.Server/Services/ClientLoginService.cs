// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Authorization.Server.Services
{
    public class ClientLoginService(IConfiguration configuration, BanValidator banValidator, ClassFactory classFactory, RandomUtilities randomUtilities,
                              ILogger logger) : IPacketService
    {
        private readonly IConfiguration _configuration = configuration;
        private readonly BanValidator _banValidator = banValidator;
        private readonly ClassFactory _classFactory = classFactory;
        private readonly RandomUtilities _randomUtilities = randomUtilities;
        private readonly ILogger _logger = logger;
        private readonly Dictionary<string, LoginTracker> _loginTracker = new();

        [PacketRoute(PacketScope.ClientToAuth, AuthServerOpCode.AUTH_LOGON_CHALLENGE)]
        public void ChallengeRequest(WoWClientSession session, AuthLogonChallengeRequest authLogonChallenge)
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
            account.LastAttemptIp = ipString;

            if (account.Locked && account.LastIp != ipString)
            {
                _logger.Debug("Failed login attempt for {Identity} from {Address}. Account locked to IpAddress {LockedIp}", authLogonChallenge.Identity, session.ClientSocket.IPEndPoint.Address, account.LastIp);
                LoginFailed(session, AuthStatus.WOW_FAIL_LOCKED_ENFORCED, packet);
                account.FailedLogins++;
                authDatabase.Accounts.Update(account);
                return;
            }

            var banState = _banValidator.GetBanState(account.Id, ipString);

            switch (banState)
            {
                case BanValidator.BanType.Banned:
                    _logger.Debug("Failed login attempt for {Identity} from {Address}. Account banned.", authLogonChallenge.Identity, session.ClientSocket.IPEndPoint.Address);
                    LoginFailed(session, AuthStatus.WOW_FAIL_BANNED, packet);
                    account.FailedLogins++;
                    authDatabase.Accounts.Update(account);
                    return;

                case BanValidator.BanType.Suspended:
                    _logger.Debug("Failed login attempt for {Identity} from {Address}. Account suspended.", authLogonChallenge.Identity, session.ClientSocket.IPEndPoint.Address);
                    LoginFailed(session, AuthStatus.WOW_FAIL_SUSPENDED, packet);
                    account.FailedLogins++;
                    authDatabase.Accounts.Update(account);
                    return;
            }

            _logger.Debug("Login attempt for {Identity} from {Address}. Assigning session token.", authLogonChallenge.Identity, session.ClientSocket.IPEndPoint.Address);
            account.Locale = (byte)authLogonChallenge.Locale;
            account.Os = authLogonChallenge.Architecture.ToString();
            account.SessionKeyAuth = session.SessionKey;
            account.Expansion = (byte)authLogonChallenge.Major;

            session.Account = account;
            session.SessionKey = _randomUtilities.RandomBytes(16);
            session.PasswordAuthenticator = new PasswordAuthenticator(new SecureRemotePassword(account.Username, new BigInteger(account.SessionKeyAuth), true));
            session.AuthenticationState = WoWClientSession.AuthState.AwaitingCredentials;
            
            authDatabase.Accounts.Update(account);

            packet.WriteObject(new AuthLogonChallengeResponse()
            {
                Status = AuthStatus.WOW_SUCCESS,
                B = session.PasswordAuthenticator.SRP.PublicEphemeralValueB,
                Generator = SecureRemotePassword.Generator,
                Modulus = SecureRemotePassword.Modulus,
                Salt = session.PasswordAuthenticator.SRP.Salt
            });
            session.ClientSocket.EnqueueWrite(packet);
        }

        [PacketRoute(PacketScope.ClientToAuth, AuthServerOpCode.AUTH_LOGON_PROOF)]
        public void LogonProof(WoWClientSession session, AuthLoginProof proof)
        {
            if (session.PasswordAuthenticator == null)
            {
                session.ClientSocket.Disconnect();
                return;
            }

            if (session.PasswordAuthenticator.IsClientProofValid(proof))
            {
                using var authDatabase = _classFactory.Resolve<AuthDatabase>();

                if (session.Account == null)
                {
                    LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, session.NewClientMessage(AuthServerOpCode.AUTH_LOGON_PROOF));
                    return;
                }

                session.Account = authDatabase.Accounts.Find(session.Account.Id);

                if (session.Account == null)
                {
                    LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, session.NewClientMessage(AuthServerOpCode.AUTH_LOGON_PROOF));
                    return;
                }

                session.Account.LastIp = session.ClientSocket.IPEndPoint.Address.ToString();
                session.Account.LastLogin = DateTime.UtcNow;
                session.Account.SessionKeyAuth = session.SessionKey;
                session.Account.Salt = session.PasswordAuthenticator.SRP.Salt.GetBytes(32);
                session.Account.Verifier = session.PasswordAuthenticator.SRP.Verifier.GetBytes(32);
                session.Account.Online = true;
                session.AuthenticationState = WoWClientSession.AuthState.LoggingIn;

                authDatabase.Accounts.Update(session.Account);

                session.Send(new AuthLoginProofResponse()
                {
                    Status = AccountStatus.Success,
                    Proof = session.PasswordAuthenticator.SRP.ServerSessionKeyProof
                });
            }
            else
                LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, session.NewClientMessage(AuthServerOpCode.AUTH_LOGON_PROOF));
        }

        [PacketRoute(PacketScope.ClientToAuth, AuthServerOpCode.AUTH_RECONNECT_CHALLENGE)]
        public void ReconnectChallengeRequest(WoWClientSession session, AuthLogonChallengeRequest authLogonChallenge)
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
            account.LastAttemptIp = ipString;
            account.LastIp = ipString;
            session.AuthenticationState = WoWClientSession.AuthState.AwaitingCredentials;

            session.Send(new AuthReconnectedResponse()
            {
                Status = AuthStatus.WOW_SUCCESS,
                ReconnectProof = _randomUtilities.RandomBytes(16)
            });
        }

        [PacketRoute(PacketScope.ClientToAuth, AuthServerOpCode.AUTH_RECONNECT_PROOF)]
        public void ReconnectProof(WoWClientSession session, AuthReconnectedProof proof)
        {
            if (session.Account == null)
            {
                session.ClientSocket.Disconnect();
                return;
            }

            if (session.Account.SessionKeyAuth == null)
            {
                session.ClientSocket.Disconnect();
                return;
            }

            session.AuthenticationState = WoWClientSession.AuthState.LoggingIn;
            session.Send(new AuthReconnectProofResponse()
            {
                Status = AuthStatus.WOW_SUCCESS
            });
        }

        private void LoginFailed(WoWClientSession session, AuthStatus status, WoWClientPacketOut packet)
        {
            if (!_loginTracker.TryGetValue(session.ClientSocket.IPEndPoint.Address.ToString(), out var tracker))
            {
                tracker = new LoginTracker();
                _loginTracker[session.ClientSocket.IPEndPoint.Address.ToString()] = tracker;
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