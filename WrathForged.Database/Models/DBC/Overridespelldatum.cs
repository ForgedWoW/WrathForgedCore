// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("OverrideSpellData.dbc")]
    public partial class Overridespelldatum : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? Spells1 { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? Spells2 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? Spells3 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? Spells4 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
        public int? Spells5 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
        public int? Spells6 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
        public int? Spells7 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
        public int? Spells8 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
        public int? Spells9 { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32, Nullable = true)]
        public int? Spells10 { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32)]
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
}
