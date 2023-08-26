using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Guild System
/// </summary>
public partial class Petition
{
    public uint Ownerguid { get; set; }

    public uint? Petitionguid { get; set; }

    public string Name { get; set; } = null!;

    public byte Type { get; set; }
}
