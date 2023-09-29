// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Channel System
/// </summary>
public partial class Channel
{
    public string Name { get; set; } = null!;

    public uint Team { get; set; }

    public byte Announce { get; set; }

    public byte Ownership { get; set; }

    public string? Password { get; set; }

    public string? BannedList { get; set; }

    public uint LastUsed { get; set; }
}
