using System.Collections.Generic;

namespace DotRecast.Recast
{
    public class RcRegion(int i)
    {
        public int spanCount; // Number of spans belonging to this region
        public int id = i; // ID of the region
        public int areaType; // Are type.
        public bool remap;
        public bool visited;
        public bool overlap;
        public bool connectsToBorder;
        public int ymin = 0xFFFF, ymax;
        public List<int> connections = new List<int>();
        public List<int> floors = new List<int>();
    }
}