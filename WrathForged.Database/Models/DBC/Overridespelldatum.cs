using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Overridespelldatum
{
    public int Id { get; set; }

    public int? Spells1 { get; set; }

    public int? Spells2 { get; set; }

    public int? Spells3 { get; set; }

    public int? Spells4 { get; set; }

    public int? Spells5 { get; set; }

    public int? Spells6 { get; set; }

    public int? Spells7 { get; set; }

    public int? Spells8 { get; set; }

    public int? Spells9 { get; set; }

    public int? Spells10 { get; set; }

    public int Flags { get; set; }

    public virtual Spell? Spells10Navigation { get; set; }

    public virtual Spell? Spells1Navigation { get; set; }

    public virtual Spell? Spells2Navigation { get; set; }

    public virtual Spell? Spells3Navigation { get; set; }

    public virtual Spell? Spells4Navigation { get; set; }

    public virtual Spell? Spells5Navigation { get; set; }

    public virtual Spell? Spells6Navigation { get; set; }

    public virtual Spell? Spells7Navigation { get; set; }

    public virtual Spell? Spells8Navigation { get; set; }

    public virtual Spell? Spells9Navigation { get; set; }
}
