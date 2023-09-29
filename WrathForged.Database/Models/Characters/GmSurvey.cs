// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class GmSurvey
{
    public uint SurveyId { get; set; }

    public uint Guid { get; set; }

    public uint MainSurvey { get; set; }

    public string Comment { get; set; } = null!;

    public uint CreateTime { get; set; }
}
