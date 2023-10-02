// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("WowError_Strings.dbc")]
public partial class WowerrorString
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorName { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringEnUs { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringEnGb { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringKoKr { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringFrFr { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringDeDe { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringEnCn { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringZhCn { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringEnTw { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringZhTw { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringEsEs { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringEsMx { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringRuRu { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringPtPt { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringPtBr { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringItIt { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.STRING, Nullable = true)]
    public string? ErrorStringUnk { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.UINT32)]
    public uint ErrorStringMask { get; set; }
}
