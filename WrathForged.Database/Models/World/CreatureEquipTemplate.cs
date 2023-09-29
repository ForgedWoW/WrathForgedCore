// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class CreatureEquipTemplate
{
    public uint CreatureId { get; set; }

    public byte Id { get; set; }

    public uint ItemId1 { get; set; }

    public uint ItemId2 { get; set; }

    public uint ItemId3 { get; set; }

    public int? VerifiedBuild { get; set; }
}
