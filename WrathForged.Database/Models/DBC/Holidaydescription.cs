// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("HolidayDescriptions.dbc")]
public partial class Holidaydescription : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING)]
    public string? DescriptionLangEnUs { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING)]
    public string? DescriptionLangEnGb { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING)]
    public string? DescriptionLangKoKr { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING)]
    public string? DescriptionLangFrFr { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING)]
    public string? DescriptionLangDeDe { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? DescriptionLangEnCn { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? DescriptionLangZhCn { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING)]
    public string? DescriptionLangEnTw { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? DescriptionLangZhTw { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING)]
    public string? DescriptionLangEsEs { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? DescriptionLangEsMx { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? DescriptionLangRuRu { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? DescriptionLangPtPt { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? DescriptionLangPtBr { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? DescriptionLangItIt { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? DescriptionLangUnk { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.UINT32)]
    public uint DescriptionLangMask { get; set; }

    public virtual ICollection<Holiday> Holidays { get; set; } = new List<Holiday>();
}
