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

using System;
using DotRecast.Core.Numerics;
using DotRecast.Recast;

namespace DotRecast.Detour.Dynamic;

/**
* Voxel raycast based on the algorithm described in
*
* "A Fast Voxel Traversal Algorithm for Ray Tracing" by John Amanatides and Andrew Woo
*/
public class DtVoxelQuery(RcVec3f origin, float tileWidth, float tileDepth, Func<int, int, RcHeightfield> heightfieldProvider)
{
    private readonly RcVec3f origin = origin;
    private readonly float tileWidth = tileWidth;
    private readonly float tileDepth = tileDepth;
    private readonly Func<int, int, RcHeightfield> heightfieldProvider = heightfieldProvider;

    /**
 * Perform raycast using voxels heightfields.
 *
 * @return Optional with hit parameter (t) or empty if no hit found
 */
    public bool Raycast(RcVec3f start, RcVec3f end, out float hit) => TraverseTiles(start, end, out hit);

    private bool TraverseTiles(RcVec3f start, RcVec3f end, out float hit)
    {
        var relStartX = start.X - origin.X;
        var relStartZ = start.Z - origin.Z;
        var sx = (int)MathF.Floor(relStartX / tileWidth);
        var sz = (int)MathF.Floor(relStartZ / tileDepth);
        var ex = (int)MathF.Floor((end.X - origin.X) / tileWidth);
        var ez = (int)MathF.Floor((end.Z - origin.Z) / tileDepth);
        var dx = ex - sx;
        var dz = ez - sz;
        var stepX = dx < 0 ? -1 : 1;
        var stepZ = dz < 0 ? -1 : 1;
        var xRem = (tileWidth + (relStartX % tileWidth)) % tileWidth;
        var zRem = (tileDepth + (relStartZ % tileDepth)) % tileDepth;
        var tx = end.X - start.X;
        var tz = end.Z - start.Z;
        var xOffest = MathF.Abs(tx < 0 ? xRem : tileWidth - xRem);
        var zOffest = MathF.Abs(tz < 0 ? zRem : tileDepth - zRem);
        tx = MathF.Abs(tx);
        tz = MathF.Abs(tz);
        var tMaxX = xOffest / tx;
        var tMaxZ = zOffest / tz;
        var tDeltaX = tileWidth / tx;
        var tDeltaZ = tileDepth / tz;
        float t = 0;
        while (true)
        {
            var isHit = TraversHeightfield(sx, sz, start, end, t, Math.Min(1, Math.Min(tMaxX, tMaxZ)), out hit);
            if (isHit)
            {
                return true;
            }

            if ((dx > 0 ? sx >= ex : sx <= ex) && (dz > 0 ? sz >= ez : sz <= ez))
            {
                break;
            }

            if (tMaxX < tMaxZ)
            {
                t = tMaxX;
                tMaxX += tDeltaX;
                sx += stepX;
            }
            else
            {
                t = tMaxZ;
                tMaxZ += tDeltaZ;
                sz += stepZ;
            }
        }

        return false;
    }

    private bool TraversHeightfield(int x, int z, RcVec3f start, RcVec3f end, float tMin, float tMax, out float hit)
    {
        var hf = heightfieldProvider.Invoke(x, z);
        if (null != hf)
        {
            var tx = end.X - start.X;
            var ty = end.Y - start.Y;
            var tz = end.Z - start.Z;
            float[] entry = { start.X + (tMin * tx), start.Y + (tMin * ty), start.Z + (tMin * tz) };
            float[] exit = { start.X + (tMax * tx), start.Y + (tMax * ty), start.Z + (tMax * tz) };
            var relStartX = entry[0] - hf.bmin.X;
            var relStartZ = entry[2] - hf.bmin.Z;
            var sx = (int)MathF.Floor(relStartX / hf.cs);
            var sz = (int)MathF.Floor(relStartZ / hf.cs);
            var ex = (int)MathF.Floor((exit[0] - hf.bmin.X) / hf.cs);
            var ez = (int)MathF.Floor((exit[2] - hf.bmin.Z) / hf.cs);
            var dx = ex - sx;
            var dz = ez - sz;
            var stepX = dx < 0 ? -1 : 1;
            var stepZ = dz < 0 ? -1 : 1;
            var xRem = (hf.cs + (relStartX % hf.cs)) % hf.cs;
            var zRem = (hf.cs + (relStartZ % hf.cs)) % hf.cs;
            var xOffest = MathF.Abs(tx < 0 ? xRem : hf.cs - xRem);
            var zOffest = MathF.Abs(tz < 0 ? zRem : hf.cs - zRem);
            tx = MathF.Abs(tx);
            tz = MathF.Abs(tz);
            var tMaxX = xOffest / tx;
            var tMaxZ = zOffest / tz;
            var tDeltaX = hf.cs / tx;
            var tDeltaZ = hf.cs / tz;
            float t = 0;
            while (true)
            {
                if (sx >= 0 && sx < hf.width && sz >= 0 && sz < hf.height)
                {
                    var y1 = start.Y + (ty * (tMin + t)) - hf.bmin.Y;
                    var y2 = start.Y + (ty * (tMin + Math.Min(tMaxX, tMaxZ))) - hf.bmin.Y;
                    var ymin = Math.Min(y1, y2) / hf.ch;
                    var ymax = Math.Max(y1, y2) / hf.ch;
                    var span = hf.spans[sx + (sz * hf.width)];
                    while (span != null)
                    {
                        if (span.smin <= ymin && span.smax >= ymax)
                        {
                            hit = Math.Min(1, tMin + t);
                            return true;
                        }

                        span = span.next;
                    }
                }

                if ((dx > 0 ? sx >= ex : sx <= ex) && (dz > 0 ? sz >= ez : sz <= ez))
                {
                    break;
                }

                if (tMaxX < tMaxZ)
                {
                    t = tMaxX;
                    tMaxX += tDeltaX;
                    sx += stepX;
                }
                else
                {
                    t = tMaxZ;
                    tMaxZ += tDeltaZ;
                    sz += stepZ;
                }
            }
        }

        hit = 0.0f;
        return false;
    }
}