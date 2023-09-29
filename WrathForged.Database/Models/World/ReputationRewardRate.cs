// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class ReputationRewardRate
{
    public uint Faction { get; set; }

    public float QuestRate { get; set; }

    public float QuestDailyRate { get; set; }

    public float QuestWeeklyRate { get; set; }

    public float QuestMonthlyRate { get; set; }

    public float QuestRepeatableRate { get; set; }

    public float CreatureRate { get; set; }

    public float SpellRate { get; set; }
}
