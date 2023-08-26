using System;
using System.Collections.Generic;

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
