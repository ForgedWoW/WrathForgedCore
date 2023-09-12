using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Itemrandomsuffix
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

    public string? InternalName { get; set; }

    public int? Enchantment1 { get; set; }

    public int? Enchantment2 { get; set; }

    public int? Enchantment3 { get; set; }

    public int? Enchantment4 { get; set; }

    public int? Enchantment5 { get; set; }

    public int AllocationPct1 { get; set; }

    public int AllocationPct2 { get; set; }

    public int AllocationPct3 { get; set; }

    public int AllocationPct4 { get; set; }

    public int AllocationPct5 { get; set; }

    public virtual Spellitemenchantment? Enchantment1Navigation { get; set; }

    public virtual Spellitemenchantment? Enchantment2Navigation { get; set; }

    public virtual Spellitemenchantment? Enchantment3Navigation { get; set; }

    public virtual Spellitemenchantment? Enchantment4Navigation { get; set; }

    public virtual Spellitemenchantment? Enchantment5Navigation { get; set; }
}
