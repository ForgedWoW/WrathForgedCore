﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Item System
/// </summary>
public partial class ItemInstance
{
    public uint Guid { get; set; }

    public uint ItemEntry { get; set; }

    public uint OwnerGuid { get; set; }

    public uint CreatorGuid { get; set; }

    public uint GiftCreatorGuid { get; set; }

    public uint Count { get; set; }

    public int Duration { get; set; }

    public string? Charges { get; set; }

    public uint Flags { get; set; }

    public string Enchantments { get; set; } = null!;

    public short RandomPropertyId { get; set; }

    public ushort Durability { get; set; }

    public uint PlayedTime { get; set; }

    public string? Text { get; set; }
}
