using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Pet System
/// </summary>
public partial class PetSpell
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Spell Identifier
    /// </summary>
    public uint Spell { get; set; }

    public byte Active { get; set; }
}
