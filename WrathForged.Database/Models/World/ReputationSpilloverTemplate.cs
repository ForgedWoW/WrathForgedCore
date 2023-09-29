// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Reputation spillover reputation gain
/// </summary>
public partial class ReputationSpilloverTemplate
{
    /// <summary>
    /// faction entry
    /// </summary>
    public ushort Faction { get; set; }

    /// <summary>
    /// faction to give spillover for
    /// </summary>
    public ushort Faction1 { get; set; }

    /// <summary>
    /// the given rep points * rate
    /// </summary>
    public float Rate1 { get; set; }

    /// <summary>
    /// max rank,above this will not give any spillover
    /// </summary>
    public byte Rank1 { get; set; }

    public ushort Faction2 { get; set; }

    public float Rate2 { get; set; }

    public byte Rank2 { get; set; }

    public ushort Faction3 { get; set; }

    public float Rate3 { get; set; }

    public byte Rank3 { get; set; }

    public ushort Faction4 { get; set; }

    public float Rate4 { get; set; }

    public byte Rank4 { get; set; }
}
