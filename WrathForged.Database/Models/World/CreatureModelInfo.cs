// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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
