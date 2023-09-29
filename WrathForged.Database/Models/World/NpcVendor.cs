// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

/// <summary>
/// Npc System
/// </summary>
public partial class NpcVendor
{
    public uint Entry { get; set; }

    public short Slot { get; set; }

    public int Item { get; set; }

    public byte Maxcount { get; set; }

    public uint Incrtime { get; set; }

    public uint ExtendedCost { get; set; }

    public int? VerifiedBuild { get; set; }
}
