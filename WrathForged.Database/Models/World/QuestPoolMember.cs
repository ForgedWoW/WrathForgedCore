// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class QuestPoolMember
{
    public uint QuestId { get; set; }

    public uint PoolId { get; set; }

    /// <summary>
    /// Multiple quests with the same index will always spawn together!
    /// </summary>
    public byte PoolIndex { get; set; }

    public string? Description { get; set; }
}
