using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class LfgDungeonTemplate
{
    /// <summary>
    /// Unique id from LFGDungeons.dbc
    /// </summary>
    public uint DungeonId { get; set; }

    public string? Name { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public float Orientation { get; set; }

    public int? VerifiedBuild { get; set; }
}
