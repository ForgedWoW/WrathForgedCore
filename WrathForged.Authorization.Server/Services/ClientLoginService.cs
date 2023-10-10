// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Authorization.Server.Validators;
using WrathForged.Common;
using WrathForged.Common.Caching;
using WrathForged.Common.Cryptography;
using WrathForged.Common.Networking;
using WrathForged.Database.Models.Auth;
using WrathForged.Models.Auth;
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Networking;
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Authorization.Server.Services
{
    public class ClientLoginService(IConfiguration configuration, BanValidator banValidator, ClassFactory classFactory, RandomUtilities randomUtilities,
                              ILogger logger, ForgeCache forgeCache) : IPacketService
    {
        private readonly IConfiguration _configuration = configuration;
        private readonly BanValidator _banValidator = banValidator;
        private readonly ClassFactory _classFactory = classFactory;
        private readonly RandomUtilities _randomUtilities = randomUtilities;
        private readonly ILogger _logger = logger;
        private readonly ForgeCache _forgeCache = forgeCache;
        private readonly Dictionary<string, LoginTracker> _loginTracker = new();

        [PacketRoute(PacketScope.ClientToAuth, AuthServerOpCode.AUTH_LOGON_CHALLENGE)]
        public void ChallengeRequest(WoWClientSession session, AuthLogonChallengeRequest authLogonChallenge)
        {
            _logger.Debug("Login challenge request from {Address}", session.Network.ClientSocket.IPEndPoint);
            using var authDatabase = _classFactory.Resolve<AuthDatabase>();

            var account = authDatabase.Accounts.FirstOrDefault(x => x.Username == authLogonChallenge.Identity || x.RegMail == authLogonChallenge.Identity || x.Email == authLogonChallenge.Identity);
            var packet = session.Network.NewClientMessage(AuthServerOpCode.AUTH_LOGON_CHALLENGE, PacketHeaderType.NullTerminatedOpCode);

            if (account == null)
            {
                _logger.Debug("Failed login attempt for {Identity} from {Address}. Account not found.", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint);
                LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, AuthServerOpCode.AUTH_LOGON_CHALLENGE);
                return;
            }

            var ipString = session.Network.ClientSocket.IPEndPoint.Address.ToString();
            account.LastAttemptIp = ipString;

            if (account.Locked && account.LastIp != ipString)
            {
                _logger.Debug("Failed login attempt for {Identity} from {Address}. Account locked to IpAddress {LockedIp}", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint, account.LastIp);
                LoginFailed(session, AuthStatus.WOW_FAIL_LOCKED_ENFORCED, AuthServerOpCode.AUTH_LOGON_CHALLENGE);
                account.FailedLogins++;
                authDatabase.Accounts.Update(account);
                authDatabase.SaveChanges();
                return;
            }

            var banState = _banValidator.GetBanState(account.Id, ipString);

            switch (banState)
            {
                case BanValidator.BanType.Banned:
                    _logger.Debug("Failed login attempt for {Identity} from {Address}. Account banned.", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint);
                    LoginFailed(session, AuthStatus.WOW_FAIL_BANNED, AuthServerOpCode.AUTH_LOGON_CHALLENGE);
                    account.FailedLogins++;
                    authDatabase.Accounts.Update(account);
                    authDatabase.SaveChanges();
                    return;

                case BanValidator.BanType.Suspended:
                    _logger.Debug("Failed login attempt for {Identity} from {Address}. Account suspended.", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint);
                    LoginFailed(session, AuthStatus.WOW_FAIL_SUSPENDED, AuthServerOpCode.AUTH_LOGON_CHALLENGE);
                    account.FailedLogins++;
                    authDatabase.Accounts.Update(account);
                    authDatabase.SaveChanges();
                    return;
            }

            if (authLogonChallenge.Major != ExpansionType.WrathOfTheLichKing ||
                authLogonChallenge.Minor != 3 ||
                authLogonChallenge.Revision != 5 ||
                authLogonChallenge.Build != 12340)
            {
                _logger.Debug("Failed login attempt for {Identity} from {Address}. Invalid Build {Major}.{Minor}.{Revision}.{Build}", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint, (byte)authLogonChallenge.Major, authLogonChallenge.Minor, authLogonChallenge.Revision, authLogonChallenge.Build);
                LoginFailed(session, AuthStatus.WOW_FAIL_VERSION_INVALID, AuthServerOpCode.AUTH_LOGON_CHALLENGE);
                return;
            }

            _logger.Debug("Login attempt for {Identity} from {Address}. Assigning session token.", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint);

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
                ServerEphemeral = session.Security.SRP6.B,
                Generator = SRP6.G,
                Modulus = SRP6.N,
                Salt = session.Security.Account.Salt
            });
            session.Network.ClientSocket.EnqueueWrite(packet);

            authDatabase.SaveChanges();
        }

        [PacketRoute(PacketScope.ClientToAuth, AuthServerOpCode.AUTH_LOGON_PROOF)]
        public void LogonProof(WoWClientSession session, AuthLoginProof proof)
        {
            _logger.Debug("Logon proof request from {Address}", session.Network.ClientSocket.IPEndPoint);

            var sessionKey = session.Security.SRP6.VerifyChallengeResponse(proof.A, proof.ClientM);

            if (sessionKey != null)
            {
                _logger.Debug("Account {Username} with id {Id} successfully logged in from {Address}.", session.Security.Account?.Username, session.Security.Account?.Id, session.Network.ClientSocket.IPEndPoint);

                session.Security.SessionKey = sessionKey; // also sets the session key on the account.
                using var authDatabase = _classFactory.Resolve<AuthDatabase>();

                if (session.Security.Account == null)
                {
                    LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, AuthServerOpCode.AUTH_LOGON_CHALLENGE);
                    return;
                }

                session.Security.Account = authDatabase.Accounts.Find(session.Security.Account.Id);

                if (session.Security.Account == null)
                {
                    LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, AuthServerOpCode.AUTH_LOGON_CHALLENGE);
                    return;
                }

                session.Security.Account.LastIp = session.Network.ClientSocket.IPEndPoint.Address.ToString();
                session.Security.Account.LastLogin = DateTime.UtcNow;
                session.Security.Account.SessionKeyAuth = session.Security.SessionKey;
                session.Security.Account.Online = true;
                session.Security.AuthenticationState = WoWClientSession.AuthState.LoggedIn;

                authDatabase.Accounts.Update(session.Security.Account);
                authDatabase.SaveChanges();
                var serverProof = SRP6.GetSessionVerifier(proof.A, proof.ClientM, sessionKey);

                session.Network.Send(new AuthLoginProofResponse()
                {
                    Status = AccountStatus.Success,
                    Proof = serverProof,
                    AccountFlags = session.Security.DefaultRole.SecurityLevel >= _configuration.GetDefaultValue("Security:AccountWideGMLevel", 4) ? 0x01 : 0, // 0x01 = GM
                }, PacketHeaderType.OnlyOpCode, new PacketId(AuthServerOpCode.AUTH_LOGON_PROOF, PacketScope.AuthToClient));
            }
            else
            {
                _logger.Debug("Account {Username} with id {Id} failed login from {Address}. Invalid password.", session.Security.Account?.Username, session.Security.Account?.Id, session.Network.ClientSocket.IPEndPoint);
                LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, AuthServerOpCode.AUTH_LOGON_PROOF);
            }
        }

        [PacketRoute(PacketScope.ClientToAuth, AuthServerOpCode.AUTH_RECONNECT_CHALLENGE)]
        public void ReconnectChallengeRequest(WoWClientSession session, AuthLogonChallengeRequest authLogonChallenge)
        {
            _logger.Debug("AUTH_RECONNECT_CHALLENGE from {Address}", session.Network.ClientSocket.IPEndPoint);
            using var authDatabase = _classFactory.Resolve<AuthDatabase>();

            var account = authDatabase.Accounts.FirstOrDefault(x => x.Username == authLogonChallenge.Identity || x.RegMail == authLogonChallenge.Identity);
            var packet = session.Network.NewClientMessage(AuthServerOpCode.AUTH_LOGON_CHALLENGE, PacketHeaderType.OnlyOpCode);

            if (account == null)
            {
                _logger.Debug("Failed login attempt for {Identity} from {Address}. Account not found.", authLogonChallenge.Identity, session.Network.ClientSocket.IPEndPoint);
                LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, AuthServerOpCode.AUTH_LOGON_CHALLENGE);
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
            _logger.Debug("AUTH_RECONNECT_PROOF from {Address}", session.Network.ClientSocket.IPEndPoint);
            if (session.Security.Account == null)
            {
                LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, AuthServerOpCode.AUTH_RECONNECT_PROOF);
                return;
            }

            if (session.Security.Account.SessionKeyAuth == null)
            {
                LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, AuthServerOpCode.AUTH_RECONNECT_PROOF);
                return;
            }

            var serverProof = HashUtil.ComputeHash(
                Encoding.ASCII.GetBytes(session.Security.Account.Username),
                proof.ReconnectProof,
                session.Security.ReconnectProof,
                session.Security.SessionKey);

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

                session.Security.AuthenticationState = WoWClientSession.AuthState.LoggedIn;
                session.Network.Send(new AuthReconnectProofResponse()
                {
                    Status = AuthStatus.WOW_SUCCESS
                }, new Models.Networking.PacketId(AuthServerOpCode.AUTH_RECONNECT_PROOF, PacketScope.AuthToClient), PacketHeaderType.OnlyOpCode);
            }
            else
            {
                LoginFailed(session, AuthStatus.WOW_FAIL_UNKNOWN_ACCOUNT, AuthServerOpCode.AUTH_RECONNECT_PROOF);
            }
        }

        private void LoginFailed(WoWClientSession session, AuthStatus status, AuthServerOpCode authServerOpCode)
        {
            var ipAddress = session.Network.ClientSocket.IPEndPoint.Address.ToString();
            if (!_loginTracker.TryGetValue(ipAddress, out var tracker))
            {
                tracker = new LoginTracker();
                _loginTracker[ipAddress] = tracker;
            }

            if (tracker.LastAttempt.AddMinutes(_configuration.GetDefaultValue("Security:MaxLoginAttempts_ResetTime_Minutes", 5)) < DateTime.UtcNow)
                tracker.Attempts = 0;

            tracker.Attempts++;
            tracker.LastAttempt = DateTime.UtcNow;

            if (_configuration.GetDefaultValue("Security:MaxLoginAttempts", 10) <= tracker.Attempts)
            {
                var banTime = _configuration.GetDefaultValue("Security:MaxLoginAttempts_BanTime_Minutes", 5);
                _logger.Debug("Too many failed login attempts from {Address}. Banning for {BanTime}.", session.Network.ClientSocket.IPEndPoint, TimeSpan.FromMinutes(banTime).ToReadableString());
                session.Network.ClientSocket.Disconnect();
                tracker.Attempts = 0;
                using var authDatabase = _classFactory.Resolve<AuthDatabase>();
                var ipBan = authDatabase.IpBanneds.FirstOrDefault(x => x.Ip == ipAddress);

                ipBan ??= new IpBanned()
                {
                    Ip = ipAddress
                };

                var bannedTil = DateTime.UtcNow.AddMinutes(banTime).ToUnixTime();

                if (bannedTil < ipBan.Unbandate)
                    return; // Already banned for longer, just return.

                ipBan.Banreason = "Too many failed login attempts from IP";
                ipBan.Bannedby = "Auth Server";
                ipBan.Bandate = DateTime.UtcNow.ToUnixTime();
                ipBan.Unbandate = bannedTil;

                authDatabase.IpBanneds.Upsert(ipBan).On(i => i.Ip).Run();
                session.Network.ClientSocket.Disconnect();
                _forgeCache.UpdateKey(AuthCacheKeys.IP_BANS);
                return;
            }

            var errorPkt = session.Network.NewClientMessage(authServerOpCode, authServerOpCode == AuthServerOpCode.AUTH_LOGON_CHALLENGE ? PacketHeaderType.NullTerminatedOpCode : PacketHeaderType.OnlyOpCode);

            if (authServerOpCode == AuthServerOpCode.AUTH_LOGON_CHALLENGE)
                errorPkt.WriteObject(new AuthResponseError()
                {
                    Status = status
                });
            else
                errorPkt.WriteObject(new AuthProofResponseError()
                {
                    Status = status
                });

            session.Network.ClientSocket.EnqueueWrite(errorPkt);

            session.Security.AuthenticationState = WoWClientSession.AuthState.LoggedOut;
        }
    }
}