// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Spell enchant proc data
/// </summary>
public partial class SpellEnchantProcDatum
{
    public uint EnchantId { get; set; }

    public float Chance { get; set; }

    public float ProcsPerMinute { get; set; }

    public uint HitMask { get; set; }

    public uint AttributesMask { get; set; }
}
