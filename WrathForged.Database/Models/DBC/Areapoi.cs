// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("AreaPOI.dbc")]
public partial class Areapoi : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Importance { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Icon1 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Icon2 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Icon3 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Icon4 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int Icon5 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int Icon6 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int Icon7 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int Icon8 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int Icon9 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
    public int? FactionId { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.FLOAT)]
    public float X { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.FLOAT)]
    public float Y { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.FLOAT)]
    public float Z { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32)]
    public int ContinentId { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32, Nullable = true)]
    public int? AreaId { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING)]
    public string? NameLangEnUs { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING)]
    public string? NameLangEnGb { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING)]
    public string? NameLangKoKr { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.STRING)]
    public string? NameLangFrFr { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.STRING)]
    public string? NameLangDeDe { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? NameLangEnCn { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING)]
    public string? NameLangZhCn { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING)]
    public string? NameLangEnTw { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING)]
    public string? NameLangZhTw { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.STRING)]
    public string? NameLangEsEs { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING)]
    public string? NameLangEsMx { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING)]
    public string? NameLangRuRu { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.STRING)]
    public string? NameLangPtPt { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING)]
    public string? NameLangPtBr { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING)]
    public string? NameLangItIt { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.STRING)]
    public string? NameLangUnk { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.INT32)]
    public uint NameLangMask { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.STRING)]
    public string? DescriptionLangEnUs { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.STRING)]
    public string? DescriptionLangEnGb { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.STRING)]
    public string? DescriptionLangKoKr { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.STRING)]
    public string? DescriptionLangFrFr { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.STRING)]
    public string? DescriptionLangDeDe { get; set; }

    [DBCPropertyBinding(40, DBCBindingType.STRING)]
    public string? DescriptionLangEnCn { get; set; }

    [DBCPropertyBinding(41, DBCBindingType.STRING)]
    public string? DescriptionLangZhCn { get; set; }

    [DBCPropertyBinding(42, DBCBindingType.STRING)]
    public string? DescriptionLangEnTw { get; set; }

    [DBCPropertyBinding(43, DBCBindingType.STRING)]
    public string? DescriptionLangZhTw { get; set; }

    [DBCPropertyBinding(44, DBCBindingType.STRING)]
    public string? DescriptionLangEsEs { get; set; }

    [DBCPropertyBinding(45, DBCBindingType.STRING)]
    public string? DescriptionLangEsMx { get; set; }

    [DBCPropertyBinding(46, DBCBindingType.STRING)]
    public string? DescriptionLangRuRu { get; set; }

    [DBCPropertyBinding(47, DBCBindingType.STRING)]
    public string? DescriptionLangPtPt { get; set; }

    [DBCPropertyBinding(48, DBCBindingType.STRING)]
    public string? DescriptionLangPtBr { get; set; }

    [DBCPropertyBinding(49, DBCBindingType.STRING)]
    public string? DescriptionLangItIt { get; set; }

    [DBCPropertyBinding(50, DBCBindingType.STRING)]
    public string? DescriptionLangUnk { get; set; }

    [DBCPropertyBinding(51, DBCBindingType.INT32)]
    public uint DescriptionLangMask { get; set; }

    [DBCPropertyBinding(52, DBCBindingType.INT32)]
    public int WorldStateId { get; set; }

    [DBCPropertyBinding(53, DBCBindingType.INT32)]
    public int WorldMapLink { get; set; }

    public virtual Areatable? Area { get; set; }

    public virtual Faction? Faction { get; set; }
}