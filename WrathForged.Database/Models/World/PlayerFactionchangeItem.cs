// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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
