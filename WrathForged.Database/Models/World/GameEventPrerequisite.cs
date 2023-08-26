using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class GameEventPrerequisite
{
    /// <summary>
    /// Entry of the game event
    /// </summary>
    public byte EventEntry { get; set; }

    public uint PrerequisiteEvent { get; set; }
}
