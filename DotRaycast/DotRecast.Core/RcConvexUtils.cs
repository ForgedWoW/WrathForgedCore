/*
recast4j copyright (c) 2021 Piotr Piastucki piotr@jtilia.org
DotRecast Copyright (c) 2023 Choi Ikpil ikpil@naver.com

This software is provided 'as-is', without any express or implied
warranty.  In no event will the authors be held liable for any damages
arising from the use of this software.
Permission is granted to anyone to use this software for any purpose,
including commercial applications, and to alter it and redistribute it
freely, subject to the following restrictions:
1. The origin of this software must not be misrepresented; you must not
 claim that you wrote the original software. If you use this software
 in a product, an acknowledgment in the product documentation would be
 appreciated but is not required.
2. Altered source versions must be plainly marked as such, and must not be
 misrepresented as being the original software.
3. This notice may not be removed or altered from any source distribution.
*/

using System.Collections.Generic;
using DotRecast.Core.Numerics;

namespace DotRecast.Core;

public static class RcConvexUtils
{
    // Calculates convex hull on xz-plane of points on 'pts',
    // stores the indices of the resulting hull in 'out' and
    // returns number of points on hull.
    public static List<int> Convexhull(List<RcVec3f> pts)
    {
        var npts = pts.Count;
        List<int> @out = [];
        // Find lower-leftmost point.
        var hull = 0;
        for (var i = 1; i < npts; ++i)
        {
            if (Cmppt(pts[i], pts[hull]))
            {
                hull = i;
            }
        }

        // Gift wrap hull.
        var endpt = 0;
        do
        {
            @out.Add(hull);
            endpt = 0;
            for (var j = 1; j < npts; ++j)
            {
                var a = pts[hull];
                var b = pts[endpt];
                var c = pts[j];
                if (hull == endpt || Left(a, b, c))
                {
                    endpt = j;
                }
            }

            hull = endpt;
        } while (endpt != @out[0]);

        return @out;
    }

    // Returns true if 'a' is more lower-left than 'b'.
    private static bool Cmppt(RcVec3f a, RcVec3f b)
    {
        if (a.X < b.X)
        {
            return true;
        }

        if (a.X > b.X)
        {
            return false;
        }

        return a.Z < b.Z || a.Z > b.Z && false;
    }

    // Returns true if 'c' is left of line 'a'-'b'.
    private static bool Left(RcVec3f a, RcVec3f b, RcVec3f c)
    {
        var u1 = b.X - a.X;
        var v1 = b.Z - a.Z;
        var u2 = c.X - a.X;
        var v2 = c.Z - a.Z;
        return (u1 * v2) - (v1 * u2) < 0;
    }
}