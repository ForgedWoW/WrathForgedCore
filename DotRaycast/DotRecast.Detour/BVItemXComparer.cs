using System.Collections.Generic;

namespace DotRecast.Detour;

public class BVItemXComparer : IComparer<BVItem>
{
    public static readonly BVItemXComparer Shared = new();

    private BVItemXComparer()
    {
    }

    public int Compare(BVItem a, BVItem b) => a.bmin[0].CompareTo(b.bmin[0]);
}