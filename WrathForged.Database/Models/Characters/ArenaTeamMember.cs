// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class ArenaTeamMember
{
    public uint ArenaTeamId { get; set; }

    public uint Guid { get; set; }

    public ushort WeekGames { get; set; }

    public ushort WeekWins { get; set; }

    public ushort SeasonGames { get; set; }

    public ushort SeasonWins { get; set; }

    public ushort PersonalRating { get; set; }
}
