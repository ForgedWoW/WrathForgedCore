using System;
using System.Collections.Generic;

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
