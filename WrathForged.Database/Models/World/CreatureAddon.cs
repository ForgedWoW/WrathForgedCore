using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class CreatureAddon
{
    public uint Guid { get; set; }

    public uint PathId { get; set; }

    public uint Mount { get; set; }

    public uint MountCreatureId { get; set; }

    public byte StandState { get; set; }

    public byte AnimTier { get; set; }

    public byte VisFlags { get; set; }

    public byte SheathState { get; set; }

    public byte PvPflags { get; set; }

    public uint Emote { get; set; }

    public byte VisibilityDistanceType { get; set; }

    public string? Auras { get; set; }
}
