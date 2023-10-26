using DotRecast.Core.Numerics;

namespace DotRecast.Detour.Crowd;

/// < Max number of adaptive rings.
public class DtObstacleCircle
{
    /** Position of the obstacle */
    public RcVec3f p = new();

    /** Velocity of the obstacle */
    public RcVec3f vel = new();

    /** Velocity of the obstacle */
    public RcVec3f dvel = new();

    /** Radius of the obstacle */
    public float rad;

    /** Use for side selection during sampling. */
    public RcVec3f dp = new();

    /** Use for side selection during sampling. */
    public RcVec3f np = new();
}