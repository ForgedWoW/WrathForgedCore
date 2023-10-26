using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotRecast.Detour.TileCache
{
    public class DtTileCacheLayerBuildResult(int tx, int ty, List<byte[]> layers)
    {
        public readonly int tx = tx;
        public readonly int ty = ty;
        public readonly List<byte[]> layers = layers;
    }
}