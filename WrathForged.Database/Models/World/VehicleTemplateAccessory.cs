// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
