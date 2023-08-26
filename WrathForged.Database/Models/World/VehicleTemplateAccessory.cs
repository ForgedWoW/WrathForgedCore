using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class VehicleTemplateAccessory
{
    public uint Entry { get; set; }

    public uint AccessoryEntry { get; set; }

    public sbyte SeatId { get; set; }

    public byte Minion { get; set; }

    public string Description { get; set; } = null!;

    /// <summary>
    /// see enum TempSummonType
    /// </summary>
    public byte Summontype { get; set; }

    /// <summary>
    /// timer, only relevant for certain summontypes
    /// </summary>
    public uint Summontimer { get; set; }
}
