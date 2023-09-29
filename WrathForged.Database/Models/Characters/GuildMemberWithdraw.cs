// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Guild Member Daily Withdraws
/// </summary>
public partial class GuildMemberWithdraw
{
    public uint Guid { get; set; }

    public uint Tab0 { get; set; }

    public uint Tab1 { get; set; }

    public uint Tab2 { get; set; }

    public uint Tab3 { get; set; }

    public uint Tab4 { get; set; }

    public uint Tab5 { get; set; }

    public uint Money { get; set; }
}
