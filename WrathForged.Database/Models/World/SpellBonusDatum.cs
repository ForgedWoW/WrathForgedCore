// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class SpellBonusDatum
{
    public uint Entry { get; set; }

    public float DirectBonus { get; set; }

    public float DotBonus { get; set; }

    public float ApBonus { get; set; }

    public float ApDotBonus { get; set; }

    public string? Comments { get; set; }
}
