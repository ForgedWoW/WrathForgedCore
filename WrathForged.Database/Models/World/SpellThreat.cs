// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class SpellThreat
{
    public uint Entry { get; set; }

    public int? FlatMod { get; set; }

    /// <summary>
    /// threat multiplier for damage/healing
    /// </summary>
    public float PctMod { get; set; }

    /// <summary>
    /// additional threat bonus from attack power
    /// </summary>
    public float ApPctMod { get; set; }
}
