// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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
