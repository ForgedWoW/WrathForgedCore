// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ServerMessages.dbc")]
public partial class Servermessage : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangEnUs { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangEnGb { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangKoKr { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangFrFr { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangDeDe { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangEnCn { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangZhCn { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangEnTw { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangZhTw { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangEsEs { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangEsMx { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangRuRu { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangPtPt { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangPtBr { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangItIt { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING, Nullable = true)]
    public string? TextLangUnk { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.UINT32)]
    public uint TextLangMask { get; set; }
}
