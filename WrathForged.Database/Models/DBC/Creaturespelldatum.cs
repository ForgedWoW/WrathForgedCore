using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Creaturespelldatum
{
    public int Id { get; set; }

    public int? Spells1 { get; set; }

    public int? Spells2 { get; set; }

    public int? Spells3 { get; set; }

    public int? Spells4 { get; set; }

    public int Availability1 { get; set; }

    public int Availability2 { get; set; }

    public int Availability3 { get; set; }

    public int Availability4 { get; set; }

    public virtual Spell? Spells1Navigation { get; set; }

    public virtual Spell? Spells2Navigation { get; set; }

    public virtual Spell? Spells3Navigation { get; set; }

    public virtual Spell? Spells4Navigation { get; set; }
}
