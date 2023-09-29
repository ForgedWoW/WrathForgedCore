// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Auth;

/// <summary>
/// Default permission to assign to different account security levels
/// </summary>
public partial class RbacDefaultPermission
{
    /// <summary>
    /// Security Level id
    /// </summary>
    public uint SecId { get; set; }

    /// <summary>
    /// permission id
    /// </summary>
    public uint PermissionId { get; set; }

    /// <summary>
    /// Realm Id, -1 means all
    /// </summary>
    public int RealmId { get; set; }

    public virtual RbacPermission Permission { get; set; } = null!;
}
