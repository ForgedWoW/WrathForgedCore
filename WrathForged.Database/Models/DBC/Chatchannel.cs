// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ChatChannels.dbc")]
public partial class Chatchannel : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? FactionGroup { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING)]
    public string? NameLangEnUs { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING)]
    public string? NameLangEnGb { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING)]
    public string? NameLangKoKr { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING)]
    public string? NameLangFrFr { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING)]
    public string? NameLangDeDe { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING)]
    public string? NameLangEnCn { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING)]
    public string? NameLangZhCn { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING)]
    public string? NameLangEnTw { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING)]
    public string? NameLangZhTw { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING)]
    public string? NameLangEsEs { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING)]
    public string? NameLangEsMx { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING)]
    public string? NameLangRuRu { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING)]
    public string? NameLangPtPt { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING)]
    public string? NameLangPtBr { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING)]
    public string? NameLangItIt { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING)]
    public string? NameLangUnk { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.UINT32)]
    public uint NameLangMask { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING)]
    public string? ShortcutLangEnUs { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.STRING)]
    public string? ShortcutLangEnGb { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.STRING)]
    public string? ShortcutLangKoKr { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.STRING)]
    public string? ShortcutLangFrFr { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.STRING)]
    public string? ShortcutLangDeDe { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.STRING)]
    public string? ShortcutLangEnCn { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.STRING)]
    public string? ShortcutLangZhCn { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.STRING)]
    public string? ShortcutLangEnTw { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.STRING)]
    public string? ShortcutLangZhTw { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.STRING)]
    public string? ShortcutLangEsEs { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.STRING)]
    public string? ShortcutLangEsMx { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.STRING)]
    public string? ShortcutLangRuRu { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.STRING)]
    public string? ShortcutLangPtPt { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.STRING)]
    public string? ShortcutLangPtBr { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.STRING)]
    public string? ShortcutLangItIt { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.STRING)]
    public string? ShortcutLangUnk { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.UINT32)]
    public uint ShortcutLangMask { get; set; }

    public virtual Factiongroup? FactionGroupNavigation { get; set; }
}