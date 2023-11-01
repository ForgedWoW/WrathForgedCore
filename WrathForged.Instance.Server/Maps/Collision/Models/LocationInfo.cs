// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Instance.Server.Maps.Collision.Models;
public class LocationInfo
{
    public float GroundZ { get; set; } = float.NegativeInfinity;
    public CollisionModelInstance? HitInstance { get; set; }
    public GroupCollisionCalculator? HitModel { get; set; }
    public uint RootId { get; set; }
}
