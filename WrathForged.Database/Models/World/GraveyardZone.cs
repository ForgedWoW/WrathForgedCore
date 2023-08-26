using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Trigger System
/// </summary>
public partial class GraveyardZone
{
    public uint Id { get; set; }

    public uint GhostZone { get; set; }

    public ushort Faction { get; set; }

    public string? Comment { get; set; }
}
