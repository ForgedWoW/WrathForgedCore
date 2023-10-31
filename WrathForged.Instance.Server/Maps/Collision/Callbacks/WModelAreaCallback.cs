// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Instance.Server.Maps.Collision.Interface;

namespace WrathForged.Instance.Server.Maps.Collision.Callbacks;
public class WModelAreaCallback(List<GroupCollisionCalculator> vals, Vector3 down) : IPointIntersect
{
    public GroupCollisionCalculator? Hit { get; set; }
    public float ZDist { get; set; } = float.PositiveInfinity;

    private readonly List<GroupCollisionCalculator> _prims = vals;
    private readonly Vector3 _zVec = down;

    public void PointIntersectedObject(Vector3 point, int entry)
    {
        if (!_prims[entry].IsInsideObject(point, _zVec, out var groupZ))
            return;

        if (!(groupZ < ZDist))
            return;

        ZDist = groupZ;
        Hit = _prims[entry];
    }
}