using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Addons
/// </summary>
public partial class Addon
{
    public string Name { get; set; } = null!;

    public uint Crc { get; set; }
}
