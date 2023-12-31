﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

/// <summary>
/// Creature Respawn Link System
/// </summary>
public partial class LinkedRespawn
{
    /// <summary>
    /// dependent creature
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// master creature
    /// </summary>
    public uint LinkedGuid { get; set; }

    public byte LinkType { get; set; }
}
