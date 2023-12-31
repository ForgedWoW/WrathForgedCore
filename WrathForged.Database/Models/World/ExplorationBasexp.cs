﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

/// <summary>
/// Exploration System
/// </summary>
public partial class ExplorationBasexp
{
    public byte Level { get; set; }

    public int Basexp { get; set; }
}
