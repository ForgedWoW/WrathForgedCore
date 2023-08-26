using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class GameEventNpcflag
{
    /// <summary>
    /// Entry of the game event
    /// </summary>
    public byte EventEntry { get; set; }

    public uint Guid { get; set; }

    public uint Npcflag { get; set; }
}
