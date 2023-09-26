// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.ComponentModel.DataAnnotations.Schema;
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CharStartOutfit.dbc")]
public partial class Charstartoutfit : IDBCRecord
{
    private DBCOutfit[]? _dbcOutfits;

    public struct DBCOutfit
    {
        public int ItemId;
        public int DisplayItemId;
        public int InventoryType;
    }

    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? RaceId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? ClassId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.BYTE)]
    public byte SexId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.BYTE)]
    public byte OutfitId { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int ItemId1 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int ItemId2 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int ItemId3 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int ItemId4 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int ItemId5 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int ItemId6 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int ItemId7 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int ItemId8 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int ItemId9 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int ItemId10 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32)]
    public int ItemId11 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32)]
    public int ItemId12 { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32)]
    public int ItemId13 { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public int ItemId14 { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.INT32)]
    public int ItemId15 { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.INT32)]
    public int ItemId16 { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32)]
    public int ItemId17 { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int ItemId18 { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.INT32)]
    public int ItemId19 { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.INT32)]
    public int ItemId20 { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.INT32)]
    public int ItemId21 { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.INT32)]
    public int ItemId22 { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.INT32)]
    public int ItemId23 { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.INT32)]
    public int ItemId24 { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.INT32)]
    public int DisplayItemId1 { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.INT32)]
    public int DisplayItemId2 { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.INT32)]
    public int DisplayItemId3 { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.INT32)]
    public int DisplayItemId4 { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.INT32)]
    public int DisplayItemId5 { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.INT32)]
    public int DisplayItemId6 { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.INT32)]
    public int DisplayItemId7 { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.INT32)]
    public int DisplayItemId8 { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.INT32)]
    public int DisplayItemId9 { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.INT32)]
    public int DisplayItemId10 { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.INT32)]
    public int DisplayItemId11 { get; set; }

    [DBCPropertyBinding(40, DBCBindingType.INT32)]
    public int DisplayItemId12 { get; set; }

    [DBCPropertyBinding(41, DBCBindingType.INT32)]
    public int DisplayItemId13 { get; set; }

    [DBCPropertyBinding(42, DBCBindingType.INT32)]
    public int DisplayItemId14 { get; set; }

    [DBCPropertyBinding(43, DBCBindingType.INT32)]
    public int DisplayItemId15 { get; set; }

    [DBCPropertyBinding(44, DBCBindingType.INT32)]
    public int DisplayItemId16 { get; set; }

    [DBCPropertyBinding(45, DBCBindingType.INT32)]
    public int DisplayItemId17 { get; set; }

    [DBCPropertyBinding(46, DBCBindingType.INT32)]
    public int DisplayItemId18 { get; set; }

    [DBCPropertyBinding(47, DBCBindingType.INT32)]
    public int DisplayItemId19 { get; set; }

    [DBCPropertyBinding(48, DBCBindingType.INT32)]
    public int DisplayItemId20 { get; set; }

    [DBCPropertyBinding(49, DBCBindingType.INT32)]
    public int DisplayItemId21 { get; set; }

    [DBCPropertyBinding(50, DBCBindingType.INT32)]
    public int DisplayItemId22 { get; set; }

    [DBCPropertyBinding(51, DBCBindingType.INT32)]
    public int DisplayItemId23 { get; set; }

    [DBCPropertyBinding(52, DBCBindingType.INT32)]
    public int DisplayItemId24 { get; set; }

    [DBCPropertyBinding(53, DBCBindingType.INT32)]
    public int InventoryType1 { get; set; }

    [DBCPropertyBinding(54, DBCBindingType.INT32)]
    public int InventoryType2 { get; set; }

    [DBCPropertyBinding(55, DBCBindingType.INT32)]
    public int InventoryType3 { get; set; }

    [DBCPropertyBinding(56, DBCBindingType.INT32)]
    public int InventoryType4 { get; set; }

    [DBCPropertyBinding(57, DBCBindingType.INT32)]
    public int InventoryType5 { get; set; }

    [DBCPropertyBinding(58, DBCBindingType.INT32)]
    public int InventoryType6 { get; set; }

    [DBCPropertyBinding(59, DBCBindingType.INT32)]
    public int InventoryType7 { get; set; }

    [DBCPropertyBinding(60, DBCBindingType.INT32)]
    public int InventoryType8 { get; set; }

    [DBCPropertyBinding(61, DBCBindingType.INT32)]
    public int InventoryType9 { get; set; }

    [DBCPropertyBinding(62, DBCBindingType.INT32)]
    public int InventoryType10 { get; set; }

    [DBCPropertyBinding(63, DBCBindingType.INT32)]
    public int InventoryType11 { get; set; }

    [DBCPropertyBinding(64, DBCBindingType.INT32)]
    public int InventoryType12 { get; set; }

    [DBCPropertyBinding(65, DBCBindingType.INT32)]
    public int InventoryType13 { get; set; }

    [DBCPropertyBinding(66, DBCBindingType.INT32)]
    public int InventoryType14 { get; set; }

    [DBCPropertyBinding(67, DBCBindingType.INT32)]
    public int InventoryType15 { get; set; }

    [DBCPropertyBinding(68, DBCBindingType.INT32)]
    public int InventoryType16 { get; set; }

    [DBCPropertyBinding(69, DBCBindingType.INT32)]
    public int InventoryType17 { get; set; }

    [DBCPropertyBinding(70, DBCBindingType.INT32)]
    public int InventoryType18 { get; set; }

    [DBCPropertyBinding(71, DBCBindingType.INT32)]
    public int InventoryType19 { get; set; }

    [DBCPropertyBinding(72, DBCBindingType.INT32)]
    public int InventoryType20 { get; set; }

    [DBCPropertyBinding(73, DBCBindingType.INT32)]
    public int InventoryType21 { get; set; }

    [DBCPropertyBinding(74, DBCBindingType.INT32)]
    public int InventoryType22 { get; set; }

    [DBCPropertyBinding(75, DBCBindingType.INT32)]
    public int InventoryType23 { get; set; }

    [DBCPropertyBinding(76, DBCBindingType.INT32)]
    public int InventoryType24 { get; set; }

    public virtual Chrclass? Class { get; set; }

    public virtual Chrrace? Race { get; set; }

    /// <summary>
    ///     Readonly property to get all the DBCOutfits in an array.
    /// </summary>
    [NotMapped]
    public DBCOutfit[] DBCOutfits
    {
        get
        {
            _dbcOutfits ??= new DBCOutfit[]
                {
                    new DBCOutfit() { ItemId = ItemId1, DisplayItemId = DisplayItemId1, InventoryType = InventoryType1 },
                    new DBCOutfit() { ItemId = ItemId2, DisplayItemId = DisplayItemId2, InventoryType = InventoryType2 },
                    new DBCOutfit() { ItemId = ItemId3, DisplayItemId = DisplayItemId3, InventoryType = InventoryType3 },
                    new DBCOutfit() { ItemId = ItemId4, DisplayItemId = DisplayItemId4, InventoryType = InventoryType4 },
                    new DBCOutfit() { ItemId = ItemId5, DisplayItemId = DisplayItemId5, InventoryType = InventoryType5 },
                    new DBCOutfit() { ItemId = ItemId6, DisplayItemId = DisplayItemId6, InventoryType = InventoryType6 },
                    new DBCOutfit() { ItemId = ItemId7, DisplayItemId = DisplayItemId7, InventoryType = InventoryType7 },
                    new DBCOutfit() { ItemId = ItemId8, DisplayItemId = DisplayItemId8, InventoryType = InventoryType8 },
                    new DBCOutfit() { ItemId = ItemId9, DisplayItemId = DisplayItemId9, InventoryType = InventoryType9 },
                    new DBCOutfit() { ItemId = ItemId10, DisplayItemId = DisplayItemId10, InventoryType = InventoryType10 },
                    new DBCOutfit() { ItemId = ItemId11, DisplayItemId = DisplayItemId11, InventoryType = InventoryType11 },
                    new DBCOutfit() { ItemId = ItemId12, DisplayItemId = DisplayItemId12, InventoryType = InventoryType12 },
                    new DBCOutfit() { ItemId = ItemId13, DisplayItemId = DisplayItemId13, InventoryType = InventoryType13 },
                    new DBCOutfit() { ItemId = ItemId14, DisplayItemId = DisplayItemId14, InventoryType = InventoryType14 },
                    new DBCOutfit() { ItemId = ItemId15, DisplayItemId = DisplayItemId15, InventoryType = InventoryType15 },
                    new DBCOutfit() { ItemId = ItemId16, DisplayItemId = DisplayItemId16, InventoryType = InventoryType16 },
                    new DBCOutfit() { ItemId = ItemId17, DisplayItemId = DisplayItemId17, InventoryType = InventoryType17 },
                    new DBCOutfit() { ItemId = ItemId18, DisplayItemId = DisplayItemId18, InventoryType = InventoryType18 },
                    new DBCOutfit() { ItemId = ItemId19, DisplayItemId = DisplayItemId19, InventoryType = InventoryType19 },
                    new DBCOutfit() { ItemId = ItemId20, DisplayItemId = DisplayItemId20, InventoryType = InventoryType20 },
                    new DBCOutfit() { ItemId = ItemId21, DisplayItemId = DisplayItemId21, InventoryType = InventoryType21 },
                    new DBCOutfit() { ItemId = ItemId22, DisplayItemId = DisplayItemId22, InventoryType = InventoryType22 },
                    new DBCOutfit() { ItemId = ItemId23, DisplayItemId = DisplayItemId23, InventoryType = InventoryType23 },
                    new DBCOutfit() { ItemId = ItemId24, DisplayItemId = DisplayItemId24, InventoryType = InventoryType24 }
                };

            return _dbcOutfits;
        }
    }
}