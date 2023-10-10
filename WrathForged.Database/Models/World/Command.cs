// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

/// <summary>
/// Chat System
/// </summary>
public partial class Command
{
    public string Name { get; set; } = null!;

    public string? Help { get; set; }
}
