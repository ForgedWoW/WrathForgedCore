// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class PlayerTotemModel
{
    public byte TotemSlot { get; set; }

    public byte RaceId { get; set; }

    public uint DisplayId { get; set; }
}
