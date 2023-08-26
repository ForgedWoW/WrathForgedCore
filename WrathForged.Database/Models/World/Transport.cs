using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Transports
/// </summary>
public partial class Transport
{
    public uint Guid { get; set; }

    public uint Entry { get; set; }

    public string? Name { get; set; }

    public string ScriptName { get; set; } = null!;
}
