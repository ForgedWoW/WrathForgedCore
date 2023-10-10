﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

public partial class ArenaTeam
{
    public uint ArenaTeamId { get; set; }

    public string Name { get; set; } = null!;

    public uint CaptainGuid { get; set; }

    public byte Type { get; set; }

    public ushort Rating { get; set; }

    public ushort SeasonGames { get; set; }

    public ushort SeasonWins { get; set; }

    public ushort WeekGames { get; set; }

    public ushort WeekWins { get; set; }

    public uint Rank { get; set; }

    public uint BackgroundColor { get; set; }

    public byte EmblemStyle { get; set; }

    public uint EmblemColor { get; set; }

    public byte BorderStyle { get; set; }

    public uint BorderColor { get; set; }
}
