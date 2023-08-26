using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class ScriptSplineChainMetum
{
    public uint Entry { get; set; }

    public ushort ChainId { get; set; }

    public byte SplineId { get; set; }

    public uint ExpectedDuration { get; set; }

    public uint MsUntilNext { get; set; }

    public float? Velocity { get; set; }
}
