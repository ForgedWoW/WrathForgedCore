﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class CreatureSummonGroup
{
    public uint SummonerId { get; set; }

    public byte SummonerType { get; set; }

    public byte GroupId { get; set; }

    public uint Entry { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public float Orientation { get; set; }

    public byte SummonType { get; set; }

    public uint SummonTime { get; set; }

    public string Comment { get; set; } = null!;
}
