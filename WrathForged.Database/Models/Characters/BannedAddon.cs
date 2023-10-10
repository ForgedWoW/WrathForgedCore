﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

public partial class BannedAddon
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public string Version { get; set; } = null!;

    public DateTime Timestamp { get; set; }
}
