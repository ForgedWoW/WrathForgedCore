using System;
using System.Collections.Generic;

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
