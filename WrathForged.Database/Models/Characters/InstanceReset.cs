// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

public partial class InstanceReset
{
    public ushort Mapid { get; set; }

    public byte Difficulty { get; set; }

    public ulong Resettime { get; set; }
}
