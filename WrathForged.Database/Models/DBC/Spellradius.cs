// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SpellRadius.dbc")]
public partial class Spellradius : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.FLOAT)]
    public float Radius { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
    public float RadiusPerLevel { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float RadiusMax { get; set; }

    public virtual ICollection<Spell> SpellEffectRadiusIndex1Navigations { get; set; } = new List<Spell>();
    public virtual ICollection<Spell> SpellEffectRadiusIndex2Navigations { get; set; } = new List<Spell>();
    public virtual ICollection<Spell> SpellEffectRadiusIndex3Navigations { get; set; } = new List<Spell>();
}
