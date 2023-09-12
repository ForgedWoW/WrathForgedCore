using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Gmticketcategory
{
    public int Id { get; set; }

    public string? CategoryLangEnUs { get; set; }

    public string? CategoryLangEnGb { get; set; }

    public string? CategoryLangKoKr { get; set; }

    public string? CategoryLangFrFr { get; set; }

    public string? CategoryLangDeDe { get; set; }

    public string? CategoryLangEnCn { get; set; }

    public string? CategoryLangZhCn { get; set; }

    public string? CategoryLangEnTw { get; set; }

    public string? CategoryLangZhTw { get; set; }

    public string? CategoryLangEsEs { get; set; }

    public string? CategoryLangEsMx { get; set; }

    public string? CategoryLangRuRu { get; set; }

    public string? CategoryLangPtPt { get; set; }

    public string? CategoryLangPtBr { get; set; }

    public string? CategoryLangItIt { get; set; }

    public string? CategoryLangUnk { get; set; }

    public uint CategoryLangMask { get; set; }
}
