// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

/// <summary>
/// Item Random Enchantment System
/// </summary>
public partial class ItemEnchantmentTemplate
{
    public uint Entry { get; set; }

    public uint Ench { get; set; }

    public float Chance { get; set; }
}
