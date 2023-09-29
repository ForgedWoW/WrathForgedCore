// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
