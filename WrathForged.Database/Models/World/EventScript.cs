﻿using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class EventScript
{
    public uint Id { get; set; }

    public uint Delay { get; set; }

    public uint Command { get; set; }

    public uint Datalong { get; set; }

    public uint Datalong2 { get; set; }

    public int Dataint { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

    public float Z { get; set; }

    public float O { get; set; }

    public string Comment { get; set; } = null!;
}
