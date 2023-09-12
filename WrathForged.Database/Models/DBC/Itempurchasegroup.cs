using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Itempurchasegroup
{
    public int Id { get; set; }

    public int? ItemId1 { get; set; }

    public int? ItemId2 { get; set; }

    public int? ItemId3 { get; set; }

    public int? ItemId4 { get; set; }

    public int? ItemId5 { get; set; }

    public int? ItemId6 { get; set; }

    public int? ItemId7 { get; set; }

    public int? ItemId8 { get; set; }

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

    public virtual Item? ItemId1Navigation { get; set; }

    public virtual Item? ItemId2Navigation { get; set; }

    public virtual Item? ItemId3Navigation { get; set; }

    public virtual Item? ItemId4Navigation { get; set; }

    public virtual Item? ItemId5Navigation { get; set; }

    public virtual Item? ItemId6Navigation { get; set; }

    public virtual Item? ItemId7Navigation { get; set; }

    public virtual Item? ItemId8Navigation { get; set; }

    public virtual ICollection<Itemextendedcost> Itemextendedcosts { get; set; } = new List<Itemextendedcost>();
}
