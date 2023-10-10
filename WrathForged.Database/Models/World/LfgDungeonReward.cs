// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class LfgDungeonReward
{
    /// <summary>
    /// Dungeon entry from dbc
    /// </summary>
    public uint DungeonId { get; set; }

    /// <summary>
    /// Max level at which this reward is rewarded
    /// </summary>
    public byte MaxLevel { get; set; }

    /// <summary>
    /// Quest id with rewards for first dungeon this day
    /// </summary>
    public uint FirstQuestId { get; set; }

    /// <summary>
    /// Quest id with rewards for Nth dungeon this day
    /// </summary>
    public uint OtherQuestId { get; set; }
}
