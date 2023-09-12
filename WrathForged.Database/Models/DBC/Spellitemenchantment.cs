using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellitemenchantment
{
    public int Id { get; set; }

    public int Charges { get; set; }

    public int? Effect1 { get; set; }

    public int? Effect2 { get; set; }

    public int? Effect3 { get; set; }

    public int EffectPointsMin1 { get; set; }

    public int EffectPointsMin2 { get; set; }

    public int EffectPointsMin3 { get; set; }

    public int EffectPointsMax1 { get; set; }

    public int EffectPointsMax2 { get; set; }

    public int EffectPointsMax3 { get; set; }

    public int EffectArg1 { get; set; }

    public int EffectArg2 { get; set; }

    public int EffectArg3 { get; set; }

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

    public int? ItemVisual { get; set; }

    public int Flags { get; set; }

    public int? SrcItemId { get; set; }

    public int? ConditionId { get; set; }

    public int? RequiredSkillId { get; set; }

    public int RequiredSkillRank { get; set; }

    public int MinLevel { get; set; }

    public virtual Spellitemenchantmentcondition? Condition { get; set; }

    public virtual Spelldispeltype? Effect1Navigation { get; set; }

    public virtual Spelldispeltype? Effect2Navigation { get; set; }

    public virtual Spelldispeltype? Effect3Navigation { get; set; }

    public virtual ICollection<Gemproperty> Gemproperties { get; set; } = new List<Gemproperty>();

    public virtual Itemvisual? ItemVisualNavigation { get; set; }

    public virtual ICollection<Itemrandomproperty> ItemrandompropertyEnchantment1Navigations { get; set; } = new List<Itemrandomproperty>();

    public virtual ICollection<Itemrandomproperty> ItemrandompropertyEnchantment2Navigations { get; set; } = new List<Itemrandomproperty>();

    public virtual ICollection<Itemrandomproperty> ItemrandompropertyEnchantment3Navigations { get; set; } = new List<Itemrandomproperty>();

    public virtual ICollection<Itemrandomproperty> ItemrandompropertyEnchantment4Navigations { get; set; } = new List<Itemrandomproperty>();

    public virtual ICollection<Itemrandomproperty> ItemrandompropertyEnchantment5Navigations { get; set; } = new List<Itemrandomproperty>();

    public virtual ICollection<Itemrandomsuffix> ItemrandomsuffixEnchantment1Navigations { get; set; } = new List<Itemrandomsuffix>();

    public virtual ICollection<Itemrandomsuffix> ItemrandomsuffixEnchantment2Navigations { get; set; } = new List<Itemrandomsuffix>();

    public virtual ICollection<Itemrandomsuffix> ItemrandomsuffixEnchantment3Navigations { get; set; } = new List<Itemrandomsuffix>();

    public virtual ICollection<Itemrandomsuffix> ItemrandomsuffixEnchantment4Navigations { get; set; } = new List<Itemrandomsuffix>();

    public virtual ICollection<Itemrandomsuffix> ItemrandomsuffixEnchantment5Navigations { get; set; } = new List<Itemrandomsuffix>();

    public virtual Skillline? RequiredSkill { get; set; }

    public virtual Item? SrcItem { get; set; }
}
