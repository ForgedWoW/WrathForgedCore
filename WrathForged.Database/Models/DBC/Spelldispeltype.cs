// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Spelldispeltype
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

    public int Mask { get; set; }

    public int ImmunityPossible { get; set; }

    public string? InternalName { get; set; }

    public virtual ICollection<Spellitemenchantment> SpellitemenchantmentEffect1Navigations { get; set; } = new List<Spellitemenchantment>();

    public virtual ICollection<Spellitemenchantment> SpellitemenchantmentEffect2Navigations { get; set; } = new List<Spellitemenchantment>();

    public virtual ICollection<Spellitemenchantment> SpellitemenchantmentEffect3Navigations { get; set; } = new List<Spellitemenchantment>();

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
