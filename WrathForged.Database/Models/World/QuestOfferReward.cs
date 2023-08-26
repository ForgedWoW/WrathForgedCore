﻿using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class QuestOfferReward
{
    public uint Id { get; set; }

    public ushort Emote1 { get; set; }

    public ushort Emote2 { get; set; }

    public ushort Emote3 { get; set; }

    public ushort Emote4 { get; set; }

    public uint EmoteDelay1 { get; set; }

    public uint EmoteDelay2 { get; set; }

    public uint EmoteDelay3 { get; set; }

    public uint EmoteDelay4 { get; set; }

    public string? RewardText { get; set; }

    public int VerifiedBuild { get; set; }
}
