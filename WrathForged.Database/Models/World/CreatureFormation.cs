// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class CreatureFormation
{
    public uint LeaderGuid { get; set; }

    public uint MemberGuid { get; set; }

    public float Dist { get; set; }

    public float Angle { get; set; }

    public uint GroupAi { get; set; }

    public ushort Point1 { get; set; }

    public ushort Point2 { get; set; }
}
