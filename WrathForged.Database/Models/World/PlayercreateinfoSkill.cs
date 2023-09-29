// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class PlayercreateinfoSkill
{
    public uint RaceMask { get; set; }

    public uint ClassMask { get; set; }

    public ushort Skill { get; set; }

    public ushort Rank { get; set; }

    public string? Comment { get; set; }
}
