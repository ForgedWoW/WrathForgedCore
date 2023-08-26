using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Creature System (Model related info)
/// </summary>
public partial class CreatureModelInfo
{
    public uint DisplayId { get; set; }

    public float BoundingRadius { get; set; }

    public float CombatReach { get; set; }

    public byte Gender { get; set; }

    public uint DisplayIdOtherGender { get; set; }
}
