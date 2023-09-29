// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class StartupString
{
    public int Id { get; set; }

    public string? Name { get; set; }

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
}
