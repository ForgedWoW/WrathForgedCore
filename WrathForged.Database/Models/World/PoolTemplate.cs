using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class PoolTemplate
{
    /// <summary>
    /// Pool entry
    /// </summary>
    public uint Entry { get; set; }

    /// <summary>
    /// Max number of objects (0) is no limit
    /// </summary>
    public uint MaxLimit { get; set; }

    public string? Description { get; set; }
}
