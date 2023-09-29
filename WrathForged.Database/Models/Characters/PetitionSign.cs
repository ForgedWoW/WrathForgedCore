// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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
