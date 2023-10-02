// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("Talent.dbc")]
    public partial class Talent : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? TabId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int TierId { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int ColumnIndex { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? SpellRank1 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
        public int? SpellRank2 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
        public int? SpellRank3 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
        public int? SpellRank4 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
        public int? SpellRank5 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
        public int? SpellRank6 { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32, Nullable = true)]
        public int? SpellRank7 { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
        public int? SpellRank8 { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32, Nullable = true)]
        public int? SpellRank9 { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32, Nullable = true)]
        public int? PrereqTalent1 { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.INT32, Nullable = true)]
        public int? PrereqTalent2 { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.INT32, Nullable = true)]
        public int? PrereqTalent3 { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.INT32)]
        public int PrereqRank1 { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.INT32)]
        public int PrereqRank2 { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.INT32)]
        public int PrereqRank3 { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.INT32)]
        public int Flags { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.INT32, Nullable = true)]
        public int? RequiredSpellId { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.INT32)]
        public int CategoryMask1 { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.INT32)]
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
}
