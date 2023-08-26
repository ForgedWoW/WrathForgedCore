using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Achievment system
/// </summary>
public partial class AchievementCriteriaDatum
{
    public int CriteriaId { get; set; }

    public byte Type { get; set; }

    public uint Value1 { get; set; }

    public uint Value2 { get; set; }

    public string ScriptName { get; set; } = null!;
}
