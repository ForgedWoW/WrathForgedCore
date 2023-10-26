using DotRecast.Core.Numerics;

namespace DotRecast.Detour.Crowd;

public class DtObstacleSegment
{
    /** End points of the obstacle segment */
    public RcVec3f p = new();

    /** End points of the obstacle segment */
    public RcVec3f q = new();

    public bool touch;
}