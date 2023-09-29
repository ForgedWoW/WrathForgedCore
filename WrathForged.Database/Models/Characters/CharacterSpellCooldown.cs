// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

public partial class CharacterSpellCooldown
{
    /// <summary>
    /// Global Unique Identifier, Low part
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Spell Identifier
    /// </summary>
    public uint Spell { get; set; }

    /// <summary>
    /// Item Identifier
    /// </summary>
    public uint Item { get; set; }

    public uint Time { get; set; }

    /// <summary>
    /// Spell category Id
    /// </summary>
    public uint CategoryId { get; set; }

    public uint CategoryEnd { get; set; }
}
