// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("Spell.dbc")]
    public partial class Spell : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? Category { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? DispelType { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? Mechanic { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.UINT32)]
        public uint Attributes { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.UINT32)]
        public uint AttributesEx { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.UINT32)]
        public uint AttributesExB { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.UINT32)]
        public uint AttributesExC { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.UINT32)]
        public uint AttributesExD { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.UINT32)]
        public uint AttributesExE { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.UINT32)]
        public uint AttributesExF { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.UINT32)]
        public uint AttributesExG { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.ULONG)]
        public ulong ShapeshiftMask { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.ULONG)]
        public ulong ShapeshiftExclude { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.UINT32)]
        public uint Targets { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.UINT32)]
        public uint TargetCreatureType { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.INT32, Nullable = true)]
        public int? RequiresSpellFocus { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.UINT32)]
        public uint FacingCasterFlags { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.UINT32)]
        public uint CasterAuraState { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.UINT32)]
        public uint TargetAuraState { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.UINT32)]
        public uint ExcludeCasterAuraState { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.UINT32)]
        public uint ExcludeTargetAuraState { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.UINT32)]
        public uint CasterAuraSpell { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.UINT32)]
        public uint TargetAuraSpell { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.UINT32)]
        public uint ExcludeCasterAuraSpell { get; set; }

        [DBCPropertyBinding(25, DBCBindingType.UINT32)]
        public uint ExcludeTargetAuraSpell { get; set; }

        [DBCPropertyBinding(26, DBCBindingType.INT32, Nullable = true)]
        public int? CastingTimeIndex { get; set; }

        [DBCPropertyBinding(27, DBCBindingType.UINT32)]
        public uint RecoveryTime { get; set; }

        [DBCPropertyBinding(28, DBCBindingType.UINT32)]
        public uint CategoryRecoveryTime { get; set; }

        [DBCPropertyBinding(29, DBCBindingType.UINT32)]
        public uint InterruptFlags { get; set; }

        [DBCPropertyBinding(30, DBCBindingType.UINT32)]
        public uint AuraInterruptFlags { get; set; }

        [DBCPropertyBinding(31, DBCBindingType.UINT32)]
        public uint ChannelInterruptFlags { get; set; }

        [DBCPropertyBinding(32, DBCBindingType.UINT32)]
        public uint ProcTypeMask { get; set; }

        [DBCPropertyBinding(33, DBCBindingType.UINT32)]
        public uint ProcChance { get; set; }

        [DBCPropertyBinding(34, DBCBindingType.UINT32)]
        public uint ProcCharges { get; set; }

        [DBCPropertyBinding(35, DBCBindingType.UINT32)]
        public uint MaxLevel { get; set; }

        [DBCPropertyBinding(36, DBCBindingType.UINT32)]
        public uint BaseLevel { get; set; }

        [DBCPropertyBinding(37, DBCBindingType.UINT32)]
        public uint SpellLevel { get; set; }

        [DBCPropertyBinding(38, DBCBindingType.INT32, Nullable = true)]
        public int? DurationIndex { get; set; }

        [DBCPropertyBinding(39, DBCBindingType.INT32)]
        public int PowerType { get; set; }

        [DBCPropertyBinding(40, DBCBindingType.UINT32)]
        public uint ManaCost { get; set; }

        [DBCPropertyBinding(41, DBCBindingType.UINT32)]
        public uint ManaCostPerLevel { get; set; }

        [DBCPropertyBinding(42, DBCBindingType.UINT32)]
        public uint ManaPerSecond { get; set; }

        [DBCPropertyBinding(43, DBCBindingType.UINT32)]
        public uint ManaPerSecondPerLevel { get; set; }

        [DBCPropertyBinding(44, DBCBindingType.INT32, Nullable = true)]
        public int? RangeIndex { get; set; }

        [DBCPropertyBinding(45, DBCBindingType.FLOAT)]
        public float Speed { get; set; }

        [DBCPropertyBinding(46, DBCBindingType.UINT32)]
        public uint ModalNextSpell { get; set; }

        [DBCPropertyBinding(47, DBCBindingType.UINT32)]
        public uint CumulativeAura { get; set; }

        [DBCPropertyBinding(48, DBCBindingType.UINT32)]
        public uint Totem1 { get; set; }

        [DBCPropertyBinding(49, DBCBindingType.UINT32)]
        public uint Totem2 { get; set; }

        [DBCPropertyBinding(50, DBCBindingType.INT32, Nullable = true)]
        public int? Reagent1 { get; set; }

        [DBCPropertyBinding(51, DBCBindingType.INT32, Nullable = true)]
        public int? Reagent2 { get; set; }

        [DBCPropertyBinding(52, DBCBindingType.INT32, Nullable = true)]
        public int? Reagent3 { get; set; }

        [DBCPropertyBinding(53, DBCBindingType.INT32, Nullable = true)]
        public int? Reagent4 { get; set; }

        [DBCPropertyBinding(54, DBCBindingType.INT32, Nullable = true)]
        public int? Reagent5 { get; set; }

        [DBCPropertyBinding(55, DBCBindingType.INT32, Nullable = true)]
        public int? Reagent6 { get; set; }

        [DBCPropertyBinding(56, DBCBindingType.INT32, Nullable = true)]
        public int? Reagent7 { get; set; }

        [DBCPropertyBinding(57, DBCBindingType.INT32, Nullable = true)]
        public int? Reagent8 { get; set; }

        [DBCPropertyBinding(58, DBCBindingType.INT32)]
        public int ReagentCount1 { get; set; }

        [DBCPropertyBinding(59, DBCBindingType.INT32)]
        public int ReagentCount2 { get; set; }

        [DBCPropertyBinding(60, DBCBindingType.INT32)]
        public int ReagentCount3 { get; set; }

        [DBCPropertyBinding(61, DBCBindingType.INT32)]
        public int ReagentCount4 { get; set; }

        [DBCPropertyBinding(62, DBCBindingType.INT32)]
        public int ReagentCount5 { get; set; }

        [DBCPropertyBinding(63, DBCBindingType.INT32)]
        public int ReagentCount6 { get; set; }

        [DBCPropertyBinding(64, DBCBindingType.INT32)]
        public int ReagentCount7 { get; set; }

        [DBCPropertyBinding(65, DBCBindingType.INT32)]
        public int ReagentCount8 { get; set; }

        [DBCPropertyBinding(66, DBCBindingType.INT32)]
        public int EquippedItemClass { get; set; }

        [DBCPropertyBinding(67, DBCBindingType.INT32)]
        public int EquippedItemSubclass { get; set; }

        [DBCPropertyBinding(68, DBCBindingType.INT32)]
        public int EquippedItemInvTypes { get; set; }

        [DBCPropertyBinding(69, DBCBindingType.UINT32)]
        public uint Effect1 { get; set; }

        [DBCPropertyBinding(70, DBCBindingType.UINT32)]
        public uint Effect2 { get; set; }

        [DBCPropertyBinding(71, DBCBindingType.UINT32)]
        public uint Effect3 { get; set; }

        [DBCPropertyBinding(72, DBCBindingType.INT32)]
        public int EffectDieSides1 { get; set; }

        [DBCPropertyBinding(73, DBCBindingType.INT32)]
        public int EffectDieSides2 { get; set; }

        [DBCPropertyBinding(74, DBCBindingType.INT32)]
        public int EffectDieSides3 { get; set; }

        [DBCPropertyBinding(75, DBCBindingType.FLOAT)]
        public float EffectRealPointsPerLevel1 { get; set; }

        [DBCPropertyBinding(76, DBCBindingType.FLOAT)]
        public float EffectRealPointsPerLevel2 { get; set; }

        [DBCPropertyBinding(77, DBCBindingType.FLOAT)]
        public float EffectRealPointsPerLevel3 { get; set; }

        [DBCPropertyBinding(78, DBCBindingType.INT32)]
        public int EffectBasePoints1 { get; set; }

        [DBCPropertyBinding(79, DBCBindingType.INT32)]
        public int EffectBasePoints2 { get; set; }

        [DBCPropertyBinding(80, DBCBindingType.INT32)]
        public int EffectBasePoints3 { get; set; }

        [DBCPropertyBinding(81, DBCBindingType.INT32, Nullable = true)]
        public int? EffectMechanic1 { get; set; }

        [DBCPropertyBinding(82, DBCBindingType.INT32, Nullable = true)]
        public int? EffectMechanic2 { get; set; }

        [DBCPropertyBinding(83, DBCBindingType.INT32, Nullable = true)]
        public int? EffectMechanic3 { get; set; }

        [DBCPropertyBinding(84, DBCBindingType.UINT32)]
        public uint ImplicitTargetA1 { get; set; }

        [DBCPropertyBinding(85, DBCBindingType.UINT32)]
        public uint ImplicitTargetA2 { get; set; }

        [DBCPropertyBinding(86, DBCBindingType.UINT32)]
        public uint ImplicitTargetA3 { get; set; }

        [DBCPropertyBinding(87, DBCBindingType.UINT32)]
        public uint ImplicitTargetB1 { get; set; }

        [DBCPropertyBinding(88, DBCBindingType.UINT32)]
        public uint ImplicitTargetB2 { get; set; }

        [DBCPropertyBinding(89, DBCBindingType.UINT32)]
        public uint ImplicitTargetB3 { get; set; }

        [DBCPropertyBinding(90, DBCBindingType.INT32, Nullable = true)]
        public int? EffectRadiusIndex1 { get; set; }

        [DBCPropertyBinding(91, DBCBindingType.INT32, Nullable = true)]
        public int? EffectRadiusIndex2 { get; set; }

        [DBCPropertyBinding(92, DBCBindingType.INT32, Nullable = true)]
        public int? EffectRadiusIndex3 { get; set; }

        [DBCPropertyBinding(93, DBCBindingType.UINT32)]
        public uint EffectAura1 { get; set; }

        [DBCPropertyBinding(94, DBCBindingType.UINT32)]
        public uint EffectAura2 { get; set; }

        [DBCPropertyBinding(95, DBCBindingType.UINT32)]
        public uint EffectAura3 { get; set; }

        [DBCPropertyBinding(96, DBCBindingType.UINT32)]
        public uint EffectAuraPeriod1 { get; set; }

        [DBCPropertyBinding(97, DBCBindingType.UINT32)]
        public uint EffectAuraPeriod2 { get; set; }

        [DBCPropertyBinding(98, DBCBindingType.UINT32)]
        public uint EffectAuraPeriod3 { get; set; }

        [DBCPropertyBinding(99, DBCBindingType.FLOAT)]
        public float EffectMultipleValue1 { get; set; }

        [DBCPropertyBinding(100, DBCBindingType.FLOAT)]
        public float EffectMultipleValue2 { get; set; }

        [DBCPropertyBinding(101, DBCBindingType.FLOAT)]
        public float EffectMultipleValue3 { get; set; }

        [DBCPropertyBinding(102, DBCBindingType.UINT32)]
        public uint EffectChainTargets1 { get; set; }

        [DBCPropertyBinding(103, DBCBindingType.UINT32)]
        public uint EffectChainTargets2 { get; set; }

        [DBCPropertyBinding(104, DBCBindingType.UINT32)]
        public uint EffectChainTargets3 { get; set; }

        [DBCPropertyBinding(105, DBCBindingType.UINT32)]
        public uint EffectItemType1 { get; set; }

        [DBCPropertyBinding(106, DBCBindingType.UINT32)]
        public uint EffectItemType2 { get; set; }

        [DBCPropertyBinding(107, DBCBindingType.UINT32)]
        public uint EffectItemType3 { get; set; }

        [DBCPropertyBinding(108, DBCBindingType.INT32)]
        public int EffectMiscValue1 { get; set; }

        [DBCPropertyBinding(109, DBCBindingType.INT32)]
        public int EffectMiscValue2 { get; set; }

        [DBCPropertyBinding(110, DBCBindingType.INT32)]
        public int EffectMiscValue3 { get; set; }

        [DBCPropertyBinding(111, DBCBindingType.INT32)]
        public int EffectMiscValueB1 { get; set; }

        [DBCPropertyBinding(112, DBCBindingType.INT32)]
        public int EffectMiscValueB2 { get; set; }

        [DBCPropertyBinding(113, DBCBindingType.INT32)]
        public int EffectMiscValueB3 { get; set; }

        [DBCPropertyBinding(114, DBCBindingType.UINT32)]
        public uint EffectTriggerSpell1 { get; set; }

        [DBCPropertyBinding(115, DBCBindingType.UINT32)]
        public uint EffectTriggerSpell2 { get; set; }

        [DBCPropertyBinding(116, DBCBindingType.UINT32)]
        public uint EffectTriggerSpell3 { get; set; }

        [DBCPropertyBinding(117, DBCBindingType.FLOAT)]
        public float EffectPointsPerCombo1 { get; set; }

        [DBCPropertyBinding(118, DBCBindingType.FLOAT)]
        public float EffectPointsPerCombo2 { get; set; }

        [DBCPropertyBinding(119, DBCBindingType.FLOAT)]
        public float EffectPointsPerCombo3 { get; set; }

        [DBCPropertyBinding(120, DBCBindingType.UINT32)]
        public uint EffectSpellClassMaskA1 { get; set; }

        [DBCPropertyBinding(121, DBCBindingType.UINT32)]
        public uint EffectSpellClassMaskA2 { get; set; }

        [DBCPropertyBinding(122, DBCBindingType.UINT32)]
        public uint EffectSpellClassMaskA3 { get; set; }

        [DBCPropertyBinding(123, DBCBindingType.UINT32)]
        public uint EffectSpellClassMaskB1 { get; set; }

        [DBCPropertyBinding(124, DBCBindingType.UINT32)]
        public uint EffectSpellClassMaskB2 { get; set; }

        [DBCPropertyBinding(125, DBCBindingType.UINT32)]
        public uint EffectSpellClassMaskB3 { get; set; }

        [DBCPropertyBinding(126, DBCBindingType.UINT32)]
        public uint EffectSpellClassMaskC1 { get; set; }

        [DBCPropertyBinding(127, DBCBindingType.UINT32)]
        public uint EffectSpellClassMaskC2 { get; set; }

        [DBCPropertyBinding(128, DBCBindingType.UINT32)]
        public uint EffectSpellClassMaskC3 { get; set; }

        [DBCPropertyBinding(129, DBCBindingType.INT32, Nullable = true)]
        public int? SpellVisualId1 { get; set; }

        [DBCPropertyBinding(130, DBCBindingType.INT32, Nullable = true)]
        public int? SpellVisualId2 { get; set; }

        [DBCPropertyBinding(131, DBCBindingType.INT32, Nullable = true)]
        public int? SpellIconId { get; set; }

        [DBCPropertyBinding(132, DBCBindingType.INT32, Nullable = true)]
        public int? ActiveIconId { get; set; }

        [DBCPropertyBinding(133, DBCBindingType.UINT32)]
        public uint SpellPriority { get; set; }

        [DBCPropertyBinding(134, DBCBindingType.STRING)]
        public string? NameLangEnUs { get; set; }

        [DBCPropertyBinding(135, DBCBindingType.STRING)]
        public string? NameLangEnGb { get; set; }

        [DBCPropertyBinding(136, DBCBindingType.STRING)]
        public string? NameLangKoKr { get; set; }

        [DBCPropertyBinding(137, DBCBindingType.STRING)]
        public string? NameLangFrFr { get; set; }

        [DBCPropertyBinding(138, DBCBindingType.STRING)]
        public string? NameLangDeDe { get; set; }

        [DBCPropertyBinding(139, DBCBindingType.STRING)]
        public string? NameLangEnCn { get; set; }

        [DBCPropertyBinding(140, DBCBindingType.STRING)]
        public string? NameLangZhCn { get; set; }

        [DBCPropertyBinding(141, DBCBindingType.STRING)]
        public string? NameLangEnTw { get; set; }

        [DBCPropertyBinding(142, DBCBindingType.STRING)]
        public string? NameLangZhTw { get; set; }

        [DBCPropertyBinding(143, DBCBindingType.STRING)]
        public string? NameLangEsEs { get; set; }

        [DBCPropertyBinding(144, DBCBindingType.STRING)]
        public string? NameLangEsMx { get; set; }

        [DBCPropertyBinding(145, DBCBindingType.STRING)]
        public string? NameLangRuRu { get; set; }

        [DBCPropertyBinding(146, DBCBindingType.STRING)]
        public string? NameLangPtPt { get; set; }

        [DBCPropertyBinding(147, DBCBindingType.STRING)]
        public string? NameLangPtBr { get; set; }

        [DBCPropertyBinding(148, DBCBindingType.STRING)]
        public string? NameLangItIt { get; set; }

        [DBCPropertyBinding(149, DBCBindingType.STRING)]
        public string? NameLangUnk { get; set; }

        [DBCPropertyBinding(150, DBCBindingType.UINT32)]
        public uint NameLangMask { get; set; }

        [DBCPropertyBinding(151, DBCBindingType.STRING)]
        public string? NameSubtextLangEnUs { get; set; }

        [DBCPropertyBinding(152, DBCBindingType.STRING)]
        public string? NameSubtextLangEnGb { get; set; }

        [DBCPropertyBinding(153, DBCBindingType.STRING)]
        public string? NameSubtextLangKoKr { get; set; }

        [DBCPropertyBinding(154, DBCBindingType.STRING)]
        public string? NameSubtextLangFrFr { get; set; }

        [DBCPropertyBinding(155, DBCBindingType.STRING)]
        public string? NameSubtextLangDeDe { get; set; }

        [DBCPropertyBinding(156, DBCBindingType.STRING)]
        public string? NameSubtextLangEnCn { get; set; }

        [DBCPropertyBinding(157, DBCBindingType.STRING)]
        public string? NameSubtextLangZhCn { get; set; }

        [DBCPropertyBinding(158, DBCBindingType.STRING)]
        public string? NameSubtextLangEnTw { get; set; }

        [DBCPropertyBinding(159, DBCBindingType.STRING)]
        public string? NameSubtextLangZhTw { get; set; }

        [DBCPropertyBinding(160, DBCBindingType.STRING)]
        public string? NameSubtextLangEsEs { get; set; }

        [DBCPropertyBinding(161, DBCBindingType.STRING)]
        public string? NameSubtextLangEsMx { get; set; }

        [DBCPropertyBinding(162, DBCBindingType.STRING)]
        public string? NameSubtextLangRuRu { get; set; }

        [DBCPropertyBinding(163, DBCBindingType.STRING)]
        public string? NameSubtextLangPtPt { get; set; }

        [DBCPropertyBinding(164, DBCBindingType.STRING)]
        public string? NameSubtextLangPtBr { get; set; }

        [DBCPropertyBinding(165, DBCBindingType.STRING)]
        public string? NameSubtextLangItIt { get; set; }

        [DBCPropertyBinding(166, DBCBindingType.STRING)]
        public string? NameSubtextLangUnk { get; set; }

        [DBCPropertyBinding(167, DBCBindingType.UINT32)]
        public uint NameSubtextLangMask { get; set; }

        [DBCPropertyBinding(168, DBCBindingType.STRING)]
        public string? DescriptionLangEnUs { get; set; }

        [DBCPropertyBinding(169, DBCBindingType.STRING)]
        public string? DescriptionLangEnGb { get; set; }

        [DBCPropertyBinding(170, DBCBindingType.STRING)]
        public string? DescriptionLangKoKr { get; set; }

        [DBCPropertyBinding(171, DBCBindingType.STRING)]
        public string? DescriptionLangFrFr { get; set; }

        [DBCPropertyBinding(172, DBCBindingType.STRING)]
        public string? DescriptionLangDeDe { get; set; }

        [DBCPropertyBinding(173, DBCBindingType.STRING)]
        public string? DescriptionLangEnCn { get; set; }

        [DBCPropertyBinding(174, DBCBindingType.STRING)]
        public string? DescriptionLangZhCn { get; set; }

        [DBCPropertyBinding(175, DBCBindingType.STRING)]
        public string? DescriptionLangEnTw { get; set; }

        [DBCPropertyBinding(176, DBCBindingType.STRING)]
        public string? DescriptionLangZhTw { get; set; }

        [DBCPropertyBinding(177, DBCBindingType.STRING)]
        public string? DescriptionLangEsEs { get; set; }

        [DBCPropertyBinding(178, DBCBindingType.STRING)]
        public string? DescriptionLangEsMx { get; set; }

        [DBCPropertyBinding(179, DBCBindingType.STRING)]
        public string? DescriptionLangRuRu { get; set; }

        [DBCPropertyBinding(180, DBCBindingType.STRING)]
        public string? DescriptionLangPtPt { get; set; }

        [DBCPropertyBinding(181, DBCBindingType.STRING)]
        public string? DescriptionLangPtBr { get; set; }

        [DBCPropertyBinding(182, DBCBindingType.STRING)]
        public string? DescriptionLangItIt { get; set; }

        [DBCPropertyBinding(183, DBCBindingType.STRING)]
        public string? DescriptionLangUnk { get; set; }

        [DBCPropertyBinding(184, DBCBindingType.UINT32)]
        public uint DescriptionLangMask { get; set; }

        [DBCPropertyBinding(185, DBCBindingType.STRING)]
        public string? AuraDescriptionLangEnUs { get; set; }

        [DBCPropertyBinding(186, DBCBindingType.STRING)]
        public string? AuraDescriptionLangEnGb { get; set; }

        [DBCPropertyBinding(187, DBCBindingType.STRING)]
        public string? AuraDescriptionLangKoKr { get; set; }

        [DBCPropertyBinding(188, DBCBindingType.STRING)]
        public string? AuraDescriptionLangFrFr { get; set; }

        [DBCPropertyBinding(189, DBCBindingType.STRING)]
        public string? AuraDescriptionLangDeDe { get; set; }

        [DBCPropertyBinding(190, DBCBindingType.STRING)]
        public string? AuraDescriptionLangEnCn { get; set; }

        [DBCPropertyBinding(191, DBCBindingType.STRING)]
        public string? AuraDescriptionLangZhCn { get; set; }

        [DBCPropertyBinding(192, DBCBindingType.STRING)]
        public string? AuraDescriptionLangEnTw { get; set; }

        [DBCPropertyBinding(193, DBCBindingType.STRING)]
        public string? AuraDescriptionLangZhTw { get; set; }

        [DBCPropertyBinding(194, DBCBindingType.STRING)]
        public string? AuraDescriptionLangEsEs { get; set; }

        [DBCPropertyBinding(195, DBCBindingType.STRING)]
        public string? AuraDescriptionLangEsMx { get; set; }

        [DBCPropertyBinding(196, DBCBindingType.STRING)]
        public string? AuraDescriptionLangRuRu { get; set; }

        [DBCPropertyBinding(197, DBCBindingType.STRING)]
        public string? AuraDescriptionLangPtPt { get; set; }

        [DBCPropertyBinding(198, DBCBindingType.STRING)]
        public string? AuraDescriptionLangPtBr { get; set; }

        [DBCPropertyBinding(199, DBCBindingType.STRING)]
        public string? AuraDescriptionLangItIt { get; set; }

        [DBCPropertyBinding(200, DBCBindingType.STRING)]
        public string? AuraDescriptionLangUnk { get; set; }

        [DBCPropertyBinding(201, DBCBindingType.UINT32)]
        public uint AuraDescriptionLangMask { get; set; }

        [DBCPropertyBinding(202, DBCBindingType.UINT32)]
        public uint ManaCostPct { get; set; }

        [DBCPropertyBinding(203, DBCBindingType.UINT32)]
        public uint StartRecoveryCategory { get; set; }

        [DBCPropertyBinding(204, DBCBindingType.UINT32)]
        public uint StartRecoveryTime { get; set; }

        [DBCPropertyBinding(205, DBCBindingType.UINT32)]
        public uint MaxTargetLevel { get; set; }

        [DBCPropertyBinding(206, DBCBindingType.UINT32)]
        public uint SpellClassSet { get; set; }

        [DBCPropertyBinding(207, DBCBindingType.UINT32)]
        public uint SpellClassMask1 { get; set; }

        [DBCPropertyBinding(208, DBCBindingType.UINT32)]
        public uint SpellClassMask2 { get; set; }

        [DBCPropertyBinding(209, DBCBindingType.UINT32)]
        public uint SpellClassMask3 { get; set; }

        [DBCPropertyBinding(210, DBCBindingType.UINT32)]
        public uint MaxTargets { get; set; }

        [DBCPropertyBinding(211, DBCBindingType.UINT32)]
        public uint DefenseType { get; set; }

        [DBCPropertyBinding(212, DBCBindingType.UINT32)]
        public uint PreventionType { get; set; }

        [DBCPropertyBinding(213, DBCBindingType.UINT32)]
        public uint StanceBarOrder { get; set; }

        [DBCPropertyBinding(214, DBCBindingType.FLOAT)]
        public float EffectChainAmplitude1 { get; set; }

        [DBCPropertyBinding(215, DBCBindingType.FLOAT)]
        public float EffectChainAmplitude2 { get; set; }

        [DBCPropertyBinding(216, DBCBindingType.FLOAT)]
        public float EffectChainAmplitude3 { get; set; }

        [DBCPropertyBinding(217, DBCBindingType.UINT32)]
        public uint MinFactionId { get; set; }

        [DBCPropertyBinding(218, DBCBindingType.UINT32)]
        public uint MinReputation { get; set; }

        [DBCPropertyBinding(219, DBCBindingType.UINT32)]
        public uint RequiredAuraVision { get; set; }

        [DBCPropertyBinding(220, DBCBindingType.UINT32, Nullable = true)]
        public int? RequiredTotemCategoryId1 { get; set; }

        [DBCPropertyBinding(221, DBCBindingType.UINT32, Nullable = true)]
        public int? RequiredTotemCategoryId2 { get; set; }

        [DBCPropertyBinding(222, DBCBindingType.UINT32, Nullable = true)]
        public int? RequiredAreasId { get; set; }

        [DBCPropertyBinding(223, DBCBindingType.UINT32)]
        public uint SchoolMask { get; set; }

        [DBCPropertyBinding(224, DBCBindingType.INT32, Nullable = true)]
        public int? RuneCostId { get; set; }

        [DBCPropertyBinding(225, DBCBindingType.INT32, Nullable = true)]
        public int? SpellMissileId { get; set; }

        [DBCPropertyBinding(226, DBCBindingType.INT32, Nullable = true)]
        public int? PowerDisplayId { get; set; }

        [DBCPropertyBinding(227, DBCBindingType.FLOAT)]
        public float Field227 { get; set; }

        [DBCPropertyBinding(228, DBCBindingType.FLOAT)]
        public float Field228 { get; set; }

        [DBCPropertyBinding(229, DBCBindingType.FLOAT)]
        public float Field229 { get; set; }

        [DBCPropertyBinding(230, DBCBindingType.INT32, Nullable = true)]
        public int? SpellDescriptionVariableId { get; set; }

        [DBCPropertyBinding(231, DBCBindingType.INT32, Nullable = true)]
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
}