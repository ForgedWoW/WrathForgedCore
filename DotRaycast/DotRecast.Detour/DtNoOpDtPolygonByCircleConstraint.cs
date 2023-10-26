using DotRecast.Core.Numerics;

namespace DotRecast.Detour;

public class DtNoOpDtPolygonByCircleConstraint : IDtPolygonByCircleConstraint
{
    public static readonly DtNoOpDtPolygonByCircleConstraint Shared = new();

    private DtNoOpDtPolygonByCircleConstraint()
    {
    }

    public float[] Apply(float[] polyVerts, RcVec3f circleCenter, float radius) => polyVerts;
}