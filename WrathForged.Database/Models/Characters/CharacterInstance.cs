// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class CharacterInstance
{
    public uint Guid { get; set; }

    public uint Instance { get; set; }

    public byte Permanent { get; set; }

    public byte ExtendState { get; set; }
}
