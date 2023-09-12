using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Objecteffectgroup
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Objecteffectpackageelem> Objecteffectpackageelems { get; set; } = new List<Objecteffectpackageelem>();

    public virtual ICollection<Objecteffect> Objecteffects { get; set; } = new List<Objecteffect>();
}
