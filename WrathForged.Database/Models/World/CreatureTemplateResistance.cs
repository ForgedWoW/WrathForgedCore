// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class CreatureTemplateResistance
{
    public uint CreatureId { get; set; }

    public byte School { get; set; }

    public short? Resistance { get; set; }

    public int? VerifiedBuild { get; set; }
}
