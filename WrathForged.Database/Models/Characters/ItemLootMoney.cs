// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
