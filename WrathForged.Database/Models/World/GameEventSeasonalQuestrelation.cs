using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Player System
/// </summary>
public partial class GameEventSeasonalQuestrelation
{
    /// <summary>
    /// Quest Identifier
    /// </summary>
    public uint QuestId { get; set; }

    /// <summary>
    /// Entry of the game event
    /// </summary>
    public uint EventEntry { get; set; }
}
