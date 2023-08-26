using System;
using System.Collections.Generic;

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
