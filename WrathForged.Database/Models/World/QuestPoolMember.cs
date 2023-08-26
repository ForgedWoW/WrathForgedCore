using System;
using System.Collections.Generic;

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
