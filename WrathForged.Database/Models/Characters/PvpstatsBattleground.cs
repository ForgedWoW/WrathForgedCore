using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class PvpstatsBattleground
{
    public ulong Id { get; set; }

    public sbyte WinnerFaction { get; set; }

    public byte BracketId { get; set; }

    public byte Type { get; set; }

    public DateTime Date { get; set; }
}
