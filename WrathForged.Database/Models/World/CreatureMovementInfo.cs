// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class CreatureMovementInfo
{
    /// <summary>
    /// creature_template.movementId value
    /// </summary>
    public uint MovementId { get; set; }

    public float? WalkSpeed { get; set; }

    public float? RunSpeed { get; set; }
}
