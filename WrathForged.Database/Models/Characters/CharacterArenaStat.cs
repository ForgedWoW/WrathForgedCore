﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

public partial class CharacterArenaStat
{
    public uint Guid { get; set; }

    public byte Slot { get; set; }

    public ushort MatchMakerRating { get; set; }
}
