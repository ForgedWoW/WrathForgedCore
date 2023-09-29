// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
