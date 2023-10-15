// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Text;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common;
using WrathForged.Common.Cryptography;
using WrathForged.Common.External;
using WrathForged.Common.Networking;
using WrathForged.Common.Validators;
using WrathForged.Database.Models.Auth;
using WrathForged.Database.Models.World;
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Auth.Packets;
using WrathForged.Models.Realm.Enum;
using WrathForged.Realm.Server.RealmSession;
using WrathForged.Serialization.Models;

namespace WrathForged.Realm.Server.ClientServices;

public class ClientAuthService(IConfiguration configuration, ILogger logger, ClassFactory classFactory, RandomUtilities random,
                                BanValidator banValidator, IpStackGeoLocationService ipStackGeoLocationService, AddonService addonService,
                                AccountService accountService) : IPacketService
{
    private readonly IConfiguration _configuration = configuration;
    private readonly ILogger _logger = logger;
    private readonly ClassFactory _classFactory = classFactory;
    private readonly BanValidator _banValidator = banValidator;
    private readonly IpStackGeoLocationService _ipStackGeoLocationService = ipStackGeoLocationService;
    private readonly AddonService _addonService = addonService;
    private readonly AccountService _accountService = accountService;
    private readonly byte[] _authSeed = random.RandomBytes(4);
    private readonly List<RealmClientSession> _loginQueue = [];

    [PacketRoute(PacketScope.ClientToRealm, RealmServerOpCode.CMSG_AUTH_SESSION, false)]
    public void AuthSession(RealmClientSession session, RealmAuthSessionRequest realmAuthSessionRequest)
    {
        using var authDatabase = _classFactory.Locate<AuthDatabase>();

        var account = authDatabase.Accounts.Find(realmAuthSessionRequest.AccountName);

        if (account == null)
        {
            _logger.Warning("Unknown account {AccountName} from {Address}", realmAuthSessionRequest.AccountName, session.Network.ClientSocket.IPEndPoint);
            session.Network.Send(new RealmAuthResponse() { Code = ResponseCodes.AUTH_UNKNOWN_ACCOUNT });
            session.Network.ClientSocket.Disconnect();
            return;
        }

        session.Security.Account = account;
        session.Security.Account.LastAttemptIp = session.Network.ClientSocket.IPEndPoint.Address.ToString();

        _ = authDatabase.Update(session.Security.Account);
        _ = authDatabase.SaveChanges();

        var realmId = _configuration.GetDefaultValue("RealmId", 1);

        if (realmId != realmAuthSessionRequest.RealmId)
        {
            _logger.Warning("Realm ID mismatch. Expected {ExpectedRealmId}, got {RealmId} from {Address}", realmId, realmAuthSessionRequest.RealmId, session.Network.ClientSocket.IPEndPoint);
            session.Network.Send(new RealmAuthResponse() { Code = ResponseCodes.REALM_LIST_REALM_NOT_FOUND });
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
            _logger.Warning("Invalid digest from {Address}", session.Network.ClientSocket.IPEndPoint);
            session.Network.Send(new RealmAuthResponse() { Code = ResponseCodes.AUTH_FAILED });
            session.Network.ClientSocket.Disconnect();
            return;
        }

        var banState = _banValidator.GetBanState(session.Security.Account.Id, session.Network.ClientSocket.IPEndPoint.Address.ToString());

        if (banState != BanValidator.BanType.None)
        {
            _logger.Warning("Account {AccountName} is {BanState} from {Address}", session.Security.Account.Username, banState.ToString(), session.Network.ClientSocket.IPEndPoint);
            session.Network.Send(new RealmAuthResponse() { Code = ResponseCodes.AUTH_BANNED });
            session.Network.ClientSocket.Disconnect();
            return;
        }

        if (session.Security.Account.Locked && session.Security.Account.LastIp != session.Network.ClientSocket.IPEndPoint.Address.ToString())
        {
            _logger.Warning("Account {AccountName} is locked from {Address}", session.Security.Account.Username, session.Network.ClientSocket.IPEndPoint);
            session.Network.Send(new RealmAuthResponse() { Code = ResponseCodes.AUTH_BANNED });
            session.Network.ClientSocket.Disconnect();
            return;
        }

        if (!string.IsNullOrEmpty(session.Security.Account.LockCountry) && _configuration.GetDefaultValue("IpStack:Enabled", false))
        {
            var geoLocation = _ipStackGeoLocationService.GetServiceResponse(session.Network.ClientSocket.IPEndPoint.Address.ToString());

            if (geoLocation != null && geoLocation.country_code.Equals(session.Security.Account.LockCountry, StringComparison.InvariantCultureIgnoreCase))
            {
                _logger.Warning("Failed login attempt for {AccountName} from {Address}. Account locked to country {LockedCountry}", session.Security.Account.Username, session.Network.ClientSocket.IPEndPoint, session.Security.Account.LockCountry);
                session.Network.Send(new RealmAuthResponse() { Code = ResponseCodes.AUTH_BANNED });
                session.Network.ClientSocket.Disconnect();
                return;
            }
        }

        var realm = authDatabase.Realmlists.FirstOrDefault(r => r.Id == realmId);

        if (realm == null)
        {
            _logger.Warning("Unknown realm {RealmId} from {Address}", realmId, session.Network.ClientSocket.IPEndPoint);
            session.Network.Send(new RealmAuthResponse() { Code = ResponseCodes.REALM_LIST_REALM_NOT_FOUND });
            session.Network.ClientSocket.Disconnect();
            return;
        }

        if (realm.AllowedSecurityLevel > 0 && session.Security.IsAtLeastSecurityLevel(realm.AllowedSecurityLevel))
        {
            _logger.Warning("Account {AccountName} is not authorized to access realm {RealmName} from {Address}", session.Security.Account.Username, realm.Name, session.Network.ClientSocket.IPEndPoint);
            session.Network.Send(new RealmAuthResponse() { Code = ResponseCodes.AUTH_UNAVAILABLE });
            session.Network.ClientSocket.Disconnect();
            return;
        }

        var sessionLimit = _configuration.GetDefaultValue("RealmSettings:PlayerLimit", 1000);

        if (!session.Security.Account.Locked)
            session.Security.Account.LastIp = session.Network.ClientSocket.IPEndPoint.Address.ToString();

        session.Security.CurrentRealm = realm;
        session.Security.AuthenticationState = WoWClientSession.AuthState.LoggedIn;
        session.Security.Account.LastLogin = DateTime.UtcNow;
        session.Network.ClientSocket.OnDisconnect += ClientSocket_OnDisconnect;
        _ = authDatabase.Update(session.Security.Account);
        _ = authDatabase.SaveChanges();

        session.AddonInfo.SetClientAddons(realmAuthSessionRequest.AddonInfo ?? new ClientAddons());

        if (sessionLimit != 0 &&
            realm.Population >= sessionLimit &&
            !session.Security.HasPermission(2) &&
            !session.Security.IsAtLeastSecurityLevel(_configuration.GetDefaultValue("", 4)))
        {
            var queuePosition = _loginQueue.Count;

            lock (_loginQueue)
                _loginQueue.Add(session);

            _logger.Information("Account {AccountName} is in position {QueuePosition} in the login queue for realm {RealmName} from {Address}", session.Security.Account.Username, _loginQueue.Count, realm.Name, session.Network.ClientSocket.IPEndPoint);
            session.Network.Send(new RealmAuthResponse() { Code = ResponseCodes.AUTH_WAIT_QUEUE, QueuePosition = queuePosition });
            return;
        }

        InitializeSession(session);
    }

    private void ClientSocket_OnDisconnect(object? sender, ClientSocket e)
    {
        lock (_loginQueue)
        {
            if (e.ClientSession == null)
                return;

            _ = _loginQueue.Remove(e.ClientSession.As<RealmClientSession>());
            var dequeuedSession = _loginQueue.FirstOrDefault();

            if (dequeuedSession == null)
                return; // No one in queue

            _ = _loginQueue.Remove(dequeuedSession);
            InitializeSession(dequeuedSession);

            for (var i = 0; i < _loginQueue.Count; i++)
            {
                var session = _loginQueue[i];
                session.Network.Send(new RealmAuthResponse() { Code = ResponseCodes.AUTH_WAIT_QUEUE, QueuePosition = i });
            }
        }
    }

    private void InitializeSession(RealmClientSession session)
    {
        using var worldDatabase = _classFactory.Locate<WorldDatabase>();

        _accountService.LoadAccountData(session);
        _accountService.LoadTutorialData(session);

        session.Network.Send(new RealmAuthResponse() { Code = ResponseCodes.AUTH_OK });
        _addonService.SendAddonInfo(session);
        session.Network.Send(new ClientCacheVersion() { Version = worldDatabase.Versions.Select(v => v.CacheId != null ? (uint)v.CacheId : 0u).First() });
        _accountService.SendTutorialData(session);
    }
}
