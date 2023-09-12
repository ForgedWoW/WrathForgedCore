using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Areapoi
{
    public int Id { get; set; }

    public int Importance { get; set; }

    public int Icon1 { get; set; }

    public int Icon2 { get; set; }

    public int Icon3 { get; set; }

    public int Icon4 { get; set; }

    public int Icon5 { get; set; }

    public int Icon6 { get; set; }

    public int Icon7 { get; set; }

    public int Icon8 { get; set; }

    public int Icon9 { get; set; }

    public int? FactionId { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

    public float Z { get; set; }

    public int ContinentId { get; set; }

    public int Flags { get; set; }

    public int? AreaId { get; set; }

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

    public string? DescriptionLangEnUs { get; set; }

    public string? DescriptionLangEnGb { get; set; }

    public string? DescriptionLangKoKr { get; set; }

    public string? DescriptionLangFrFr { get; set; }

    public string? DescriptionLangDeDe { get; set; }

    public string? DescriptionLangEnCn { get; set; }

    public string? DescriptionLangZhCn { get; set; }

    public string? DescriptionLangEnTw { get; set; }

    public string? DescriptionLangZhTw { get; set; }

    public string? DescriptionLangEsEs { get; set; }

    public string? DescriptionLangEsMx { get; set; }

    public string? DescriptionLangRuRu { get; set; }

    public string? DescriptionLangPtPt { get; set; }

    public string? DescriptionLangPtBr { get; set; }

    public string? DescriptionLangItIt { get; set; }

    public string? DescriptionLangUnk { get; set; }

    public uint DescriptionLangMask { get; set; }

    public int WorldStateId { get; set; }

    public int WorldMapLink { get; set; }

    public virtual Areatable? Area { get; set; }

    public virtual Faction? Faction { get; set; }
}
