namespace DotRecast.Detour;

public readonly struct DtSegInterval(long refs, int tmin, int tmax)
{
    public readonly long refs = refs;
    public readonly int tmin = tmin;
    public readonly int tmax = tmax;
}