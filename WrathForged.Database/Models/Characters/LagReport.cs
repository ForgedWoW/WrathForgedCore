using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class LagReport
{
    public uint ReportId { get; set; }

    public uint Guid { get; set; }

    public byte LagType { get; set; }

    public ushort MapId { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public uint Latency { get; set; }

    public uint CreateTime { get; set; }
}
