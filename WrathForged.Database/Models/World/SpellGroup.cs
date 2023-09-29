// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

/// <summary>
/// Spell System
/// </summary>
public partial class SpellGroup
{
    public uint Id { get; set; }

    public int SpellId { get; set; }
}
