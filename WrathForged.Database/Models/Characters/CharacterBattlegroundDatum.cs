// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterBattlegroundDatum
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Instance Identifier
    /// </summary>
    public uint InstanceId { get; set; }

    public ushort Team { get; set; }

    public float JoinX { get; set; }

    public float JoinY { get; set; }

    public float JoinZ { get; set; }

    public float JoinO { get; set; }

    /// <summary>
    /// Map Identifier
    /// </summary>
    public ushort JoinMapId { get; set; }

    public uint TaxiStart { get; set; }

    public uint TaxiEnd { get; set; }

    public uint MountSpell { get; set; }
}
