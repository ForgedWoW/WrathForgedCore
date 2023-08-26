using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class GameobjectAddon
{
    public uint Guid { get; set; }

    public float ParentRotation0 { get; set; }

    public float ParentRotation1 { get; set; }

    public float ParentRotation2 { get; set; }

    public float ParentRotation3 { get; set; }

    public byte InvisibilityType { get; set; }

    public uint InvisibilityValue { get; set; }
}
