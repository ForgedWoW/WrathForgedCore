using DotRecast.Core.Numerics;

namespace DotRecast.Detour;

public class DtQueryEmptyFilter : IDtQueryFilter
{
    public static readonly DtQueryEmptyFilter Shared = new();

    private DtQueryEmptyFilter()
    {
    }

    public bool PassFilter(long refs, DtMeshTile tile, DtPoly poly) => false;

    public float GetCost(RcVec3f pa, RcVec3f pb, long prevRef, DtMeshTile prevTile, DtPoly prevPoly, long curRef,
        DtMeshTile curTile, DtPoly curPoly, long nextRef, DtMeshTile nextTile, DtPoly nextPoly) => 0;
}