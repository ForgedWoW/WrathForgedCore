using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class ItemLootMoney
{
    /// <summary>
    /// guid of container (item_instance.guid)
    /// </summary>
    public uint ContainerId { get; set; }

    /// <summary>
    /// money loot (in copper)
    /// </summary>
    public uint Money { get; set; }
}
