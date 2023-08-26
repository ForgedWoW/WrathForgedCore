using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class Playercreateinfo
{
    public byte Race { get; set; }

    public byte Class { get; set; }

    public ushort Map { get; set; }

    public uint Zone { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public float Orientation { get; set; }
}
