// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("WorldSafeLocs.dbc")]
public partial class Worldsafeloc : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? Continent { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
    public float LocX { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float LocY { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float LocZ { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangEnUs { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangEnGb { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangKoKr { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangFrFr { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangDeDe { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangEnCn { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangZhCn { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangEnTw { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangZhTw { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangEsEs { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangEsMx { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangRuRu { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangPtPt { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangPtBr { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangItIt { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.STRING, Nullable = true)]
    public string? AreaNameLangUnk { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.UINT32)]
    public uint AreaNameLangMask { get; set; }

    public virtual Map? ContinentNavigation { get; set; }
}
