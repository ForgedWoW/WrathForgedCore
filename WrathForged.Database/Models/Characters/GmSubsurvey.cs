// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class GmSubsurvey
{
    public uint SurveyId { get; set; }

    public uint QuestionId { get; set; }

    public uint Answer { get; set; }

    public string AnswerComment { get; set; } = null!;
}
