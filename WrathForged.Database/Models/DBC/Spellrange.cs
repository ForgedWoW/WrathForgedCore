// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellrange
{
    public int Id { get; set; }

    public float RangeMin1 { get; set; }

    public float RangeMin2 { get; set; }

    public float RangeMax1 { get; set; }

    public float RangeMax2 { get; set; }

    public int Flags { get; set; }

    public string? DisplayNameLangEnUs { get; set; }

    public string? DisplayNameLangEnGb { get; set; }

    public string? DisplayNameLangKoKr { get; set; }

    public string? DisplayNameLangFrFr { get; set; }

    public string? DisplayNameLangDeDe { get; set; }

    public string? DisplayNameLangEnCn { get; set; }

    public string? DisplayNameLangZhCn { get; set; }

    public string? DisplayNameLangEnTw { get; set; }

    public string? DisplayNameLangZhTw { get; set; }

    public string? DisplayNameLangEsEs { get; set; }

    public string? DisplayNameLangEsMx { get; set; }

    public string? DisplayNameLangRuRu { get; set; }

    public string? DisplayNameLangPtPt { get; set; }

    public string? DisplayNameLangPtBr { get; set; }

    public string? DisplayNameLangItIt { get; set; }

    public string? DisplayNameLangUnk { get; set; }

    public uint DisplayNameLangMask { get; set; }

    public string? DisplayNameShortLangEnUs { get; set; }

    public string? DisplayNameShortLangEnGb { get; set; }

    public string? DisplayNameShortLangKoKr { get; set; }

    public string? DisplayNameShortLangFrFr { get; set; }

    public string? DisplayNameShortLangDeDe { get; set; }

    public string? DisplayNameShortLangEnCn { get; set; }

    public string? DisplayNameShortLangZhCn { get; set; }

    public string? DisplayNameShortLangEnTw { get; set; }

    public string? DisplayNameShortLangZhTw { get; set; }

    public string? DisplayNameShortLangEsEs { get; set; }

    public string? DisplayNameShortLangEsMx { get; set; }

    public string? DisplayNameShortLangRuRu { get; set; }

    public string? DisplayNameShortLangPtPt { get; set; }

    public string? DisplayNameShortLangPtBr { get; set; }

    public string? DisplayNameShortLangItIt { get; set; }

    public string? DisplayNameShortLangUnk { get; set; }

    public uint DisplayNameShortLangMask { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
