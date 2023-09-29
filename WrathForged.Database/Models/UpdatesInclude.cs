// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models;

/// <summary>
/// List of directories where we want to include sql updates.
/// </summary>
public partial class UpdatesInclude
{
    /// <summary>
    /// directory to include. $ means relative to the source directory.
    /// </summary>
    public string Path { get; set; } = null!;

    /// <summary>
    /// defines if the directory contains released or archived updates.
    /// </summary>
    public string State { get; set; } = null!;
}
