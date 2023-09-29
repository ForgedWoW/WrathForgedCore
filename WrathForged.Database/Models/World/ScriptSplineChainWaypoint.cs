// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class ScriptSplineChainWaypoint
{
    public uint Entry { get; set; }

    public ushort ChainId { get; set; }

    public byte SplineId { get; set; }

    public byte WpId { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

    public float Z { get; set; }
}
