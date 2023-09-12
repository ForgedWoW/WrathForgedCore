using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Objecteffectmodifier
{
    public int Id { get; set; }

    public int InputType { get; set; }

    public int MapType { get; set; }

    public int OutputType { get; set; }

    public float Param1 { get; set; }

    public float Param2 { get; set; }

    public float Param3 { get; set; }

    public float Param4 { get; set; }

    public virtual ICollection<Objecteffect> Objecteffects { get; set; } = new List<Objecteffect>();
}
