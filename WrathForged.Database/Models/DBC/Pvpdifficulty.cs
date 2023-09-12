using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Pvpdifficulty
{
    public int Id { get; set; }

    public int? MapId { get; set; }

    public int RangeIndex { get; set; }

    public int MinLevel { get; set; }

    public int MaxLevel { get; set; }

    public int Difficulty { get; set; }

    public virtual Map? Map { get; set; }
}
