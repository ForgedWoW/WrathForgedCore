// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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
