using System;
using System.Collections.Generic;

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
