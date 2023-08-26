﻿using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Quest System
/// </summary>
public partial class QuestTemplate
{
    public uint Id { get; set; }

    public byte QuestType { get; set; }

    public short QuestLevel { get; set; }

    public byte MinLevel { get; set; }

    public short QuestSortId { get; set; }

    public ushort QuestInfoId { get; set; }

    public byte SuggestedGroupNum { get; set; }

    public ushort RequiredFactionId1 { get; set; }

    public ushort RequiredFactionId2 { get; set; }

    public int RequiredFactionValue1 { get; set; }

    public int RequiredFactionValue2 { get; set; }

    public uint RewardNextQuest { get; set; }

    public byte RewardXpdifficulty { get; set; }

    public int RewardMoney { get; set; }

    public uint RewardBonusMoney { get; set; }

    public uint RewardDisplaySpell { get; set; }

    public int RewardSpell { get; set; }

    public int RewardHonor { get; set; }

    public float RewardKillHonor { get; set; }

    public uint StartItem { get; set; }

    public uint Flags { get; set; }

    public byte RequiredPlayerKills { get; set; }

    public uint RewardItem1 { get; set; }

    public ushort RewardAmount1 { get; set; }

    public uint RewardItem2 { get; set; }

    public ushort RewardAmount2 { get; set; }

    public uint RewardItem3 { get; set; }

    public ushort RewardAmount3 { get; set; }

    public uint RewardItem4 { get; set; }

    public ushort RewardAmount4 { get; set; }

    public uint ItemDrop1 { get; set; }

    public ushort ItemDropQuantity1 { get; set; }

    public uint ItemDrop2 { get; set; }

    public ushort ItemDropQuantity2 { get; set; }

    public uint ItemDrop3 { get; set; }

    public ushort ItemDropQuantity3 { get; set; }

    public uint ItemDrop4 { get; set; }

    public ushort ItemDropQuantity4 { get; set; }

    public uint RewardChoiceItemId1 { get; set; }

    public ushort RewardChoiceItemQuantity1 { get; set; }

    public uint RewardChoiceItemId2 { get; set; }

    public ushort RewardChoiceItemQuantity2 { get; set; }

    public uint RewardChoiceItemId3 { get; set; }

    public ushort RewardChoiceItemQuantity3 { get; set; }

    public uint RewardChoiceItemId4 { get; set; }

    public ushort RewardChoiceItemQuantity4 { get; set; }

    public uint RewardChoiceItemId5 { get; set; }

    public ushort RewardChoiceItemQuantity5 { get; set; }

    public uint RewardChoiceItemId6 { get; set; }

    public ushort RewardChoiceItemQuantity6 { get; set; }

    public ushort Poicontinent { get; set; }

    public float Poix { get; set; }

    public float Poiy { get; set; }

    public uint Poipriority { get; set; }

    public byte RewardTitle { get; set; }

    public byte RewardTalents { get; set; }

    public ushort RewardArenaPoints { get; set; }

    /// <summary>
    /// faction id from Faction.dbc in this case
    /// </summary>
    public ushort RewardFactionId1 { get; set; }

    public int RewardFactionValue1 { get; set; }

    public int RewardFactionOverride1 { get; set; }

    /// <summary>
    /// faction id from Faction.dbc in this case
    /// </summary>
    public ushort RewardFactionId2 { get; set; }

    public int RewardFactionValue2 { get; set; }

    public int RewardFactionOverride2 { get; set; }

    /// <summary>
    /// faction id from Faction.dbc in this case
    /// </summary>
    public ushort RewardFactionId3 { get; set; }

    public int RewardFactionValue3 { get; set; }

    public int RewardFactionOverride3 { get; set; }

    /// <summary>
    /// faction id from Faction.dbc in this case
    /// </summary>
    public ushort RewardFactionId4 { get; set; }

    public int RewardFactionValue4 { get; set; }

    public int RewardFactionOverride4 { get; set; }

    /// <summary>
    /// faction id from Faction.dbc in this case
    /// </summary>
    public ushort RewardFactionId5 { get; set; }

    public int RewardFactionValue5 { get; set; }

    public int RewardFactionOverride5 { get; set; }

    public uint TimeAllowed { get; set; }

    public ushort AllowableRaces { get; set; }

    public string? LogTitle { get; set; }

    public string? LogDescription { get; set; }

    public string? QuestDescription { get; set; }

    public string? AreaDescription { get; set; }

    public string? QuestCompletionLog { get; set; }

    public int RequiredNpcOrGo1 { get; set; }

    public int RequiredNpcOrGo2 { get; set; }

    public int RequiredNpcOrGo3 { get; set; }

    public int RequiredNpcOrGo4 { get; set; }

    public ushort RequiredNpcOrGoCount1 { get; set; }

    public ushort RequiredNpcOrGoCount2 { get; set; }

    public ushort RequiredNpcOrGoCount3 { get; set; }

    public ushort RequiredNpcOrGoCount4 { get; set; }

    public uint RequiredItemId1 { get; set; }

    public uint RequiredItemId2 { get; set; }

    public uint RequiredItemId3 { get; set; }

    public uint RequiredItemId4 { get; set; }

    public uint RequiredItemId5 { get; set; }

    public uint RequiredItemId6 { get; set; }

    public ushort RequiredItemCount1 { get; set; }

    public ushort RequiredItemCount2 { get; set; }

    public ushort RequiredItemCount3 { get; set; }

    public ushort RequiredItemCount4 { get; set; }

    public ushort RequiredItemCount5 { get; set; }

    public ushort RequiredItemCount6 { get; set; }

    public byte Unknown0 { get; set; }

    public string? ObjectiveText1 { get; set; }

    public string? ObjectiveText2 { get; set; }

    public string? ObjectiveText3 { get; set; }

    public string? ObjectiveText4 { get; set; }

    public int? VerifiedBuild { get; set; }
}
