// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

/// <summary>
/// Spell System
/// </summary>
public partial class SpellLinkedSpell
{
    public int SpellTrigger { get; set; }

    public int SpellEffect { get; set; }

    public byte Type { get; set; }

    public string Comment { get; set; } = null!;
}
