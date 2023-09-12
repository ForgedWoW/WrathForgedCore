using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Talent
{
    public int Id { get; set; }

    public int? TabId { get; set; }

    public int TierId { get; set; }

    public int ColumnIndex { get; set; }

    public int? SpellRank1 { get; set; }

    public int? SpellRank2 { get; set; }

    public int? SpellRank3 { get; set; }

    public int? SpellRank4 { get; set; }

    public int? SpellRank5 { get; set; }

    public int? SpellRank6 { get; set; }

    public int? SpellRank7 { get; set; }

    public int? SpellRank8 { get; set; }

    public int? SpellRank9 { get; set; }

    public int? PrereqTalent1 { get; set; }

    public int? PrereqTalent2 { get; set; }

    public int? PrereqTalent3 { get; set; }

    public int PrereqRank1 { get; set; }

    public int PrereqRank2 { get; set; }

    public int PrereqRank3 { get; set; }

    public int Flags { get; set; }

    public int? RequiredSpellId { get; set; }

    public int CategoryMask1 { get; set; }

    public int CategoryMask2 { get; set; }

    public virtual Spell? RequiredSpell { get; set; }

    public virtual Spell? SpellRank1Navigation { get; set; }

    public virtual Spell? SpellRank2Navigation { get; set; }

    public virtual Spell? SpellRank3Navigation { get; set; }

    public virtual Spell? SpellRank4Navigation { get; set; }

    public virtual Spell? SpellRank5Navigation { get; set; }

    public virtual Spell? SpellRank6Navigation { get; set; }

    public virtual Spell? SpellRank7Navigation { get; set; }

    public virtual Spell? SpellRank8Navigation { get; set; }

    public virtual Spell? SpellRank9Navigation { get; set; }

    public virtual Talenttab? Tab { get; set; }
}
