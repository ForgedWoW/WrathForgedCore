// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class QuestOfferRewardLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? RewardText { get; set; }

    public int? VerifiedBuild { get; set; }
}
