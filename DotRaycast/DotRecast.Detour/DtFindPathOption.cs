namespace DotRecast.Detour;

public readonly struct DtFindPathOption(IDtQueryHeuristic heuristic, int options, float raycastLimit)
{
    public static readonly DtFindPathOption NoOption = new(DtDefaultQueryHeuristic.Default, 0, 0);

    public static readonly DtFindPathOption AnyAngle = new(DtDefaultQueryHeuristic.Default, DtFindPathOptions.DT_FINDPATH_ANY_ANGLE, float.MaxValue);
    public static readonly DtFindPathOption ZeroScale = new(new DtDefaultQueryHeuristic(0.0f), 0, 0);

    public readonly IDtQueryHeuristic heuristic = heuristic;
    public readonly int options = options;
    public readonly float raycastLimit = raycastLimit;

    public DtFindPathOption(int options, float raycastLimit)
        : this(DtDefaultQueryHeuristic.Default, options, raycastLimit)
    {
    }
}