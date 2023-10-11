// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.Models.Auth;

namespace WrathForged.Common.RBAC;

public class AuthorizedRole(byte securityLevel, int realmId, Dictionary<uint, RbacPermission> permissions)
{
    public static AuthorizedRole None => new(0, 0, []);

    public byte SecurityLevel { get; set; } = securityLevel;
    public int RealmId { get; set; } = realmId;

    public Dictionary<uint, RbacPermission> Permissions { get; set; } = permissions;

    public bool HasPermission(uint permissionId) => Permissions.ContainsKey(permissionId);
}