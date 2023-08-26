﻿using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Custom spell.dbc entries
/// </summary>
public partial class SpellDbc
{
    public uint Id { get; set; }

    public uint Dispel { get; set; }

    public uint Mechanic { get; set; }

    public uint Attributes { get; set; }

    public uint AttributesEx { get; set; }

    public uint AttributesEx2 { get; set; }

    public uint AttributesEx3 { get; set; }

    public uint AttributesEx4 { get; set; }

    public uint AttributesEx5 { get; set; }

    public uint AttributesEx6 { get; set; }

    public uint AttributesEx7 { get; set; }

    public uint Stances { get; set; }

    public uint StancesNot { get; set; }

    public uint Targets { get; set; }

    public uint CastingTimeIndex { get; set; }

    public uint AuraInterruptFlags { get; set; }

    public uint ProcFlags { get; set; }

    public uint ProcChance { get; set; }

    public uint ProcCharges { get; set; }

    public uint MaxLevel { get; set; }

    public uint BaseLevel { get; set; }

    public uint SpellLevel { get; set; }

    public uint DurationIndex { get; set; }

    public uint RangeIndex { get; set; }

    public uint StackAmount { get; set; }

    public int EquippedItemClass { get; set; }

    public int EquippedItemSubClassMask { get; set; }

    public int EquippedItemInventoryTypeMask { get; set; }

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

    public uint EffectMechanic1 { get; set; }

    public uint EffectMechanic2 { get; set; }

    public uint EffectMechanic3 { get; set; }

    public uint EffectImplicitTargetA1 { get; set; }

    public uint EffectImplicitTargetA2 { get; set; }

    public uint EffectImplicitTargetA3 { get; set; }

    public uint EffectImplicitTargetB1 { get; set; }

    public uint EffectImplicitTargetB2 { get; set; }

    public uint EffectImplicitTargetB3 { get; set; }

    public uint EffectRadiusIndex1 { get; set; }

    public uint EffectRadiusIndex2 { get; set; }

    public uint EffectRadiusIndex3 { get; set; }

    public uint EffectApplyAuraName1 { get; set; }

    public uint EffectApplyAuraName2 { get; set; }

    public uint EffectApplyAuraName3 { get; set; }

    public int EffectAmplitude1 { get; set; }

    public int EffectAmplitude2 { get; set; }

    public int EffectAmplitude3 { get; set; }

    public float EffectMultipleValue1 { get; set; }

    public float EffectMultipleValue2 { get; set; }

    public float EffectMultipleValue3 { get; set; }

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

    public uint EffectSpellClassMaskA1 { get; set; }

    public uint EffectSpellClassMaskA2 { get; set; }

    public uint EffectSpellClassMaskA3 { get; set; }

    public uint EffectSpellClassMaskB1 { get; set; }

    public uint EffectSpellClassMaskB2 { get; set; }

    public uint EffectSpellClassMaskB3 { get; set; }

    public uint EffectSpellClassMaskC1 { get; set; }

    public uint EffectSpellClassMaskC2 { get; set; }

    public uint EffectSpellClassMaskC3 { get; set; }

    public string? SpellName { get; set; }

    public uint MaxTargetLevel { get; set; }

    public uint SpellFamilyName { get; set; }

    public uint SpellFamilyFlags1 { get; set; }

    public uint SpellFamilyFlags2 { get; set; }

    public uint SpellFamilyFlags3 { get; set; }

    public uint MaxAffectedTargets { get; set; }

    public uint DmgClass { get; set; }

    public uint PreventionType { get; set; }

    public float DmgMultiplier1 { get; set; }

    public float DmgMultiplier2 { get; set; }

    public float DmgMultiplier3 { get; set; }

    public int AreaGroupId { get; set; }

    public uint SchoolMask { get; set; }
}
