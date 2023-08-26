using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Version Notes
/// </summary>
public partial class Version
{
    /// <summary>
    /// Core revision dumped at startup.
    /// </summary>
    public string CoreVersion { get; set; } = null!;

    public string? CoreRevision { get; set; }

    /// <summary>
    /// Version of world DB.
    /// </summary>
    public string? DbVersion { get; set; }

    public int? CacheId { get; set; }
}
