﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models;

/// <summary>
/// List of all applied updates in this database.
/// </summary>
public partial class Update
{
    /// <summary>
    /// filename with extension of the update.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// sha1 hash of the sql file.
    /// </summary>
    public string? Hash { get; set; }

    /// <summary>
    /// defines if an update is released or archived.
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// timestamp when the query was applied.
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// time the query takes to apply in ms.
    /// </summary>
    public uint Speed { get; set; }
}
