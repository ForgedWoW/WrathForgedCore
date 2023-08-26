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
