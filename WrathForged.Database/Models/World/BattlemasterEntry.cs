using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class BattlemasterEntry
{
    /// <summary>
    /// Entry of a creature
    /// </summary>
    public uint Entry { get; set; }

    /// <summary>
    /// Battleground template id
    /// </summary>
    public uint BgTemplate { get; set; }
}
