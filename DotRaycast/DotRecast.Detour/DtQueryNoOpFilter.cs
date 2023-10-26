using DotRecast.Core.Numerics;

namespace DotRecast.Detour;

public class DtQueryNoOpFilter : IDtQueryFilter
{
    public static readonly DtQueryNoOpFilter Shared = new();

    private DtQueryNoOpFilter()
    {
    }

    public bool PassFilter(long refs, DtMeshTile tile, DtPoly poly) => true;

    public float GetCost(RcVec3f pa, RcVec3f pb, long prevRef, DtMeshTile prevTile, DtPoly prevPoly, long curRef,
        DtMeshTile curTile, DtPoly curPoly, long nextRef, DtMeshTile nextTile, DtPoly nextPoly) => 0;
}