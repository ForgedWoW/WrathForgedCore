using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Item System
/// </summary>
public partial class SpellLearnSpell
{
    public uint Entry { get; set; }

    public uint SpellId { get; set; }

    public byte Active { get; set; }
}
