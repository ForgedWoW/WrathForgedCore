using DotRecast.Core;

namespace DotRecast.Recast
{
    public class RcBuilderResult(int tileX, int tileZ, RcHeightfield solid, RcCompactHeightfield chf, RcContourSet cs, RcPolyMesh pmesh, RcPolyMeshDetail dmesh, RcTelemetry ctx)
    {
        public readonly int tileX = tileX;
        public readonly int tileZ = tileZ;
        
        private readonly RcCompactHeightfield chf = chf;
        private readonly RcContourSet cs = cs;
        private readonly RcPolyMesh pmesh = pmesh;
        private readonly RcPolyMeshDetail dmesh = dmesh;
        private readonly RcHeightfield solid = solid;
        private readonly RcTelemetry telemetry = ctx;

        public RcPolyMesh GetMesh()
        {
            return pmesh;
        }

        public RcPolyMeshDetail GetMeshDetail()
        {
            return dmesh;
        }

        public RcCompactHeightfield GetCompactHeightfield()
        {
            return chf;
        }

        public RcContourSet GetContourSet()
        {
            return cs;
        }

        public RcHeightfield GetSolidHeightfield()
        {
            return solid;
        }

        public RcTelemetry GetTelemetry()
        {
            return telemetry;
        }
    }
}