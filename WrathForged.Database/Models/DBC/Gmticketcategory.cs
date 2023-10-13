// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("GMTicketCategory.dbc")]
public partial class Gmticketcategory : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangEnUs { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangEnGb { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangKoKr { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangFrFr { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangDeDe { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangEnCn { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangZhCn { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangEnTw { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangZhTw { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangEsEs { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangEsMx { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangRuRu { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangPtPt { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangPtBr { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangItIt { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING, Nullable = true)]
    public string? CategoryLangUnk { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.UINT32)]
    public uint CategoryLangMask { get; set; }
}
