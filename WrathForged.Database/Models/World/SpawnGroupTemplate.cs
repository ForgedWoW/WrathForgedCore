using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class SpawnGroupTemplate
{
    public uint GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public uint GroupFlags { get; set; }
}
