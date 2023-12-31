﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

/// <summary>
/// Stores levels stats.
/// </summary>
public partial class PlayerClasslevelstat
{
    public byte Class { get; set; }

    public byte Level { get; set; }

    public ushort Basehp { get; set; }

    public ushort Basemana { get; set; }
}
