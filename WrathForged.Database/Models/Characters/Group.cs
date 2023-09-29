// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Groups
/// </summary>
public partial class Group
{
    public uint Guid { get; set; }

    public uint LeaderGuid { get; set; }

    public byte LootMethod { get; set; }

    public uint LooterGuid { get; set; }

    public byte LootThreshold { get; set; }

    public ulong Icon1 { get; set; }

    public ulong Icon2 { get; set; }

    public ulong Icon3 { get; set; }

    public ulong Icon4 { get; set; }

    public ulong Icon5 { get; set; }

    public ulong Icon6 { get; set; }

    public ulong Icon7 { get; set; }

    public ulong Icon8 { get; set; }

    public byte GroupType { get; set; }

    public byte Difficulty { get; set; }

    public byte RaidDifficulty { get; set; }

    public uint MasterLooterGuid { get; set; }
}
