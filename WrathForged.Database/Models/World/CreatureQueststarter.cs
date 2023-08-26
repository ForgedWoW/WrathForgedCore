using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Creature System
/// </summary>
public partial class CreatureQueststarter
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// Quest Identifier
    /// </summary>
    public uint Quest { get; set; }
}
