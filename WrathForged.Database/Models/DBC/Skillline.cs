using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Skillline
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public int? SkillCostsId { get; set; }

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

    public string? DescriptionLangEnUs { get; set; }

    public string? DescriptionLangEnGb { get; set; }

    public string? DescriptionLangKoKr { get; set; }

    public string? DescriptionLangFrFr { get; set; }

    public string? DescriptionLangDeDe { get; set; }

    public string? DescriptionLangEnCn { get; set; }

    public string? DescriptionLangZhCn { get; set; }

    public string? DescriptionLangEnTw { get; set; }

    public string? DescriptionLangZhTw { get; set; }

    public string? DescriptionLangEsEs { get; set; }

    public string? DescriptionLangEsMx { get; set; }

    public string? DescriptionLangRuRu { get; set; }

    public string? DescriptionLangPtPt { get; set; }

    public string? DescriptionLangPtBr { get; set; }

    public string? DescriptionLangItIt { get; set; }

    public string? DescriptionLangUnk { get; set; }

    public uint DescriptionLangMask { get; set; }

    public int? SpellIconId { get; set; }

    public string? AlternateVerbLangEnUs { get; set; }

    public string? AlternateVerbLangEnGb { get; set; }

    public string? AlternateVerbLangKoKr { get; set; }

    public string? AlternateVerbLangFrFr { get; set; }

    public string? AlternateVerbLangDeDe { get; set; }

    public string? AlternateVerbLangEnCn { get; set; }

    public string? AlternateVerbLangZhCn { get; set; }

    public string? AlternateVerbLangEnTw { get; set; }

    public string? AlternateVerbLangZhTw { get; set; }

    public string? AlternateVerbLangEsEs { get; set; }

    public string? AlternateVerbLangEsMx { get; set; }

    public string? AlternateVerbLangRuRu { get; set; }

    public string? AlternateVerbLangPtPt { get; set; }

    public string? AlternateVerbLangPtBr { get; set; }

    public string? AlternateVerbLangItIt { get; set; }

    public string? AlternateVerbLangUnk { get; set; }

    public uint AlternateVerbLangMask { get; set; }

    public int CanLink { get; set; }

    public virtual Skilllinecategory? Category { get; set; }

    public virtual ICollection<Creaturefamily> CreaturefamilySkillLine1Navigations { get; set; } = new List<Creaturefamily>();

    public virtual ICollection<Creaturefamily> CreaturefamilySkillLine2Navigations { get; set; } = new List<Creaturefamily>();

    public virtual ICollection<Itemset> Itemsets { get; set; } = new List<Itemset>();

    public virtual Skillcostsdatum? SkillCosts { get; set; }

    public virtual ICollection<Skilllineability> Skilllineabilities { get; set; } = new List<Skilllineability>();

    public virtual ICollection<Skillraceclassinfo> Skillraceclassinfos { get; set; } = new List<Skillraceclassinfo>();

    public virtual Spellicon? SpellIcon { get; set; }

    public virtual ICollection<Spellitemenchantment> Spellitemenchantments { get; set; } = new List<Spellitemenchantment>();
}
