﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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
