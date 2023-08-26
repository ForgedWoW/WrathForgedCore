using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class GameEventQuestCondition
{
    /// <summary>
    /// Entry of the game event.
    /// </summary>
    public byte EventEntry { get; set; }

    public uint Quest { get; set; }

    public uint ConditionId { get; set; }

    public float? Num { get; set; }
}
