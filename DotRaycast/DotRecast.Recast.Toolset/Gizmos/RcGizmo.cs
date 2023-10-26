using DotRecast.Detour.Dynamic.Colliders;
using DotRecast.Recast.Toolset.Gizmos;

namespace DotRecast.Recast.Toolset.Gizmos
{
    public class RcGizmo(IDtCollider collider, IRcGizmoMeshFilter gizmo)
    {
        public readonly IRcGizmoMeshFilter Gizmo = gizmo;
        public readonly IDtCollider Collider = collider;
    }
}