using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Guild System
/// </summary>
public partial class PetitionSign
{
    public uint Ownerguid { get; set; }

    public uint Petitionguid { get; set; }

    public uint Playerguid { get; set; }

    public uint PlayerAccount { get; set; }

    public byte Type { get; set; }
}
