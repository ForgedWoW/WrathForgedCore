using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Lfgdungeonexpansion
{
    public int Id { get; set; }

    public int? LfgId { get; set; }

    public int ExpansionLevel { get; set; }

    public int RandomId { get; set; }

    public int HardLevelMin { get; set; }

    public int HardLevelMax { get; set; }

    public int TargetLevelMin { get; set; }

    public int TargetLevelMax { get; set; }

    public virtual Lfgdungeon? Lfg { get; set; }
}
