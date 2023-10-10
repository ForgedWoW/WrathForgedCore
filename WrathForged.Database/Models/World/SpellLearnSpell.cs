// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

/// <summary>
/// Item System
/// </summary>
public partial class SpellLearnSpell
{
    public uint Entry { get; set; }

    public uint SpellId { get; set; }

    public byte Active { get; set; }
}
