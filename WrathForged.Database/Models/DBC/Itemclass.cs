using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Itemclass
{
    public int Id { get; set; }

    public int ClassId { get; set; }

    public int SubclassMapId { get; set; }

    public int Flags { get; set; }

    public string? ClassNameLangEnUs { get; set; }

    public string? ClassNameLangEnGb { get; set; }

    public string? ClassNameLangKoKr { get; set; }

    public string? ClassNameLangFrFr { get; set; }

    public string? ClassNameLangDeDe { get; set; }

    public string? ClassNameLangEnCn { get; set; }

    public string? ClassNameLangZhCn { get; set; }

    public string? ClassNameLangEnTw { get; set; }

    public string? ClassNameLangZhTw { get; set; }

    public string? ClassNameLangEsEs { get; set; }

    public string? ClassNameLangEsMx { get; set; }

    public string? ClassNameLangRuRu { get; set; }

    public string? ClassNameLangPtPt { get; set; }

    public string? ClassNameLangPtBr { get; set; }

    public string? ClassNameLangItIt { get; set; }

    public string? ClassNameLangUnk { get; set; }

    public uint ClassNameLangMask { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
