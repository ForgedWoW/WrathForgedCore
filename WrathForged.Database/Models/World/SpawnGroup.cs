using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class SpawnGroup
{
    public uint GroupId { get; set; }

    public byte SpawnType { get; set; }

    public uint SpawnId { get; set; }
}
