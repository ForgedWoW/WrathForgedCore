// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Stores pet levels stats.
/// </summary>
public partial class PetLevelstat
{
    public uint CreatureEntry { get; set; }

    public byte Level { get; set; }

    public ushort Hp { get; set; }

    public ushort Mana { get; set; }

    public uint Armor { get; set; }

    public ushort Str { get; set; }

    public ushort Agi { get; set; }

    public ushort Sta { get; set; }

    public ushort Inte { get; set; }

    public ushort Spi { get; set; }

    public ushort MinDmg { get; set; }

    public ushort MaxDmg { get; set; }
}
