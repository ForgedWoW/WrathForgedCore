// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

/// <summary>
/// Fishing system
/// </summary>
public partial class SkillFishingBaseLevel
{
    /// <summary>
    /// Area identifier
    /// </summary>
    public uint Entry { get; set; }

    /// <summary>
    /// Base skill level requirement
    /// </summary>
    public short Skill { get; set; }
}
