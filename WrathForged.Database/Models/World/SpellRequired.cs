// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

/// <summary>
/// Spell Additinal Data
/// </summary>
public partial class SpellRequired
{
    public int SpellId { get; set; }

    public int ReqSpell { get; set; }
}
