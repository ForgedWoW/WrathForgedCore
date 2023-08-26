using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Stores levels stats.
/// </summary>
public partial class PlayerLevelstat
{
    public byte Race { get; set; }

    public byte Class { get; set; }

    public byte Level { get; set; }

    public byte Str { get; set; }

    public byte Agi { get; set; }

    public byte Sta { get; set; }

    public byte Inte { get; set; }

    public byte Spi { get; set; }
}
