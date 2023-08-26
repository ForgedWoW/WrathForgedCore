using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class ItemLootItem
{
    /// <summary>
    /// guid of container (item_instance.guid)
    /// </summary>
    public uint ContainerId { get; set; }

    /// <summary>
    /// loot item entry (item_instance.itemEntry)
    /// </summary>
    public uint ItemId { get; set; }

    /// <summary>
    /// stack size
    /// </summary>
    public int ItemCount { get; set; }

    public uint ItemIndex { get; set; }

    /// <summary>
    /// follow loot rules
    /// </summary>
    public bool FollowRules { get; set; }

    /// <summary>
    /// free-for-all
    /// </summary>
    public bool Ffa { get; set; }

    public bool Blocked { get; set; }

    public bool Counted { get; set; }

    public bool UnderThreshold { get; set; }

    /// <summary>
    /// quest drop
    /// </summary>
    public bool NeedsQuest { get; set; }

    /// <summary>
    /// random enchantment added when originally rolled
    /// </summary>
    public int RndProp { get; set; }

    /// <summary>
    /// random suffix added when originally rolled
    /// </summary>
    public int RndSuffix { get; set; }
}
