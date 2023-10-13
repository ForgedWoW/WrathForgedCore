// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("MapDifficulty.dbc")]
public partial class Mapdifficulty : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? MapId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Difficulty { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangEnUs { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangEnGb { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangKoKr { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangFrFr { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangDeDe { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangEnCn { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangZhCn { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangEnTw { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangZhTw { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangEsEs { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangEsMx { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangRuRu { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangPtPt { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangPtBr { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangItIt { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING, Nullable = true)]
    public string? MessageLangUnk { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.UINT32)]
    public uint MessageLangMask { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.INT32)]
    public int RaidDuration { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32)]
    public int MaxPlayers { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.STRING, Nullable = true)]
    public string? Difficultystring { get; set; }

    // Virtual collections and references are not annotated with DBCPropertyBinding
    public virtual ICollection<Dungeonencounter> Dungeonencounters { get; set; } = new List<Dungeonencounter>();
    public virtual Map? Map { get; set; }
}
