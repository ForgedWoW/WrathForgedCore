// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class GameEventBattlegroundHoliday
{
    /// <summary>
    /// game_event EventEntry identifier
    /// </summary>
    public byte EventEntry { get; set; }

    public uint BattlegroundId { get; set; }
}
