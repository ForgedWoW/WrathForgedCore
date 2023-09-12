using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellcategory
{
    public int Id { get; set; }

    public int Flags { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
