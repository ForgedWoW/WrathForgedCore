using DotRecast.Core.Numerics;

namespace DotRecast.Detour;

public readonly struct DtPolyPoint(long polyRefs, RcVec3f polyPt)
{
    public readonly long refs = polyRefs;
    public readonly RcVec3f pt = polyPt;
}