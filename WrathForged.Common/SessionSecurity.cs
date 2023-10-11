// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using Serilog;
using WrathForged.Common.Cryptography;
using WrathForged.Common.Networking;
using WrathForged.Common.RBAC;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Common
{
    public class SessionSecurity(ILogger logger, ForgedAuthorization forgedAuthorization)
    {
        private readonly ILogger _logger = logger;
        private readonly ForgedAuthorization _forgedAuthorization = forgedAuthorization;
        private static readonly byte[] _defaultSessionKey = new byte[32];
        private int _currentRealm = -1;
        private Account? _account;

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
        public PacketEncryption? PacketEncryption { get; private set; }
        public byte[] ReconnectProof { get; set; } = [];

        public SRP6 SRP6 { get; set; } = SRP6.Default;

        public Account? Account
        {
            get => _account;
            set
            {
                if (value != null)
                {
                    Roles = _forgedAuthorization.GetAccountRolesByRealm(value.Id);
                    DefaultRole = GetRole();
                    SRP6 = new SRP6(value.Username, value.Salt, value.Verifier);
                }

                _account = value;
            }
        }

        public int CurrentRealm
        {
            get => _currentRealm;
            set
            {
                _currentRealm = value;
                CurrentRealmRole = GetRole(_currentRealm);
            }
        }

        public AuthorizedRole CurrentRealmRole { get; set; } = AuthorizedRole.None;
        public AuthorizedRole DefaultRole { get; set; } = AuthorizedRole.None;

        public AuthorizedRole GetRole(int realm = -1) => Roles.TryGetValue(realm, out var role) ? role : AuthorizedRole.None;

        public bool HasPermission(uint permissionId) => CurrentRealmRole.HasPermission(permissionId) || DefaultRole.HasPermission(permissionId);
    }
}