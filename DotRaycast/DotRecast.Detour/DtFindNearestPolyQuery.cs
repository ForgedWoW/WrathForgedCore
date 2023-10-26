using System;
using DotRecast.Core.Numerics;

namespace DotRecast.Detour;

public class DtFindNearestPolyQuery(DtNavMeshQuery query, RcVec3f center) : IDtPolyQuery
{
    private readonly DtNavMeshQuery _query = query;
    private readonly RcVec3f _center = center;
    private long _nearestRef;
    private RcVec3f _nearestPt = center;
    private bool _overPoly;
    private float _nearestDistanceSqr = float.MaxValue;

    public void Process(DtMeshTile tile, DtPoly poly, long refs)
    {
        // Find nearest polygon amongst the nearby polygons.
        _ = _query.ClosestPointOnPoly(refs, _center, out var closestPtPoly, out var posOverPoly);

        var diff = RcVec3f.Subtract(_center, closestPtPoly);

        // If a point is directly over a polygon and closer than
        // climb height, favor that instead of straight line nearest point.
        float d;
        if (posOverPoly)
        {
            d = MathF.Abs(diff.Y) - tile.data.Header.walkableClimb;
            d = d > 0 ? d * d : 0;
        }
        else
        {
            d = diff.LengthSquared();
        }

        if (d < _nearestDistanceSqr)
        {
            _nearestPt = closestPtPoly;
            _nearestDistanceSqr = d;
            _nearestRef = refs;
            _overPoly = posOverPoly;
        }
    }

    public long NearestRef() => _nearestRef;

    public RcVec3f NearestPt() => _nearestPt;

    public bool OverPoly() => _overPoly;
}