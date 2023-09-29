// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Auth;

/// <summary>
/// Permission List
/// </summary>
public partial class RbacPermission
{
    /// <summary>
    /// Permission id
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// Permission name
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ICollection<RbacAccountPermission> RbacAccountPermissions { get; set; } = new List<RbacAccountPermission>();

    public virtual ICollection<RbacDefaultPermission> RbacDefaultPermissions { get; set; } = new List<RbacDefaultPermission>();

    public virtual ICollection<RbacPermission> Ids { get; set; } = new List<RbacPermission>();

    public virtual ICollection<RbacPermission> Linkeds { get; set; } = new List<RbacPermission>();
}
