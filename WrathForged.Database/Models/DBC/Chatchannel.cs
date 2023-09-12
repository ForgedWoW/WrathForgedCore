using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Chatchannel
{
    public int Id { get; set; }

    public int Flags { get; set; }

    public int? FactionGroup { get; set; }

    public string? NameLangEnUs { get; set; }

    public string? NameLangEnGb { get; set; }

    public string? NameLangKoKr { get; set; }

    public string? NameLangFrFr { get; set; }

    public string? NameLangDeDe { get; set; }

    public string? NameLangEnCn { get; set; }

    public string? NameLangZhCn { get; set; }

    public string? NameLangEnTw { get; set; }

    public string? NameLangZhTw { get; set; }

    public string? NameLangEsEs { get; set; }

    public string? NameLangEsMx { get; set; }

    public string? NameLangRuRu { get; set; }

    public string? NameLangPtPt { get; set; }

    public string? NameLangPtBr { get; set; }

    public string? NameLangItIt { get; set; }

    public string? NameLangUnk { get; set; }

    public uint NameLangMask { get; set; }

    public string? ShortcutLangEnUs { get; set; }

    public string? ShortcutLangEnGb { get; set; }

    public string? ShortcutLangKoKr { get; set; }

    public string? ShortcutLangFrFr { get; set; }

    public string? ShortcutLangDeDe { get; set; }

    public string? ShortcutLangEnCn { get; set; }

    public string? ShortcutLangZhCn { get; set; }

    public string? ShortcutLangEnTw { get; set; }

    public string? ShortcutLangZhTw { get; set; }

    public string? ShortcutLangEsEs { get; set; }

    public string? ShortcutLangEsMx { get; set; }

    public string? ShortcutLangRuRu { get; set; }

    public string? ShortcutLangPtPt { get; set; }

    public string? ShortcutLangPtBr { get; set; }

    public string? ShortcutLangItIt { get; set; }

    public string? ShortcutLangUnk { get; set; }

    public uint ShortcutLangMask { get; set; }

    public virtual Factiongroup? FactionGroupNavigation { get; set; }
}
