using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Questinfo
{
    public int Id { get; set; }

    public string? InfoNameLangEnUs { get; set; }

    public string? InfoNameLangEnGb { get; set; }

    public string? InfoNameLangKoKr { get; set; }

    public string? InfoNameLangFrFr { get; set; }

    public string? InfoNameLangDeDe { get; set; }

    public string? InfoNameLangEnCn { get; set; }

    public string? InfoNameLangZhCn { get; set; }

    public string? InfoNameLangEnTw { get; set; }

    public string? InfoNameLangZhTw { get; set; }

    public string? InfoNameLangEsEs { get; set; }

    public string? InfoNameLangEsMx { get; set; }

    public string? InfoNameLangRuRu { get; set; }

    public string? InfoNameLangPtPt { get; set; }

    public string? InfoNameLangPtBr { get; set; }

    public string? InfoNameLangItIt { get; set; }

    public string? InfoNameLangUnk { get; set; }

    public uint InfoNameLangMask { get; set; }
}
