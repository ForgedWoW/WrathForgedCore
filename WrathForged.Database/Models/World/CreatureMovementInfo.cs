using System;
using System.Collections.Generic;

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
