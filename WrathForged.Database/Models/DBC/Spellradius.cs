using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellradius
{
    public int Id { get; set; }

    public float Radius { get; set; }

    public float RadiusPerLevel { get; set; }

    public float RadiusMax { get; set; }

    public virtual ICollection<Spell> SpellEffectRadiusIndex1Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellEffectRadiusIndex2Navigations { get; set; } = new List<Spell>();

    public virtual ICollection<Spell> SpellEffectRadiusIndex3Navigations { get; set; } = new List<Spell>();
}
