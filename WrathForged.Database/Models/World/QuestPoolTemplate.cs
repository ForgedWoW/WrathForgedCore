using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class QuestPoolTemplate
{
    public uint PoolId { get; set; }

    /// <summary>
    /// Number of indices to have active at any time
    /// </summary>
    public uint NumActive { get; set; }

    public string? Description { get; set; }
}
