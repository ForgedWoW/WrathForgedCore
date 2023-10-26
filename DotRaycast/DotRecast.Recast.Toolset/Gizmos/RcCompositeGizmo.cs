namespace DotRecast.Recast.Toolset.Gizmos
{
    public class RcCompositeGizmo(params IRcGizmoMeshFilter[] gizmoMeshes) : IRcGizmoMeshFilter
    {
        public readonly IRcGizmoMeshFilter[] gizmoMeshes = gizmoMeshes;
    }
}