using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Mapdifficulty
{
    public int Id { get; set; }

    public int? MapId { get; set; }

    public int Difficulty { get; set; }

    public string? MessageLangEnUs { get; set; }

    public string? MessageLangEnGb { get; set; }

    public string? MessageLangKoKr { get; set; }

    public string? MessageLangFrFr { get; set; }

    public string? MessageLangDeDe { get; set; }

    public string? MessageLangEnCn { get; set; }

    public string? MessageLangZhCn { get; set; }

    public string? MessageLangEnTw { get; set; }

    public string? MessageLangZhTw { get; set; }

    public string? MessageLangEsEs { get; set; }

    public string? MessageLangEsMx { get; set; }

    public string? MessageLangRuRu { get; set; }

    public string? MessageLangPtPt { get; set; }

    public string? MessageLangPtBr { get; set; }

    public string? MessageLangItIt { get; set; }

    public string? MessageLangUnk { get; set; }

    public uint MessageLangMask { get; set; }

    public int RaidDuration { get; set; }

    public int MaxPlayers { get; set; }

    public string? Difficultystring { get; set; }

    public virtual ICollection<Dungeonencounter> Dungeonencounters { get; set; } = new List<Dungeonencounter>();

    public virtual Map? Map { get; set; }
}
