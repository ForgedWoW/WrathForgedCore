// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using Serilog;
using WrathForged.Common.Cryptography;
using WrathForged.Common.Networking;
using WrathForged.Common.RBAC;
using WrathForged.Common.Threading;
using WrathForged.Database.Models.Auth;
using Z.EntityFramework.Plus;

namespace WrathForged.Common;

public class SessionSecurity(IWoWClientSession clientSession, ILogger logger, ForgedAuthorization forgedAuthorization, WoWClientServer woWClientServer,
                             ClassFactory classFactory, BackgroundWorkProcessor backgroundWorkProcessor) : IDisposable
{
    public static Realmlist NO_REALM { get; } = new();
    public static Account DEFAULT_ACCOUNT { get; } = new();
    private readonly IWoWClientSession _session = clientSession;
    private readonly ILogger _logger = logger;
    private readonly ForgedAuthorization _forgedAuthorization = forgedAuthorization;
    private readonly WoWClientServer _woWClientServer = woWClientServer;
    private readonly ClassFactory _classFactory = classFactory;
    private readonly BackgroundWorkProcessor _backgroundWorkProcessor = backgroundWorkProcessor;
    private static readonly byte[] _defaultSessionKey = new byte[32];
    private Realmlist _currentRealm = NO_REALM;
    private Account? _account;
    private bool _disposedValue;

    public Dictionary<int, AuthorizedRole> Roles { get; set; } = [];

    public byte[] SessionKey
    {
        get => _account != null ? _account.SessionKeyAuth ?? _defaultSessionKey : _defaultSessionKey;
        set
        {
            if (value == null)
            {
                PacketEncryption = null;
                return;
            }

            PacketEncryption = new PacketEncryption(value, _logger);

            if (Account != null)
                Account.SessionKeyAuth = value;
        }
    }

    public bool IsEncrypted => SessionKey != _defaultSessionKey;
    public WoWClientSession.AuthState AuthenticationState { get; set; } = WoWClientSession.AuthState.LoggedOut;

    /// <summary>
    ///     If the account is fully logged in.
    /// </summary>
    public bool IsAuthenticated => AuthenticationState == WoWClientSession.AuthState.LoggedIn;

    public PacketEncryption? PacketEncryption { get; private set; }
    public byte[] ReconnectProof { get; set; } = [];

    public SRP6 SRP6 { get; set; } = SRP6.Default;

    public static Account DefaultAccount => DEFAULT_ACCOUNT;

    /// <summary>
    ///     The account that is currently logged in. If the account not logged in, the <see cref="SessionSecurity.DEFAULT_ACCOUNT"/> is returned.
    /// </summary>
    public Account Account
    {
        get => _account ?? DEFAULT_ACCOUNT;
        set
        {
            _account = value;
            Roles = _forgedAuthorization.GetAccountRolesByRealm(value.Id);
            DefaultRole = GetRoleForRealm();
            SRP6 = new SRP6(value.Username, value.Salt, value.Verifier);
            _woWClientServer.AddClientSession(_session);
        }
    }

    /// <summary>
    ///     The realm that the account is currently connected to. If the account is not connected to a realm, <see cref="SessionSecurity.NO_REALM"/> is returned.
    /// </summary>
    public Realmlist CurrentRealm
    {
        get => _currentRealm;
        set
        {
            if (value != NO_REALM)
            {
                if (value.Id != _currentRealm.Id) // we may just be updating the realm. Don't update the population if we are.
                {
                    CurrentRealmRole = GetRoleForRealm((int)value.Id);
                    _backgroundWorkProcessor.Add(() =>
                    {
                        using var authDb = _classFactory.Locate<AuthDatabase>();
                        _ = authDb.Realmlists.Where(r => r.Id == value.Id).Update(r => new Realmlist { Population = r.Population + 1 });
                    });
                }
            }
            else
            {
                CurrentRealmRole = AuthorizedRole.None;

                if (_currentRealm != NO_REALM)
                    _backgroundWorkProcessor.Add(() =>
                    {
                        using var authDb = _classFactory.Locate<AuthDatabase>();
                        _ = authDb.Realmlists.Where(r => r.Id == _currentRealm.Id).Update(r => new Realmlist { Population = r.Population - 1 });
                    });
            }

            _currentRealm = value;
        }
    }

    /// <summary>
    ///     If the account has a realm in auth.account_access, this role will be the non-default of <see cref="AuthorizedRole.None"/>
    ///     <para>Use <see cref="HasPermission(uint)"/> to check if the account has a permission as it checks <see cref="CurrentRealmRole"/> and <see cref="DefaultRole"/></para>
    /// </summary>
    public AuthorizedRole CurrentRealmRole { get; set; } = AuthorizedRole.None;

    /// <summary>
    ///     Default role for the account. If the account has -1 as realm in auth.account_access, this role will be the non-default of <see cref="AuthorizedRole.None"/>
    ///     <para>Use <see cref="HasPermission(uint)"/> to check if the account has a permission as it checks <see cref="CurrentRealmRole"/> and <see cref="DefaultRole"/></para>
    /// </summary>
    public AuthorizedRole DefaultRole { get; set; } = AuthorizedRole.None;

    /// <summary>
    ///     Gets the role for a specific realm. If the account does not have a role for the realm, <see cref="AuthorizedRole.None"/> is returned.
    /// </summary>
    /// <param name="realm"></param>
    /// <returns></returns>
    public AuthorizedRole GetRoleForRealm(int realm = -1) => Roles.TryGetValue(realm, out var role) ? role : AuthorizedRole.None;

    /// <summary>
    ///    Checks if the account has a permission to perform the action on the current realm under its roles. This checks <see cref="CurrentRealmRole"/> and <see cref="DefaultRole"/>
    /// </summary>
    /// <param name="permissionId"></param>
    /// <returns></returns>
    public bool HasPermission(uint permissionId) => CurrentRealmRole.HasPermission(permissionId) || DefaultRole.HasPermission(permissionId);

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                CurrentRealm = NO_REALM;
            }

            _disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}