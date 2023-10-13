// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SpellRange.dbc")]
public partial class Spellrange : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.FLOAT)]
    public float RangeMin1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
    public float RangeMin2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float RangeMax1 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float RangeMax2 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangEnUs { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangEnGb { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangKoKr { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangFrFr { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangDeDe { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangEnCn { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangZhCn { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangEnTw { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangZhTw { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangEsEs { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangEsMx { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangRuRu { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangPtPt { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangPtBr { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangItIt { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameLangUnk { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.UINT32)]
    public uint DisplayNameLangMask { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangEnUs { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangEnGb { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangKoKr { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangFrFr { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangDeDe { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangEnCn { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangZhCn { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangEnTw { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangZhTw { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangEsEs { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangEsMx { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangRuRu { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangPtPt { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangPtBr { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangItIt { get; set; }

    [DBCPropertyBinding(38, DBCBindingType.STRING, Nullable = true)]
    public string? DisplayNameShortLangUnk { get; set; }

    [DBCPropertyBinding(39, DBCBindingType.UINT32)]
    public uint DisplayNameShortLangMask { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
