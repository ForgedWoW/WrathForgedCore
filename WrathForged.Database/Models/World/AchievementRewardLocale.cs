using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class AchievementRewardLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? Subject { get; set; }

    public string? Body { get; set; }
}
