﻿using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class QuestOfferRewardLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? RewardText { get; set; }

    public int? VerifiedBuild { get; set; }
}
