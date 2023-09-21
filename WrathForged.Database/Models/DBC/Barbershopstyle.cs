// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("BarberShopStyle.dbc")]
public partial class Barbershopstyle : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Type { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING)]
    public string? DisplayNameLangEnUs { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING)]
    public string? DisplayNameLangEnGb { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING)]
    public string? DisplayNameLangKoKr { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING)]
    public string? DisplayNameLangFrFr { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? DisplayNameLangDeDe { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? DisplayNameLangEnCn { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING)]
    public string? DisplayNameLangZhCn { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? DisplayNameLangEnTw { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING)]
    public string? DisplayNameLangZhTw { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? DisplayNameLangEsEs { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? DisplayNameLangEsMx { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? DisplayNameLangRuRu { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? DisplayNameLangPtPt { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? DisplayNameLangPtBr { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? DisplayNameLangItIt { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING)]
    public string? DisplayNameLangUnk { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public uint DisplayNameLangMask { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING)]
    public string? DescriptionLangEnUs { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING)]
    public string? DescriptionLangEnGb { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.STRING)]
    public string? DescriptionLangKoKr { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.STRING)]
    public string? DescriptionLangFrFr { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? DescriptionLangDeDe { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING)]
    public string? DescriptionLangEnCn { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING)]
    public string? DescriptionLangZhCn { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING)]
    public string? DescriptionLangEnTw { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.STRING)]
    public string? DescriptionLangZhTw { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING)]
    public string? DescriptionLangEsEs { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING)]
    public string? DescriptionLangEsMx { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.STRING)]
    public string? DescriptionLangRuRu { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING)]
    public string? DescriptionLangPtPt { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING)]
    public string? DescriptionLangPtBr { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.STRING)]
    public string? DescriptionLangItIt { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.STRING)]
    public string? DescriptionLangUnk { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.INT32)]
    public uint DescriptionLangMask { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.FLOAT)]
    public float CostModifier { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.INT32)]
    public int Race { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.INT32)]
    public int Sex { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.INT32)]
    public int Data { get; set; }
}