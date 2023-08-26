using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

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
