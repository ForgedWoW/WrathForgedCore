using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Battlemasterlist
{
    public int Id { get; set; }

    public int? MapId1 { get; set; }

    public int? MapId2 { get; set; }

    public int? MapId3 { get; set; }

    public int? MapId4 { get; set; }

    public int? MapId5 { get; set; }

    public int? MapId6 { get; set; }

    public int? MapId7 { get; set; }

    public int? MapId8 { get; set; }

    public int InstanceType { get; set; }

    public int GroupsAllowed { get; set; }

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

    public int MaxGroupSize { get; set; }

    public int HolidayWorldState { get; set; }

    public int Minlevel { get; set; }

    public int Maxlevel { get; set; }

    public virtual Map? MapId1Navigation { get; set; }

    public virtual Map? MapId2Navigation { get; set; }

    public virtual Map? MapId3Navigation { get; set; }

    public virtual Map? MapId4Navigation { get; set; }

    public virtual Map? MapId5Navigation { get; set; }

    public virtual Map? MapId6Navigation { get; set; }

    public virtual Map? MapId7Navigation { get; set; }

    public virtual Map? MapId8Navigation { get; set; }
}
