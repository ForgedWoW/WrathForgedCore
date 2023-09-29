// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CharTitles.dbc")]
public partial class Chartitle : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int ConditionId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING)]
    public string? NameLangEnUs { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING)]
    public string? NameLangEnGb { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING)]
    public string? NameLangKoKr { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING)]
    public string? NameLangFrFr { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? NameLangDeDe { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? NameLangEnCn { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING)]
    public string? NameLangZhCn { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? NameLangEnTw { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING)]
    public string? NameLangZhTw { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? NameLangEsEs { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? NameLangEsMx { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? NameLangRuRu { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? NameLangPtPt { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? NameLangPtBr { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? NameLangItIt { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING)]
    public string? NameLangUnk { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.UINT32)]
    public uint NameLangMask { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING)]
    public string? Name1LangEnUs { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING)]
    public string? Name1LangEnGb { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.STRING)]
    public string? Name1LangKoKr { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.STRING)]
    public string? Name1LangFrFr { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? Name1LangDeDe { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING)]
    public string? Name1LangEnCn { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING)]
    public string? Name1LangZhCn { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING)]
    public string? Name1LangEnTw { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.STRING)]
    public string? Name1LangZhTw { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING)]
    public string? Name1LangEsEs { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING)]
    public string? Name1LangEsMx { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.STRING)]
    public string? Name1LangRuRu { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING)]
    public string? Name1LangPtPt { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING)]
    public string? Name1LangPtBr { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.STRING)]
    public string? Name1LangItIt { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.STRING)]
    public string? Name1LangUnk { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.UINT32)]
    public uint Name1LangMask { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.INT32)]
    public int MaskId { get; set; }
}