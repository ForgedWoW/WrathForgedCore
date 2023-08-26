using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Chat System
/// </summary>
public partial class Command
{
    public string Name { get; set; } = null!;

    public string? Help { get; set; }
}
