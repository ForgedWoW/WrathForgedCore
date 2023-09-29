// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class VehicleSeatAddon
{
    /// <summary>
    /// VehicleSeatEntry.dbc identifier
    /// </summary>
    public uint SeatEntry { get; set; }

    /// <summary>
    /// Seat Orientation override value
    /// </summary>
    public float? SeatOrientation { get; set; }

    public float? ExitParamX { get; set; }

    public float? ExitParamY { get; set; }

    public float? ExitParamZ { get; set; }

    public float? ExitParamO { get; set; }

    public bool? ExitParamValue { get; set; }
}
