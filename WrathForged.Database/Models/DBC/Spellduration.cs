using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellduration
{
    public int Id { get; set; }

    public int Duration { get; set; }

    public int DurationPerLevel { get; set; }

    public int MaxDuration { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
