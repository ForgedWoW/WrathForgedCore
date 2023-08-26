using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class PointsOfInterest
{
    public uint Id { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public uint Icon { get; set; }

    public uint Flags { get; set; }

    public uint Importance { get; set; }

    public string Name { get; set; } = null!;

    public int? VerifiedBuild { get; set; }
}
