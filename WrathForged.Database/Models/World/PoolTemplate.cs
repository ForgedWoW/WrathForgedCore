// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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
