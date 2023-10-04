// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Text;
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
            _logger.Debug("Login challenge request from {Address}", session.Network.ClientSocket.IPEndPoint.Address.ToString());
            using var authDatabase = _classFactory.Resolve<AuthDatabase>();

            var account = authDatabase.Accounts.FirstOrDefault(x => x.Username == authLogonChallenge.Identity || x.RegMail == authLogonChallenge.Identity);
            var packet = session.Network.NewClientMessage(AuthServerOpCode.AUTH_LOGON_CHALLENGE, PacketHeaderType.NullTerminatedOpCode);

            if (account == null)
            {
                _logger.Debug("Failed login attempt for {Identity} from {Address}. Account not found.", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint.Address);
                LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, packet);
                return;
            }

            var ipString = session.Network.ClientSocket.IPEndPoint.Address.ToString();
            account.LastAttemptIp = ipString;

            if (account.Locked && account.LastIp != ipString)
            {
                _logger.Debug("Failed login attempt for {Identity} from {Address}. Account locked to IpAddress {LockedIp}", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint.Address, account.LastIp);
                LoginFailed(session, AuthStatus.WOW_FAIL_LOCKED_ENFORCED, packet);
                account.FailedLogins++;
                authDatabase.Accounts.Update(account);
                authDatabase.SaveChanges();
                return;
            }

            var banState = _banValidator.GetBanState(account.Id, ipString);

            switch (banState)
            {
                case BanValidator.BanType.Banned:
                    _logger.Debug("Failed login attempt for {Identity} from {Address}. Account banned.", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint.Address);
                    LoginFailed(session, AuthStatus.WOW_FAIL_BANNED, packet);
                    account.FailedLogins++;
                    authDatabase.Accounts.Update(account);
                    authDatabase.SaveChanges();
                    return;

                case BanValidator.BanType.Suspended:
                    _logger.Debug("Failed login attempt for {Identity} from {Address}. Account suspended.", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint.Address);
                    LoginFailed(session, AuthStatus.WOW_FAIL_SUSPENDED, packet);
                    account.FailedLogins++;
                    authDatabase.Accounts.Update(account);
                    authDatabase.SaveChanges();
                    return;
            }

            _logger.Debug("Login attempt for {Identity} from {Address}. Assigning session token.", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint.Address);

            session.Security.Account = account;
            session.Security.SessionKey = _randomUtilities.RandomBytes(16);

            account.Locale = (byte)authLogonChallenge.Locale;
            account.Os = authLogonChallenge.Architecture.ToString();
            account.SessionKeyAuth = session.Security.SessionKey;
            account.Expansion = (byte)authLogonChallenge.Major;

            session.Security.AuthenticationState = WoWClientSession.AuthState.AwaitingCredentials;

            authDatabase.Accounts.Update(account);

            packet.WriteObject(new AuthLogonChallengeResponse()
            {
                Status = AuthStatus.WOW_SUCCESS,
                ServerEphemeral = session.Security.SRP6.ServerEphemeral.ToProperByteArray().Pad(32),
                Generator = session.Security.SRP6.Generator.ToProperByteArray(),
                Modulus = session.Security.SRP6.Modulus.ToProperByteArray().Pad(32),
                Salt = session.Security.SRP6.Salt.ToProperByteArray().Pad(32)
            });
            session.Network.ClientSocket.EnqueueWrite(packet);

            authDatabase.SaveChanges();
        }

        [PacketRoute(PacketScope.ClientToAuth, AuthServerOpCode.AUTH_LOGON_PROOF)]
        public void LogonProof(WoWClientSession session, AuthLoginProof proof)
        {
            _logger.Debug("Logon proof request from {Address}", session.Network.ClientSocket.IPEndPoint.Address.ToString());
            session.Security.SRP6.ClientEphemeral = proof.PublicEphemeralValueA;
            session.Security.SRP6.ClientProof = proof.Proof;

            if (session.Security.SRP6.ClientProof == session.Security.SRP6.GenerateClientProof())
            {
                using var authDatabase = _classFactory.Resolve<AuthDatabase>();

                if (session.Security.Account == null)
                {
                    LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, session.Network.NewClientMessage(AuthServerOpCode.AUTH_LOGON_PROOF, PacketHeaderType.OnlyOpCode));
                    return;
                }

                session.Security.Account = authDatabase.Accounts.Find(session.Security.Account.Id);

                if (session.Security.Account == null)
                {
                    LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, session.Network.NewClientMessage(AuthServerOpCode.AUTH_LOGON_PROOF, PacketHeaderType.OnlyOpCode));
                    return;
                }

                session.Security.Account.LastIp = session.Network.ClientSocket.IPEndPoint.Address.ToString();
                session.Security.Account.LastLogin = DateTime.UtcNow;
                session.Security.Account.SessionKeyAuth = session.Security.SessionKey;
                session.Security.Account.Online = true;
                session.Security.AuthenticationState = WoWClientSession.AuthState.LoggingIn;

                authDatabase.Accounts.Update(session.Security.Account);
                authDatabase.SaveChanges();

                session.Network.Send(new AuthLoginProofResponse()
                {
                    Status = AccountStatus.Success,
                    Proof = session.Security.SRP6.ServerProof
                }, PacketHeaderType.OnlyOpCode);
            }
            else
                LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, session.Network.NewClientMessage(AuthServerOpCode.AUTH_LOGON_PROOF, PacketHeaderType.OnlyOpCode));
        }

        [PacketRoute(PacketScope.ClientToAuth, AuthServerOpCode.AUTH_RECONNECT_CHALLENGE)]
        public void ReconnectChallengeRequest(WoWClientSession session, AuthLogonChallengeRequest authLogonChallenge)
        {
            _logger.Debug("AUTH_RECONNECT_CHALLENGE from {Address}", session.Network.ClientSocket.IPEndPoint.Address.ToString());
            using var authDatabase = _classFactory.Resolve<AuthDatabase>();

            var account = authDatabase.Accounts.FirstOrDefault(x => x.Username == authLogonChallenge.Identity || x.RegMail == authLogonChallenge.Identity);
            var packet = session.Network.NewClientMessage(AuthServerOpCode.AUTH_LOGON_CHALLENGE, PacketHeaderType.OnlyOpCode);

            if (account == null)
            {
                _logger.Debug("Failed login attempt for {Identity} from {Address}. Account not found.", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint.Address);
                LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, packet);
                return;
            }

            var ipString = session.Network.ClientSocket.IPEndPoint.Address.ToString();
            account.LastAttemptIp = ipString;
            account.LastIp = ipString;
            session.Security.AuthenticationState = WoWClientSession.AuthState.AwaitingCredentials;
            session.Security.ReconnectProof = _randomUtilities.RandomBytes(16);

            authDatabase.Accounts.Update(account);
            authDatabase.SaveChanges();

            session.Network.Send(new AuthReconnectedResponse()
            {
                Status = AuthStatus.WOW_SUCCESS,
                ReconnectProof = session.Security.ReconnectProof
            },
            new Models.Networking.PacketId(AuthServerOpCode.AUTH_RECONNECT_CHALLENGE, PacketScope.AuthToClient), PacketHeaderType.OnlyOpCode);
        }

        [PacketRoute(PacketScope.ClientToAuth, AuthServerOpCode.AUTH_RECONNECT_PROOF)]
        public void ReconnectProof(WoWClientSession session, AuthReconnectedProof proof)
        {
            _logger.Debug("AUTH_RECONNECT_PROOF from {Address}", session.Network.ClientSocket.IPEndPoint.Address.ToString());
            if (session.Security.Account == null)
            {
                session.Network.ClientSocket.Disconnect();
                return;
            }

            if (session.Security.Account.SessionKeyAuth == null)
            {
                session.Network.ClientSocket.Disconnect();
                return;
            }

            var serverProof = HashUtil.ComputeHash(
                Encoding.ASCII.GetBytes(session.Security.Account.Username),
                proof.ReconnectProof,
                session.Security.ReconnectProof,
                session.Security.SRP6.SessionKey.ToProperByteArray());

            if (serverProof.SequenceEqual(proof.ClientProof))
            {
                using var authDatabase = _classFactory.Resolve<AuthDatabase>();
                session.Security.Account = authDatabase.Accounts.FirstOrDefault(x => x.Id == session.Security.Account.Id);

                if (session.Security.Account != null)
                {
                    session.Security.Account.LastLogin = DateTime.UtcNow;
                    session.Security.Account.Online = true;
                    authDatabase.Accounts.Update(session.Security.Account);
                    authDatabase.SaveChanges();
                }

                session.Security.AuthenticationState = WoWClientSession.AuthState.LoggingIn;
                session.Network.Send(new AuthReconnectProofResponse()
                {
                    Status = AuthStatus.WOW_SUCCESS
                }, new Models.Networking.PacketId(AuthServerOpCode.AUTH_RECONNECT_PROOF, PacketScope.AuthToClient), PacketHeaderType.OnlyOpCode);
            }
            else
            {
                LoginFailed(session, AuthStatus.WOW_FAIL_DISCONNECTED, session.Network.NewClientMessage(AuthServerOpCode.AUTH_RECONNECT_PROOF, PacketHeaderType.OnlyOpCode));
                session.Network.ClientSocket.Disconnect();
            }
        }

        private void LoginFailed(WoWClientSession session, AuthStatus status, WoWClientPacketOut packet)
        {
            if (!_loginTracker.TryGetValue(session.Network.ClientSocket.IPEndPoint.Address.ToString(), out var tracker))
            {
                tracker = new LoginTracker();
                _loginTracker[session.Network.ClientSocket.IPEndPoint.Address.ToString()] = tracker;
            }

            tracker.Attempts++;
            tracker.LastAttempt = DateTime.UtcNow;

            if (_configuration.GetDefaultValue("MaxLoginAttempts", 5) <= tracker.Attempts)
            {
                _logger.Debug("Too many failed login attempts from {Address}. Disconnecting.", session.Network.ClientSocket.IPEndPoint.Address);
                session.Network.ClientSocket.Disconnect();
                return;
            }

            packet.WriteObject(new AuthResponse()
            {
                Status = status
            });

            session.Security.AuthenticationState = WoWClientSession.AuthState.LoggedOut;
            session.Network.ClientSocket.EnqueueWrite(packet);
        }
    }
}