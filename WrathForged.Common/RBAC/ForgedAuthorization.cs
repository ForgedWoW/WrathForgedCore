// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Serilog;
using WrathForged.Common.Threading;
using WrathForged.Database.Models.Auth;

namespace WrathForged.Common.RBAC;

public class ForgedAuthorization
{
    private readonly ILogger _logger;
    private readonly ClassFactory _classFactory;

    //                 RoleId           permissionId
    private readonly Dictionary<uint, Dictionary<uint, RbacPermission>> _permissions = [];
    //                 account id, realm id, permission
    private Dictionary<uint, Dictionary<int, RbacAccountPermission>> _accountPermissions;
    private Dictionary<uint, Dictionary<int, AccountAccess>> _accountAccess = [];

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public ForgedAuthorization(ILogger logger, ClassFactory classFactory, BackgroundWorkProcessor backgroundWorkProcessor)
    {
        _logger = logger;
        _classFactory = classFactory;
        backgroundWorkProcessor.Add(ReloadPermissions, TimeSpan.FromMinutes(10));
        ReloadPermissions();
    }
#pragma warning restore CS8618 // Im using ReloadPermissions() to set this value. the complier is dumb.

    public void ReloadPermissions()
    {
        var authDB = _classFactory.Locate<AuthDatabase>();

        _accountPermissions = authDB.RbacAccountPermissions
                                    .AsEnumerable()
                                    .GroupBy(x => x.AccountId)
                                    .ToDictionary(x => x.Key, x => x.ToDictionary(y => y.RealmId, y => y));

        _accountAccess = authDB.AccountAccesses.AsEnumerable().GroupBy(x => x.AccountId).ToDictionary(x => x.Key, x => x.ToDictionary(y => y.RealmId, y => y));

        _permissions.Clear();

        foreach (var defaultPerm in authDB.RbacDefaultPermissions.ToList())
        {
            if (!_permissions.TryGetValue(defaultPerm.SecId, out var perm))
            {
                perm = [];
                _permissions[defaultPerm.SecId] = perm;
            }

            var defPermission = authDB.RbacPermissions.FirstOrDefault(x => x.Id == defaultPerm.PermissionId);

            if (defPermission != null)
                foreach (var access in defPermission.Linkeds)
                {
                    perm[access.Id] = access;
                }
        }
    }

    public Dictionary<int, AuthorizedRole> GetAccountRolesByRealm(uint accountId)
    {
        Dictionary<int, AuthorizedRole> retVal = [];

        if (_accountAccess.TryGetValue(accountId, out var accessDict))
            foreach (var kvp in accessDict)
            {
                if (!retVal.TryGetValue(kvp.Key, out var role))
                {
                    role = new AuthorizedRole(kvp.Value.SecurityLevel, kvp.Key, []);
                    retVal[kvp.Key] = role;
                }

                if (_permissions.TryGetValue(kvp.Value.SecurityLevel, out var accessKvp))
                {
                    foreach (var kvp2 in accessKvp)
                        role.Permissions[kvp2.Key] = kvp2.Value;
                }
            }

        if (_accountPermissions.TryGetValue(accountId, out var permissionDict))
        {
            foreach (var kvp in permissionDict)
            {
                if (!retVal.TryGetValue(kvp.Key, out var role))
                {
                    role = new AuthorizedRole(0, kvp.Key, []);
                    retVal[kvp.Key] = role;
                }

                if (kvp.Value.Granted == false)
                    _ = role.Permissions.Remove(kvp.Value.PermissionId);
                else
                    role.Permissions[kvp.Value.PermissionId] = kvp.Value.Permission;
            }
        }

        return retVal;
    }
}