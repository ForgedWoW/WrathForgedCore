using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Auth;

/// <summary>
/// Account-Permission relation
/// </summary>
public partial class RbacAccountPermission
{
    /// <summary>
    /// Account id
    /// </summary>
    public uint AccountId { get; set; }

    /// <summary>
    /// Permission id
    /// </summary>
    public uint PermissionId { get; set; }

    /// <summary>
    /// Granted = 1, Denied = 0
    /// </summary>
    public bool? Granted { get; set; }

    /// <summary>
    /// Realm Id, -1 means all
    /// </summary>
    public int RealmId { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual RbacPermission Permission { get; set; } = null!;
}
