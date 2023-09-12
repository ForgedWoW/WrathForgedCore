using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellrunecost
{
    public int Id { get; set; }

    public int Blood { get; set; }

    public int Unholy { get; set; }

    public int Frost { get; set; }

    public int RunicPower { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
