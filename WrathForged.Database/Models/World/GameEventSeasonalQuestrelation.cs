// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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
