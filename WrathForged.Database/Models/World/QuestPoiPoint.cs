// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class QuestPoiPoint
{
    public uint QuestId { get; set; }

    public uint Idx1 { get; set; }

    public uint Idx2 { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public int? VerifiedBuild { get; set; }
}
