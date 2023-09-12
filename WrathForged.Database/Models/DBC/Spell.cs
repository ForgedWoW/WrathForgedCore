using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spell
{
    public int Id { get; set; }

    public int? Category { get; set; }

    public int? DispelType { get; set; }

    public int? Mechanic { get; set; }

    public uint Attributes { get; set; }

    public uint AttributesEx { get; set; }

    public uint AttributesExB { get; set; }

    public uint AttributesExC { get; set; }

    public uint AttributesExD { get; set; }

    public uint AttributesExE { get; set; }

    public uint AttributesExF { get; set; }

    public uint AttributesExG { get; set; }

    public ulong ShapeshiftMask { get; set; }

    public ulong ShapeshiftExclude { get; set; }

    public uint Targets { get; set; }

    public uint TargetCreatureType { get; set; }

    public int? RequiresSpellFocus { get; set; }

    public uint FacingCasterFlags { get; set; }

    public uint CasterAuraState { get; set; }

    public uint TargetAuraState { get; set; }

    public uint ExcludeCasterAuraState { get; set; }

    public uint ExcludeTargetAuraState { get; set; }

    public uint CasterAuraSpell { get; set; }

    public uint TargetAuraSpell { get; set; }

    public uint ExcludeCasterAuraSpell { get; set; }

    public uint ExcludeTargetAuraSpell { get; set; }

    public int? CastingTimeIndex { get; set; }

    public uint RecoveryTime { get; set; }

    public uint CategoryRecoveryTime { get; set; }

    public uint InterruptFlags { get; set; }

    public uint AuraInterruptFlags { get; set; }

    public uint ChannelInterruptFlags { get; set; }

    public uint ProcTypeMask { get; set; }

    public uint ProcChance { get; set; }

    public uint ProcCharges { get; set; }

    public uint MaxLevel { get; set; }

    public uint BaseLevel { get; set; }

    public uint SpellLevel { get; set; }

    public int? DurationIndex { get; set; }

    public int PowerType { get; set; }

    public uint ManaCost { get; set; }

    public uint ManaCostPerLevel { get; set; }

    public uint ManaPerSecond { get; set; }

    public uint ManaPerSecondPerLevel { get; set; }

    public int? RangeIndex { get; set; }

    public float Speed { get; set; }

    public uint ModalNextSpell { get; set; }

    public uint CumulativeAura { get; set; }

    public uint Totem1 { get; set; }

    public uint Totem2 { get; set; }

    public int? Reagent1 { get; set; }

    public int? Reagent2 { get; set; }

    public int? Reagent3 { get; set; }

    public int? Reagent4 { get; set; }

    public int? Reagent5 { get; set; }

    public int? Reagent6 { get; set; }

    public int? Reagent7 { get; set; }

    public int? Reagent8 { get; set; }

    public int ReagentCount1 { get; set; }

    public int ReagentCount2 { get; set; }

    public int ReagentCount3 { get; set; }

    public int ReagentCount4 { get; set; }

    public int ReagentCount5 { get; set; }

    public int ReagentCount6 { get; set; }

    public int ReagentCount7 { get; set; }

    public int ReagentCount8 { get; set; }

    public int EquippedItemClass { get; set; }

    public int EquippedItemSubclass { get; set; }

    public int EquippedItemInvTypes { get; set; }

    public uint Effect1 { get; set; }

    public uint Effect2 { get; set; }

    public uint Effect3 { get; set; }

    public int EffectDieSides1 { get; set; }

    public int EffectDieSides2 { get; set; }

    public int EffectDieSides3 { get; set; }

    public float EffectRealPointsPerLevel1 { get; set; }

    public float EffectRealPointsPerLevel2 { get; set; }

    public float EffectRealPointsPerLevel3 { get; set; }

    public int EffectBasePoints1 { get; set; }

    public int EffectBasePoints2 { get; set; }

    public int EffectBasePoints3 { get; set; }

    public int? EffectMechanic1 { get; set; }

    public int? EffectMechanic2 { get; set; }

    public int? EffectMechanic3 { get; set; }

    public uint ImplicitTargetA1 { get; set; }

    public uint ImplicitTargetA2 { get; set; }

    public uint ImplicitTargetA3 { get; set; }

    public uint ImplicitTargetB1 { get; set; }

    public uint ImplicitTargetB2 { get; set; }

    public uint ImplicitTargetB3 { get; set; }

    public int? EffectRadiusIndex1 { get; set; }

    public int? EffectRadiusIndex2 { get; set; }

    public int? EffectRadiusIndex3 { get; set; }

    public uint EffectAura1 { get; set; }

    public uint EffectAura2 { get; set; }

    public uint EffectAura3 { get; set; }

    public uint EffectAuraPeriod1 { get; set; }

    public uint EffectAuraPeriod2 { get; set; }

    public uint EffectAuraPeriod3 { get; set; }

    public float EffectMultipleValue1 { get; set; }

    public float EffectMultipleValue2 { get; set; }

    public float EffectMultipleValue3 { get; set; }

    public uint EffectChainTargets1 { get; set; }

    public uint EffectChainTargets2 { get; set; }

    public uint EffectChainTargets3 { get; set; }

    public uint EffectItemType1 { get; set; }

    public uint EffectItemType2 { get; set; }

    public uint EffectItemType3 { get; set; }

    public int EffectMiscValue1 { get; set; }

    public int EffectMiscValue2 { get; set; }

    public int EffectMiscValue3 { get; set; }

    public int EffectMiscValueB1 { get; set; }

    public int EffectMiscValueB2 { get; set; }

    public int EffectMiscValueB3 { get; set; }

    public uint EffectTriggerSpell1 { get; set; }

    public uint EffectTriggerSpell2 { get; set; }

    public uint EffectTriggerSpell3 { get; set; }

    public float EffectPointsPerCombo1 { get; set; }

    public float EffectPointsPerCombo2 { get; set; }

    public float EffectPointsPerCombo3 { get; set; }

    public uint EffectSpellClassMaskA1 { get; set; }

    public uint EffectSpellClassMaskA2 { get; set; }

    public uint EffectSpellClassMaskA3 { get; set; }

    public uint EffectSpellClassMaskB1 { get; set; }

    public uint EffectSpellClassMaskB2 { get; set; }

    public uint EffectSpellClassMaskB3 { get; set; }

    public uint EffectSpellClassMaskC1 { get; set; }

    public uint EffectSpellClassMaskC2 { get; set; }

    public uint EffectSpellClassMaskC3 { get; set; }

    public int? SpellVisualId1 { get; set; }

    public int? SpellVisualId2 { get; set; }

    public int? SpellIconId { get; set; }

    public int? ActiveIconId { get; set; }

    public uint SpellPriority { get; set; }

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

    public string? NameSubtextLangEnUs { get; set; }

    public string? NameSubtextLangEnGb { get; set; }

    public string? NameSubtextLangKoKr { get; set; }

    public string? NameSubtextLangFrFr { get; set; }

    public string? NameSubtextLangDeDe { get; set; }

    public string? NameSubtextLangEnCn { get; set; }

    public string? NameSubtextLangZhCn { get; set; }

    public string? NameSubtextLangEnTw { get; set; }

    public string? NameSubtextLangZhTw { get; set; }

    public string? NameSubtextLangEsEs { get; set; }

    public string? NameSubtextLangEsMx { get; set; }

    public string? NameSubtextLangRuRu { get; set; }

    public string? NameSubtextLangPtPt { get; set; }

    public string? NameSubtextLangPtBr { get; set; }

    public string? NameSubtextLangItIt { get; set; }

    public string? NameSubtextLangUnk { get; set; }

    public uint NameSubtextLangMask { get; set; }

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

    public string? AuraDescriptionLangEnUs { get; set; }

    public string? AuraDescriptionLangEnGb { get; set; }

    public string? AuraDescriptionLangKoKr { get; set; }

    public string? AuraDescriptionLangFrFr { get; set; }

    public string? AuraDescriptionLangDeDe { get; set; }

    public string? AuraDescriptionLangEnCn { get; set; }

    public string? AuraDescriptionLangZhCn { get; set; }

    public string? AuraDescriptionLangEnTw { get; set; }

    public string? AuraDescriptionLangZhTw { get; set; }

    public string? AuraDescriptionLangEsEs { get; set; }

    public string? AuraDescriptionLangEsMx { get; set; }

    public string? AuraDescriptionLangRuRu { get; set; }

    public string? AuraDescriptionLangPtPt { get; set; }

    public string? AuraDescriptionLangPtBr { get; set; }

    public string? AuraDescriptionLangItIt { get; set; }

    public string? AuraDescriptionLangUnk { get; set; }

    public uint AuraDescriptionLangMask { get; set; }

    public uint ManaCostPct { get; set; }

    public uint StartRecoveryCategory { get; set; }

    public uint StartRecoveryTime { get; set; }

    public uint MaxTargetLevel { get; set; }

    public uint SpellClassSet { get; set; }

    public uint SpellClassMask1 { get; set; }

    public uint SpellClassMask2 { get; set; }

    public uint SpellClassMask3 { get; set; }

    public uint MaxTargets { get; set; }

    public uint DefenseType { get; set; }

    public uint PreventionType { get; set; }

    public uint StanceBarOrder { get; set; }

    public float EffectChainAmplitude1 { get; set; }

    public float EffectChainAmplitude2 { get; set; }

    public float EffectChainAmplitude3 { get; set; }

    public uint MinFactionId { get; set; }

    public uint MinReputation { get; set; }

    public uint RequiredAuraVision { get; set; }

    public int? RequiredTotemCategoryId1 { get; set; }

    public int? RequiredTotemCategoryId2 { get; set; }

    public int? RequiredAreasId { get; set; }

    public uint SchoolMask { get; set; }

    public int? RuneCostId { get; set; }

    public int? SpellMissileId { get; set; }

    public int? PowerDisplayId { get; set; }

    public float Field227 { get; set; }

    public float Field228 { get; set; }

    public float Field229 { get; set; }

    public int? SpellDescriptionVariableId { get; set; }

    public int? SpellDifficultyId { get; set; }

    public virtual Spellicon? ActiveIcon { get; set; }

    public virtual Spellcasttime? CastingTimeIndexNavigation { get; set; }

    public virtual Spellcategory? CategoryNavigation { get; set; }

    public virtual ICollection<Creaturespelldatum> CreaturespelldatumSpells1Navigations { get; set; } = new List<Creaturespelldatum>();

    public virtual ICollection<Creaturespelldatum> CreaturespelldatumSpells2Navigations { get; set; } = new List<Creaturespelldatum>();

    public virtual ICollection<Creaturespelldatum> CreaturespelldatumSpells3Navigations { get; set; } = new List<Creaturespelldatum>();

    public virtual ICollection<Creaturespelldatum> CreaturespelldatumSpells4Navigations { get; set; } = new List<Creaturespelldatum>();

    public virtual Spelldispeltype? DispelTypeNavigation { get; set; }

    public virtual Spellduration? DurationIndexNavigation { get; set; }

    public virtual Spellmechanic? EffectMechanic1Navigation { get; set; }

    public virtual Spellmechanic? EffectMechanic2Navigation { get; set; }

    public virtual Spellmechanic? EffectMechanic3Navigation { get; set; }

    public virtual Spellradius? EffectRadiusIndex1Navigation { get; set; }

    public virtual Spellradius? EffectRadiusIndex2Navigation { get; set; }

    public virtual Spellradius? EffectRadiusIndex3Navigation { get; set; }

    public virtual ICollection<Glyphproperty> Glyphproperties { get; set; } = new List<Glyphproperty>();

    public virtual ICollection<Itemset> ItemsetSetSpellId1Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetSetSpellId2Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetSetSpellId3Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetSetSpellId4Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetSetSpellId5Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetSetSpellId6Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetSetSpellId7Navigations { get; set; } = new List<Itemset>();

    public virtual ICollection<Itemset> ItemsetSetSpellId8Navigations { get; set; } = new List<Itemset>();

    public virtual Spellmechanic? MechanicNavigation { get; set; }

    public virtual ICollection<Overridespelldatum> OverridespelldatumSpells10Navigations { get; set; } = new List<Overridespelldatum>();

    public virtual ICollection<Overridespelldatum> OverridespelldatumSpells1Navigations { get; set; } = new List<Overridespelldatum>();

    public virtual ICollection<Overridespelldatum> OverridespelldatumSpells2Navigations { get; set; } = new List<Overridespelldatum>();

    public virtual ICollection<Overridespelldatum> OverridespelldatumSpells3Navigations { get; set; } = new List<Overridespelldatum>();

    public virtual ICollection<Overridespelldatum> OverridespelldatumSpells4Navigations { get; set; } = new List<Overridespelldatum>();

    public virtual ICollection<Overridespelldatum> OverridespelldatumSpells5Navigations { get; set; } = new List<Overridespelldatum>();

    public virtual ICollection<Overridespelldatum> OverridespelldatumSpells6Navigations { get; set; } = new List<Overridespelldatum>();

    public virtual ICollection<Overridespelldatum> OverridespelldatumSpells7Navigations { get; set; } = new List<Overridespelldatum>();

    public virtual ICollection<Overridespelldatum> OverridespelldatumSpells8Navigations { get; set; } = new List<Overridespelldatum>();

    public virtual ICollection<Overridespelldatum> OverridespelldatumSpells9Navigations { get; set; } = new List<Overridespelldatum>();

    public virtual Powerdisplay? PowerDisplay { get; set; }

    public virtual Spellrange? RangeIndexNavigation { get; set; }

    public virtual Item? Reagent1Navigation { get; set; }

    public virtual Item? Reagent2Navigation { get; set; }

    public virtual Item? Reagent3Navigation { get; set; }

    public virtual Item? Reagent4Navigation { get; set; }

    public virtual Item? Reagent5Navigation { get; set; }

    public virtual Item? Reagent6Navigation { get; set; }

    public virtual Item? Reagent7Navigation { get; set; }

    public virtual Item? Reagent8Navigation { get; set; }

    public virtual Areagroup? RequiredAreas { get; set; }

    public virtual Totemcategory? RequiredTotemCategoryId1Navigation { get; set; }

    public virtual Totemcategory? RequiredTotemCategoryId2Navigation { get; set; }

    public virtual Spellfocusobject? RequiresSpellFocusNavigation { get; set; }

    public virtual Spellrunecost? RuneCost { get; set; }

    public virtual ICollection<Skilllineability> Skilllineabilities { get; set; } = new List<Skilllineability>();

    public virtual Spelldescriptionvariable? SpellDescriptionVariable { get; set; }

    public virtual Spelldifficulty? SpellDifficulty { get; set; }

    public virtual Spellicon? SpellIcon { get; set; }

    public virtual Spellmissile? SpellMissile { get; set; }

    public virtual Spellvisual? SpellVisualId1Navigation { get; set; }

    public virtual Spellvisual? SpellVisualId2Navigation { get; set; }

    public virtual ICollection<Spelldifficulty> SpelldifficultyDifficultySpellId1Navigations { get; set; } = new List<Spelldifficulty>();

    public virtual ICollection<Spelldifficulty> SpelldifficultyDifficultySpellId2Navigations { get; set; } = new List<Spelldifficulty>();

    public virtual ICollection<Spelldifficulty> SpelldifficultyDifficultySpellId3Navigations { get; set; } = new List<Spelldifficulty>();

    public virtual ICollection<Spelldifficulty> SpelldifficultyDifficultySpellId4Navigations { get; set; } = new List<Spelldifficulty>();

    public virtual ICollection<Spellshapeshiftform> SpellshapeshiftformPresetSpellId1Navigations { get; set; } = new List<Spellshapeshiftform>();

    public virtual ICollection<Spellshapeshiftform> SpellshapeshiftformPresetSpellId2Navigations { get; set; } = new List<Spellshapeshiftform>();

    public virtual ICollection<Spellshapeshiftform> SpellshapeshiftformPresetSpellId3Navigations { get; set; } = new List<Spellshapeshiftform>();

    public virtual ICollection<Spellshapeshiftform> SpellshapeshiftformPresetSpellId4Navigations { get; set; } = new List<Spellshapeshiftform>();

    public virtual ICollection<Spellshapeshiftform> SpellshapeshiftformPresetSpellId5Navigations { get; set; } = new List<Spellshapeshiftform>();

    public virtual ICollection<Spellshapeshiftform> SpellshapeshiftformPresetSpellId6Navigations { get; set; } = new List<Spellshapeshiftform>();

    public virtual ICollection<Spellshapeshiftform> SpellshapeshiftformPresetSpellId7Navigations { get; set; } = new List<Spellshapeshiftform>();

    public virtual ICollection<Spellshapeshiftform> SpellshapeshiftformPresetSpellId8Navigations { get; set; } = new List<Spellshapeshiftform>();

    public virtual ICollection<Talent> TalentRequiredSpells { get; set; } = new List<Talent>();

    public virtual ICollection<Talent> TalentSpellRank1Navigations { get; set; } = new List<Talent>();

    public virtual ICollection<Talent> TalentSpellRank2Navigations { get; set; } = new List<Talent>();

    public virtual ICollection<Talent> TalentSpellRank3Navigations { get; set; } = new List<Talent>();

    public virtual ICollection<Talent> TalentSpellRank4Navigations { get; set; } = new List<Talent>();

    public virtual ICollection<Talent> TalentSpellRank5Navigations { get; set; } = new List<Talent>();

    public virtual ICollection<Talent> TalentSpellRank6Navigations { get; set; } = new List<Talent>();

    public virtual ICollection<Talent> TalentSpellRank7Navigations { get; set; } = new List<Talent>();

    public virtual ICollection<Talent> TalentSpellRank8Navigations { get; set; } = new List<Talent>();

    public virtual ICollection<Talent> TalentSpellRank9Navigations { get; set; } = new List<Talent>();
}
