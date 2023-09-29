// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
