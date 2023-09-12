using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Lfgdungeon
{
    public int Id { get; set; }

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

    public int MinLevel { get; set; }

    public int MaxLevel { get; set; }

    public int TargetLevel { get; set; }

    public int TargetLevelMin { get; set; }

    public int TargetLevelMax { get; set; }

    public int? MapId { get; set; }

    public int Difficulty { get; set; }

    public int Flags { get; set; }

    public int TypeId { get; set; }

    public int? Faction { get; set; }

    public string? TextureFilename { get; set; }

    public int ExpansionLevel { get; set; }

    public int OrderIndex { get; set; }

    public int GroupId { get; set; }

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

    public virtual Faction? FactionNavigation { get; set; }

    public virtual ICollection<Lfgdungeonexpansion> Lfgdungeonexpansions { get; set; } = new List<Lfgdungeonexpansion>();

    public virtual Map? Map { get; set; }
}
