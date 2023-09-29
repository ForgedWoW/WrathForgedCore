// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
