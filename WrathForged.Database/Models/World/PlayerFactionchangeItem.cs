using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class PlayerFactionchangeItem
{
    public uint RaceA { get; set; }

    public uint AllianceId { get; set; }

    public string? CommentA { get; set; }

    public uint RaceH { get; set; }

    public uint HordeId { get; set; }

    public string? CommentH { get; set; }
}
