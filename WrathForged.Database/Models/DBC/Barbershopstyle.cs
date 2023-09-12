using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Barbershopstyle
{
    public int Id { get; set; }

    public int Type { get; set; }

    public string? DisplayNameLangEnUs { get; set; }

    public string? DisplayNameLangEnGb { get; set; }

    public string? DisplayNameLangKoKr { get; set; }

    public string? DisplayNameLangFrFr { get; set; }

    public string? DisplayNameLangDeDe { get; set; }

    public string? DisplayNameLangEnCn { get; set; }

    public string? DisplayNameLangZhCn { get; set; }

    public string? DisplayNameLangEnTw { get; set; }

    public string? DisplayNameLangZhTw { get; set; }

    public string? DisplayNameLangEsEs { get; set; }

    public string? DisplayNameLangEsMx { get; set; }

    public string? DisplayNameLangRuRu { get; set; }

    public string? DisplayNameLangPtPt { get; set; }

    public string? DisplayNameLangPtBr { get; set; }

    public string? DisplayNameLangItIt { get; set; }

    public string? DisplayNameLangUnk { get; set; }

    public uint DisplayNameLangMask { get; set; }

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

    public float CostModifier { get; set; }

    public int Race { get; set; }

    public int Sex { get; set; }

    public int Data { get; set; }
}
