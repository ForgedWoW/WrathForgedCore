using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Questsort
{
    public int Id { get; set; }

    public string? SortNameLangEnUs { get; set; }

    public string? SortNameLangEnGb { get; set; }

    public string? SortNameLangKoKr { get; set; }

    public string? SortNameLangFrFr { get; set; }

    public string? SortNameLangDeDe { get; set; }

    public string? SortNameLangEnCn { get; set; }

    public string? SortNameLangZhCn { get; set; }

    public string? SortNameLangEnTw { get; set; }

    public string? SortNameLangZhTw { get; set; }

    public string? SortNameLangEsEs { get; set; }

    public string? SortNameLangEsMx { get; set; }

    public string? SortNameLangRuRu { get; set; }

    public string? SortNameLangPtPt { get; set; }

    public string? SortNameLangPtBr { get; set; }

    public string? SortNameLangItIt { get; set; }

    public string? SortNameLangUnk { get; set; }

    public uint SortNameLangMask { get; set; }
}
