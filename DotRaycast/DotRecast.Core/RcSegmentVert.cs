using DotRecast.Core.Numerics;

namespace DotRecast.Core;

public struct RcSegmentVert
{
    public RcVec3f Vmin;
    public RcVec3f Vmax;

    public RcSegmentVert(float v0, float v1, float v2, float v3, float v4, float v5)
    {
        Vmin.X = v0;
        Vmin.Y = v1;
        Vmin.Z = v2;

        Vmax.X = v3;
        Vmax.Y = v4;
        Vmax.Z = v5;
    }
}