// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
