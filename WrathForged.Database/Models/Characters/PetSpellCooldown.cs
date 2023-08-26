using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class PetSpellCooldown
{
    /// <summary>
    /// Global Unique Identifier, Low part
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Spell Identifier
    /// </summary>
    public uint Spell { get; set; }

    public uint Time { get; set; }

    /// <summary>
    /// Spell category Id
    /// </summary>
    public uint CategoryId { get; set; }

    public uint CategoryEnd { get; set; }
}
