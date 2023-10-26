using System.Collections.Generic;

namespace DotRecast.Recast
{
    public class RcLayerRegion(int i)
    {
        public int id = i;
        public int layerId = 0xff;
        public bool @base;
        public int ymin = 0xFFFF, ymax;
        public List<int> layers = new List<int>();
        public List<int> neis = new List<int>();
    };
}