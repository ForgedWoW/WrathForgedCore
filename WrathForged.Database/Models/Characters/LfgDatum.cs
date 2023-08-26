using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// LFG Data
/// </summary>
public partial class LfgDatum
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public uint Dungeon { get; set; }

    public byte State { get; set; }
}
