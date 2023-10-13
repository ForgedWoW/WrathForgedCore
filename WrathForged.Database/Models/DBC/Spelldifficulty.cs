// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SpellDifficulty.dbc")]
public partial class Spelldifficulty : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? DifficultySpellId1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? DifficultySpellId2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? DifficultySpellId3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
    public int? DifficultySpellId4 { get; set; }

    public virtual Spell? DifficultySpellId1Navigation { get; set; }
    public virtual Spell? DifficultySpellId2Navigation { get; set; }
    public virtual Spell? DifficultySpellId3Navigation { get; set; }
    public virtual Spell? DifficultySpellId4Navigation { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
