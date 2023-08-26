using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class SpellBonusDatum
{
    public uint Entry { get; set; }

    public float DirectBonus { get; set; }

    public float DotBonus { get; set; }

    public float ApBonus { get; set; }

    public float ApDotBonus { get; set; }

    public string? Comments { get; set; }
}
