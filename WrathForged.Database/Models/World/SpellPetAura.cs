using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class SpellPetAura
{
    /// <summary>
    /// dummy spell id
    /// </summary>
    public uint Spell { get; set; }

    public byte EffectId { get; set; }

    /// <summary>
    /// pet id; 0 = all
    /// </summary>
    public uint Pet { get; set; }

    /// <summary>
    /// pet aura id
    /// </summary>
    public uint Aura { get; set; }
}
