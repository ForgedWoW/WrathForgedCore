// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
