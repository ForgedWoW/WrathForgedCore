namespace DotRecast.Detour;

public readonly struct DtConnectPoly(long refs, float tmin, float tmax)
{
    public readonly long refs = refs;
    public readonly float tmin = tmin;
    public readonly float tmax = tmax;
}