using System.Collections.Generic;

namespace DotRecast.Detour;

public class BVItemYComparer : IComparer<BVItem>
{
    public static readonly BVItemYComparer Shared = new();

    private BVItemYComparer()
    {
    }

    public int Compare(BVItem a, BVItem b) => a.bmin[1].CompareTo(b.bmin[1]);
}