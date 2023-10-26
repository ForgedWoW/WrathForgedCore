namespace DotRecast.Core;

/// Recast performance timer categories.
/// @see rcContext
public class RcTimerLabel
{
    /// The user defined total time of the build.
    public static readonly RcTimerLabel RC_TIMER_TOTAL = new(nameof(RC_TIMER_TOTAL));

    /// A user defined build time.
    public static readonly RcTimerLabel RC_TIMER_TEMP = new(nameof(RC_TIMER_TEMP));

    /// The time to rasterize the triangles. (See: #rcRasterizeTriangle)
    public static readonly RcTimerLabel RC_TIMER_RASTERIZE_TRIANGLES = new(nameof(RC_TIMER_RASTERIZE_TRIANGLES));
    public static readonly RcTimerLabel RC_TIMER_RASTERIZE_SPHERE = new(nameof(RC_TIMER_RASTERIZE_SPHERE));
    public static readonly RcTimerLabel RC_TIMER_RASTERIZE_CAPSULE = new(nameof(RC_TIMER_RASTERIZE_CAPSULE));
    public static readonly RcTimerLabel RC_TIMER_RASTERIZE_CYLINDER = new(nameof(RC_TIMER_RASTERIZE_CYLINDER));
    public static readonly RcTimerLabel RC_TIMER_RASTERIZE_BOX = new(nameof(RC_TIMER_RASTERIZE_BOX));
    public static readonly RcTimerLabel RC_TIMER_RASTERIZE_CONVEX = new(nameof(RC_TIMER_RASTERIZE_CONVEX));

    /// The time to build the compact heightfield. (See: #rcBuildCompactHeightfield)
    public static readonly RcTimerLabel RC_TIMER_BUILD_COMPACTHEIGHTFIELD = new(nameof(RC_TIMER_BUILD_COMPACTHEIGHTFIELD));

    /// The total time to build the contours. (See: #rcBuildContours)
    public static readonly RcTimerLabel RC_TIMER_BUILD_CONTOURS = new(nameof(RC_TIMER_BUILD_CONTOURS));

    /// The time to trace the boundaries of the contours. (See: #rcBuildContours)
    public static readonly RcTimerLabel RC_TIMER_BUILD_CONTOURS_TRACE = new(nameof(RC_TIMER_BUILD_CONTOURS_TRACE));

    public static readonly RcTimerLabel RC_TIMER_BUILD_CONTOURS_WALK = new(nameof(RC_TIMER_BUILD_CONTOURS_WALK));

    /// The time to simplify the contours. (See: #rcBuildContours)
    public static readonly RcTimerLabel RC_TIMER_BUILD_CONTOURS_SIMPLIFY = new(nameof(RC_TIMER_BUILD_CONTOURS_SIMPLIFY));

    /// The time to filter ledge spans. (See: #rcFilterLedgeSpans)
    public static readonly RcTimerLabel RC_TIMER_FILTER_BORDER = new(nameof(RC_TIMER_FILTER_BORDER));

    /// The time to filter low height spans. (See: #rcFilterWalkableLowHeightSpans)
    public static readonly RcTimerLabel RC_TIMER_FILTER_WALKABLE = new(nameof(RC_TIMER_FILTER_WALKABLE));

    /// The time to apply the median filter. (See: #rcMedianFilterWalkableArea)
    public static readonly RcTimerLabel RC_TIMER_MEDIAN_AREA = new(nameof(RC_TIMER_MEDIAN_AREA));

    /// The time to filter low obstacles. (See: #rcFilterLowHangingWalkableObstacles)
    public static readonly RcTimerLabel RC_TIMER_FILTER_LOW_OBSTACLES = new(nameof(RC_TIMER_FILTER_LOW_OBSTACLES));

    /// The time to build the polygon mesh. (See: #rcBuildPolyMesh)
    public static readonly RcTimerLabel RC_TIMER_BUILD_POLYMESH = new(nameof(RC_TIMER_BUILD_POLYMESH));

    /// The time to merge polygon meshes. (See: #rcMergePolyMeshes)
    public static readonly RcTimerLabel RC_TIMER_MERGE_POLYMESH = new(nameof(RC_TIMER_MERGE_POLYMESH));

    /// The time to erode the walkable area. (See: #rcErodeWalkableArea)
    public static readonly RcTimerLabel RC_TIMER_ERODE_AREA = new(nameof(RC_TIMER_ERODE_AREA));

    /// The time to mark a box area. (See: #rcMarkBoxArea)
    public static readonly RcTimerLabel RC_TIMER_MARK_BOX_AREA = new(nameof(RC_TIMER_MARK_BOX_AREA));

    /// The time to mark a cylinder area. (See: #rcMarkCylinderArea)
    public static readonly RcTimerLabel RC_TIMER_MARK_CYLINDER_AREA = new(nameof(RC_TIMER_MARK_CYLINDER_AREA));

    /// The time to mark a convex polygon area. (See: #rcMarkConvexPolyArea)
    public static readonly RcTimerLabel RC_TIMER_MARK_CONVEXPOLY_AREA = new(nameof(RC_TIMER_MARK_CONVEXPOLY_AREA));

    /// The total time to build the distance field. (See: #rcBuildDistanceField)
    public static readonly RcTimerLabel RC_TIMER_BUILD_DISTANCEFIELD = new(nameof(RC_TIMER_BUILD_DISTANCEFIELD));

    /// The time to build the distances of the distance field. (See: #rcBuildDistanceField)
    public static readonly RcTimerLabel RC_TIMER_BUILD_DISTANCEFIELD_DIST = new(nameof(RC_TIMER_BUILD_DISTANCEFIELD_DIST));

    /// The time to blur the distance field. (See: #rcBuildDistanceField)
    public static readonly RcTimerLabel RC_TIMER_BUILD_DISTANCEFIELD_BLUR = new(nameof(RC_TIMER_BUILD_DISTANCEFIELD_BLUR));

    /// The total time to build the regions. (See: #rcBuildRegions, #rcBuildRegionsMonotone)
    public static readonly RcTimerLabel RC_TIMER_BUILD_REGIONS = new(nameof(RC_TIMER_BUILD_REGIONS));

    /// The total time to apply the watershed algorithm. (See: #rcBuildRegions)
    public static readonly RcTimerLabel RC_TIMER_BUILD_REGIONS_WATERSHED = new(nameof(RC_TIMER_BUILD_REGIONS_WATERSHED));

    /// The time to expand regions while applying the watershed algorithm. (See: #rcBuildRegions)
    public static readonly RcTimerLabel RC_TIMER_BUILD_REGIONS_EXPAND = new(nameof(RC_TIMER_BUILD_REGIONS_EXPAND));

    /// The time to flood regions while applying the watershed algorithm. (See: #rcBuildRegions)
    public static readonly RcTimerLabel RC_TIMER_BUILD_REGIONS_FLOOD = new(nameof(RC_TIMER_BUILD_REGIONS_FLOOD));

    /// The time to filter out small regions. (See: #rcBuildRegions, #rcBuildRegionsMonotone)
    public static readonly RcTimerLabel RC_TIMER_BUILD_REGIONS_FILTER = new(nameof(RC_TIMER_BUILD_REGIONS_FILTER));

    /// The time to build heightfield layers. (See: #rcBuildHeightfieldLayers)
    public static readonly RcTimerLabel RC_TIMER_BUILD_LAYERS = new(nameof(RC_TIMER_BUILD_LAYERS));

    /// The time to build the polygon mesh detail. (See: #rcBuildPolyMeshDetail)
    public static readonly RcTimerLabel RC_TIMER_BUILD_POLYMESHDETAIL = new(nameof(RC_TIMER_BUILD_POLYMESHDETAIL));

    /// The time to merge polygon mesh details. (See: #rcMergePolyMeshDetails)
    public static readonly RcTimerLabel RC_TIMER_MERGE_POLYMESHDETAIL = new(nameof(RC_TIMER_MERGE_POLYMESHDETAIL));

    /// The maximum number of timers.  (Used for iterating timers.)
    public static readonly RcTimerLabel RC_MAX_TIMERS = new(nameof(RC_MAX_TIMERS));

    public readonly string Name;

    private RcTimerLabel(string name) => Name = name;
};