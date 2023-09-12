using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spelldescriptionvariable
{
    public int Id { get; set; }

    public string? Variables { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
