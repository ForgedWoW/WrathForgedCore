using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Spell System
/// </summary>
public partial class SpellGroup
{
    public uint Id { get; set; }

    public int SpellId { get; set; }
}
