// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class HolidayDate
{
    public uint Id { get; set; }

    public byte DateId { get; set; }

    public uint DateValue { get; set; }

    public uint HolidayDuration { get; set; }
}
