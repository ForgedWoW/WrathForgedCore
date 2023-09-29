// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Auth;

/// <summary>
/// Realm System
/// </summary>
public partial class Realmlist
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string LocalAddress { get; set; } = null!;

    public string LocalSubnetMask { get; set; } = null!;

    public ushort Port { get; set; }

    public byte Icon { get; set; }

    public byte Flag { get; set; }

    public byte Timezone { get; set; }

    public byte AllowedSecurityLevel { get; set; }

    public float Population { get; set; }

    public uint Gamebuild { get; set; }

    public virtual ICollection<InstanceList> InstanceLists { get; set; } = new List<InstanceList>();
}
