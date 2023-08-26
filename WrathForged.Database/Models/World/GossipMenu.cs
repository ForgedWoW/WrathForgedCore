using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class GossipMenu
{
    public ushort MenuId { get; set; }

    public uint TextId { get; set; }

    public int VerifiedBuild { get; set; }
}
