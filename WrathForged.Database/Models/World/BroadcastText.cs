﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class BroadcastText
{
    public uint Id { get; set; }

    public uint LanguageId { get; set; }

    public string? Text { get; set; }

    public string? Text1 { get; set; }

    public uint EmoteId1 { get; set; }

    public uint EmoteId2 { get; set; }

    public uint EmoteId3 { get; set; }

    public uint EmoteDelay1 { get; set; }

    public uint EmoteDelay2 { get; set; }

    public uint EmoteDelay3 { get; set; }

    public uint SoundEntriesId { get; set; }

    public uint EmotesId { get; set; }

    public uint Flags { get; set; }

    public int VerifiedBuild { get; set; }
}
