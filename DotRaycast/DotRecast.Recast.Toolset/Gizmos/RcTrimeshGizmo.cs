namespace DotRecast.Recast.Toolset.Gizmos
{
    public class RcTrimeshGizmo(float[] vertices, int[] triangles) : IRcGizmoMeshFilter
    {
        public readonly float[] vertices = vertices;
        public readonly int[] triangles = triangles;
    }
}