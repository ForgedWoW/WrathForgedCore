﻿using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Item System
/// </summary>
public partial class ItemTemplate
{
    public uint Entry { get; set; }

    public byte Class { get; set; }

    public byte Subclass { get; set; }

    public sbyte SoundOverrideSubclass { get; set; }

    public string Name { get; set; } = null!;

    public uint Displayid { get; set; }

    public byte Quality { get; set; }

    public uint Flags { get; set; }

    public uint FlagsExtra { get; set; }

    public byte BuyCount { get; set; }

    public long BuyPrice { get; set; }

    public uint SellPrice { get; set; }

    public byte InventoryType { get; set; }

    public int AllowableClass { get; set; }

    public int AllowableRace { get; set; }

    public ushort ItemLevel { get; set; }

    public byte RequiredLevel { get; set; }

    public ushort RequiredSkill { get; set; }

    public ushort RequiredSkillRank { get; set; }

    public uint Requiredspell { get; set; }

    public uint Requiredhonorrank { get; set; }

    public uint RequiredCityRank { get; set; }

    public ushort RequiredReputationFaction { get; set; }

    public ushort RequiredReputationRank { get; set; }

    public int Maxcount { get; set; }

    public int? Stackable { get; set; }

    public byte ContainerSlots { get; set; }

    public byte StatsCount { get; set; }

    public byte StatType1 { get; set; }

    public short StatValue1 { get; set; }

    public byte StatType2 { get; set; }

    public short StatValue2 { get; set; }

    public byte StatType3 { get; set; }

    public short StatValue3 { get; set; }

    public byte StatType4 { get; set; }

    public short StatValue4 { get; set; }

    public byte StatType5 { get; set; }

    public short StatValue5 { get; set; }

    public byte StatType6 { get; set; }

    public short StatValue6 { get; set; }

    public byte StatType7 { get; set; }

    public short StatValue7 { get; set; }

    public byte StatType8 { get; set; }

    public short StatValue8 { get; set; }

    public byte StatType9 { get; set; }

    public short StatValue9 { get; set; }

    public byte StatType10 { get; set; }

    public short StatValue10 { get; set; }

    public short ScalingStatDistribution { get; set; }

    public uint ScalingStatValue { get; set; }

    public float DmgMin1 { get; set; }

    public float DmgMax1 { get; set; }

    public byte DmgType1 { get; set; }

    public float DmgMin2 { get; set; }

    public float DmgMax2 { get; set; }

    public byte DmgType2 { get; set; }

    public ushort Armor { get; set; }

    public byte HolyRes { get; set; }

    public byte FireRes { get; set; }

    public byte NatureRes { get; set; }

    public byte FrostRes { get; set; }

    public byte ShadowRes { get; set; }

    public byte ArcaneRes { get; set; }

    public ushort Delay { get; set; }

    public byte AmmoType { get; set; }

    public float RangedModRange { get; set; }

    public int Spellid1 { get; set; }

    public byte Spelltrigger1 { get; set; }

    public short Spellcharges1 { get; set; }

    public float SpellppmRate1 { get; set; }

    public int Spellcooldown1 { get; set; }

    public ushort Spellcategory1 { get; set; }

    public int Spellcategorycooldown1 { get; set; }

    public int Spellid2 { get; set; }

    public byte Spelltrigger2 { get; set; }

    public short Spellcharges2 { get; set; }

    public float SpellppmRate2 { get; set; }

    public int Spellcooldown2 { get; set; }

    public ushort Spellcategory2 { get; set; }

    public int Spellcategorycooldown2 { get; set; }

    public int Spellid3 { get; set; }

    public byte Spelltrigger3 { get; set; }

    public short Spellcharges3 { get; set; }

    public float SpellppmRate3 { get; set; }

    public int Spellcooldown3 { get; set; }

    public ushort Spellcategory3 { get; set; }

    public int Spellcategorycooldown3 { get; set; }

    public int Spellid4 { get; set; }

    public byte Spelltrigger4 { get; set; }

    public short Spellcharges4 { get; set; }

    public float SpellppmRate4 { get; set; }

    public int Spellcooldown4 { get; set; }

    public ushort Spellcategory4 { get; set; }

    public int Spellcategorycooldown4 { get; set; }

    public int Spellid5 { get; set; }

    public byte Spelltrigger5 { get; set; }

    public short Spellcharges5 { get; set; }

    public float SpellppmRate5 { get; set; }

    public int Spellcooldown5 { get; set; }

    public ushort Spellcategory5 { get; set; }

    public int Spellcategorycooldown5 { get; set; }

    public byte Bonding { get; set; }

    public string Description { get; set; } = null!;

    public uint PageText { get; set; }

    public byte LanguageId { get; set; }

    public byte PageMaterial { get; set; }

    public uint Startquest { get; set; }

    public uint Lockid { get; set; }

    public sbyte Material { get; set; }

    public byte Sheath { get; set; }

    public int RandomProperty { get; set; }

    public uint RandomSuffix { get; set; }

    public uint Block { get; set; }

    public uint Itemset { get; set; }

    public ushort MaxDurability { get; set; }

    public uint Area { get; set; }

    public short Map { get; set; }

    public int BagFamily { get; set; }

    public int TotemCategory { get; set; }

    public sbyte SocketColor1 { get; set; }

    public int SocketContent1 { get; set; }

    public sbyte SocketColor2 { get; set; }

    public int SocketContent2 { get; set; }

    public sbyte SocketColor3 { get; set; }

    public int SocketContent3 { get; set; }

    public int SocketBonus { get; set; }

    public int GemProperties { get; set; }

    public short RequiredDisenchantSkill { get; set; }

    public float ArmorDamageModifier { get; set; }

    public uint Duration { get; set; }

    public short ItemLimitCategory { get; set; }

    public uint HolidayId { get; set; }

    public string ScriptName { get; set; } = null!;

    public uint DisenchantId { get; set; }

    public byte FoodType { get; set; }

    public uint MinMoneyLoot { get; set; }

    public uint MaxMoneyLoot { get; set; }

    public uint FlagsCustom { get; set; }

    public int? VerifiedBuild { get; set; }
}
