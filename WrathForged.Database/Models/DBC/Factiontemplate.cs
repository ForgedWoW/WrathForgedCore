// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("FactionTemplate.dbc")]
    public partial class Factiontemplate : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? Faction { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int Flags { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int FactionGroup { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int FriendGroup { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int EnemyGroup { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
        public int? Enemies1 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
        public int? Enemies2 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
        public int? Enemies3 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
        public int? Enemies4 { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32, Nullable = true)]
        public int? Friend1 { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
        public int? Friend2 { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32, Nullable = true)]
        public int? Friend3 { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32, Nullable = true)]
        public int? Friend4 { get; set; }

        public virtual ICollection<Chrrace> Chrraces { get; set; } = new List<Chrrace>();
        public virtual Faction? Enemies1Navigation { get; set; }
        public virtual Faction? Enemies2Navigation { get; set; }
        public virtual Faction? Enemies3Navigation { get; set; }
        public virtual Faction? Enemies4Navigation { get; set; }
        public virtual Faction? FactionNavigation { get; set; }
        public virtual Faction? Friend1Navigation { get; set; }
        public virtual Faction? Friend2Navigation { get; set; }
        public virtual Faction? Friend3Navigation { get; set; }
        public virtual Faction? Friend4Navigation { get; set; }
    }
}
