// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

/// <summary>
/// Loot System
/// </summary>
public partial class MillingLootTemplate
{
    public uint Entry { get; set; }

    public uint Item { get; set; }

    public uint Reference { get; set; }

    public float Chance { get; set; }

    public bool QuestRequired { get; set; }

    public ushort LootMode { get; set; }

    public byte GroupId { get; set; }

    public byte MinCount { get; set; }

    public byte MaxCount { get; set; }

    public string? Comment { get; set; }
}
