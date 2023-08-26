using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Spell Rank Data
/// </summary>
public partial class SpellRank
{
    public uint FirstSpellId { get; set; }

    public uint SpellId { get; set; }

    public byte Rank { get; set; }
}
