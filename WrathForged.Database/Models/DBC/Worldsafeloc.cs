// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.DBC;

public partial class Worldsafeloc
{
    public int Id { get; set; }

    public int? Continent { get; set; }

    public float LocX { get; set; }

    public float LocY { get; set; }

    public float LocZ { get; set; }

    public string? AreaNameLangEnUs { get; set; }

    public string? AreaNameLangEnGb { get; set; }

    public string? AreaNameLangKoKr { get; set; }

    public string? AreaNameLangFrFr { get; set; }

    public string? AreaNameLangDeDe { get; set; }

    public string? AreaNameLangEnCn { get; set; }

    public string? AreaNameLangZhCn { get; set; }

    public string? AreaNameLangEnTw { get; set; }

    public string? AreaNameLangZhTw { get; set; }

    public string? AreaNameLangEsEs { get; set; }

    public string? AreaNameLangEsMx { get; set; }

    public string? AreaNameLangRuRu { get; set; }

    public string? AreaNameLangPtPt { get; set; }

    public string? AreaNameLangPtBr { get; set; }

    public string? AreaNameLangItIt { get; set; }

    public string? AreaNameLangUnk { get; set; }

    public uint AreaNameLangMask { get; set; }

    public virtual Map? ContinentNavigation { get; set; }
}