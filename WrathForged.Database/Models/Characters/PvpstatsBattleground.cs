// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

public partial class PvpstatsBattleground
{
    public ulong Id { get; set; }

    public sbyte WinnerFaction { get; set; }

    public byte BracketId { get; set; }

    public byte Type { get; set; }

    public DateTime Date { get; set; }
}
