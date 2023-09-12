using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Gametip
{
    public int Id { get; set; }

    public string? TextLangEnUs { get; set; }

    public string? TextLangEnGb { get; set; }

    public string? TextLangKoKr { get; set; }

    public string? TextLangFrFr { get; set; }

    public string? TextLangDeDe { get; set; }

    public string? TextLangEnCn { get; set; }

    public string? TextLangZhCn { get; set; }

    public string? TextLangEnTw { get; set; }

    public string? TextLangZhTw { get; set; }

    public string? TextLangEsEs { get; set; }

    public string? TextLangEsMx { get; set; }

    public string? TextLangRuRu { get; set; }

    public string? TextLangPtPt { get; set; }

    public string? TextLangPtBr { get; set; }

    public string? TextLangItIt { get; set; }

    public string? TextLangUnk { get; set; }

    public uint TextLangMask { get; set; }
}
