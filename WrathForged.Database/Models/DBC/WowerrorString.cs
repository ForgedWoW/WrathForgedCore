using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class WowerrorString
{
    public int Id { get; set; }

    public string? ErrorName { get; set; }

    public string? ErrorStringEnUs { get; set; }

    public string? ErrorStringEnGb { get; set; }

    public string? ErrorStringKoKr { get; set; }

    public string? ErrorStringFrFr { get; set; }

    public string? ErrorStringDeDe { get; set; }

    public string? ErrorStringEnCn { get; set; }

    public string? ErrorStringZhCn { get; set; }

    public string? ErrorStringEnTw { get; set; }

    public string? ErrorStringZhTw { get; set; }

    public string? ErrorStringEsEs { get; set; }

    public string? ErrorStringEsMx { get; set; }

    public string? ErrorStringRuRu { get; set; }

    public string? ErrorStringPtPt { get; set; }

    public string? ErrorStringPtBr { get; set; }

    public string? ErrorStringItIt { get; set; }

    public string? ErrorStringUnk { get; set; }

    public uint ErrorStringMask { get; set; }
}
