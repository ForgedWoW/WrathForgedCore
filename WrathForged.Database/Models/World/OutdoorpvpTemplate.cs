// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// OutdoorPvP Templates
/// </summary>
public partial class OutdoorpvpTemplate
{
    public byte TypeId { get; set; }

    public string ScriptName { get; set; } = null!;

    public string? Comment { get; set; }
}
