// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class QuestDetail
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

    public int VerifiedBuild { get; set; }
}
