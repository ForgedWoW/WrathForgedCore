using System;

namespace DotRecast.Detour.Extras.Jumplink
{
    public class PolyQueryInvoker(Action<DtMeshTile, DtPoly, long> callback) : IDtPolyQuery
    {
        public readonly Action<DtMeshTile, DtPoly, long> _callback = callback;

        public void Process(DtMeshTile tile, DtPoly poly, long refs)
        {
            _callback?.Invoke(tile, poly, refs);
        }
    }
}