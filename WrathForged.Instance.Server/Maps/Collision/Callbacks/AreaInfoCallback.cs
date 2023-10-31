// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Instance.Server.Maps.Collision.Interface;
using WrathForged.Instance.Server.Maps.Collision.Models;

namespace WrathForged.Instance.Server.Maps.Collision.Callbacks;

public class AreaInfoCallback(CollisionModelInstance[] prims) : IPointIntersect
{
    public AreaInfo AreaInfo { get; set; } = new();
    public CollisionModelInstance[] Prims { get; } = prims;

    public void PointIntersectedObject(Vector3 point, int idx)
    {
        if (Prims.Length > idx)
            Prims[idx].IntersectPoint(point, AreaInfo);
    }
}
