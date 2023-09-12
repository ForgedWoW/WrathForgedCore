using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellcasttime
{
    public int Id { get; set; }

    public int Base { get; set; }

    public int PerLevel { get; set; }

    public int Minimum { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
