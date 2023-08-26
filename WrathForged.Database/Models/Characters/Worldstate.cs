using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Variable Saves
/// </summary>
public partial class Worldstate
{
    public uint Entry { get; set; }

    public uint Value { get; set; }

    public string? Comment { get; set; }
}
