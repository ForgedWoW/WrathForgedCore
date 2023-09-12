using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Holidaydescription
{
    public int Id { get; set; }

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

    public virtual ICollection<Holiday> Holidays { get; set; } = new List<Holiday>();
}
