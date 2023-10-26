using DotRecast.Core.Numerics;
using static DotRecast.Recast.Toolset.Gizmos.RcGizmoHelper;


namespace DotRecast.Recast.Toolset.Gizmos
{
    public class RcSphereGizmo(RcVec3f center, float radius) : IRcGizmoMeshFilter
    {
        public readonly float[] vertices = GenerateSphericalVertices();
        public readonly int[] triangles = GenerateSphericalTriangles();
        public readonly float radius = radius;
        public readonly RcVec3f center = center;
    }
}