// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("ItemVisuals.dbc")]
    public partial class Itemvisual : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int? Slot1 { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int? Slot2 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int? Slot3 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int? Slot4 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int? Slot5 { get; set; }

        public virtual ICollection<Itemdisplayinfo> Itemdisplayinfos { get; set; } = new List<Itemdisplayinfo>();
        public virtual Itemvisualeffect? Slot1Navigation { get; set; }
        public virtual Itemvisualeffect? Slot2Navigation { get; set; }
        public virtual Itemvisualeffect? Slot3Navigation { get; set; }
        public virtual Itemvisualeffect? Slot4Navigation { get; set; }
        public virtual Itemvisualeffect? Slot5Navigation { get; set; }
        public virtual ICollection<Spellitemenchantment> Spellitemenchantments { get; set; } = new List<Spellitemenchantment>();
    }
}
