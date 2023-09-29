// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
