using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class GameEventArenaSeason
{
    /// <summary>
    /// Entry of the game event
    /// </summary>
    public byte EventEntry { get; set; }

    /// <summary>
    /// Arena season number
    /// </summary>
    public byte Season { get; set; }
}
