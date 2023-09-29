// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Spelldifficulty
{
    public int Id { get; set; }

    public int? DifficultySpellId1 { get; set; }

    public int? DifficultySpellId2 { get; set; }

    public int? DifficultySpellId3 { get; set; }

    public int? DifficultySpellId4 { get; set; }

    public virtual Spell? DifficultySpellId1Navigation { get; set; }

    public virtual Spell? DifficultySpellId2Navigation { get; set; }

    public virtual Spell? DifficultySpellId3Navigation { get; set; }

    public virtual Spell? DifficultySpellId4Navigation { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
