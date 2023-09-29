// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class PlayercreateinfoSpellCustom
{
    public uint Racemask { get; set; }

    public uint Classmask { get; set; }

    public uint Spell { get; set; }

    public string? Note { get; set; }
}
