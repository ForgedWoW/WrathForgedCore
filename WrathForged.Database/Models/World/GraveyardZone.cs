// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
