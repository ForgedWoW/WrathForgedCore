// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

/// <summary>
/// Creature waypoints
/// </summary>
public partial class Waypoint
{
    public uint Entry { get; set; }

    public uint Pointid { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public float? Orientation { get; set; }

    public uint Delay { get; set; }

    public string? PointComment { get; set; }
}
