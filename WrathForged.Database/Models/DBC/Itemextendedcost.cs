// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("ItemCondExtCosts.dbc")]
    public partial class Itemextendedcost : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int HonorPoints { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int ArenaPoints { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int ArenaBracket { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int ItemId1 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int ItemId2 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32)]
        public int ItemId3 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int ItemId4 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32)]
        public int ItemId5 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32)]
        public int ItemCount1 { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int ItemCount2 { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32)]
        public int ItemCount3 { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32)]
        public int ItemCount4 { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32)]
        public int ItemCount5 { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.INT32)]
        public int RequiredArenaRating { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.INT32)]
        public int? ItemPurchaseGroup { get; set; }

        public virtual Itempurchasegroup? ItemPurchaseGroupNavigation { get; set; }
    }
}
