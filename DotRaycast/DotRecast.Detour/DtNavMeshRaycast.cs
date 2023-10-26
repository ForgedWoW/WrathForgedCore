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

using DotRecast.Core;
using DotRecast.Core.Numerics;

namespace DotRecast.Detour;

/**
* Simple helper to find an intersection between a ray and a nav mesh
*/
public static class DtNavMeshRaycast
{
    public static bool Raycast(DtNavMesh mesh, RcVec3f src, RcVec3f dst, out float hitTime)
    {
        hitTime = 0.0f;
        for (var t = 0; t < mesh.GetMaxTiles(); ++t)
        {
            var tile = mesh.GetTile(t);
            if (tile != null && tile.data != null)
            {
                if (Raycast(tile, src, dst, out hitTime))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private static bool Raycast(DtMeshTile tile, RcVec3f sp, RcVec3f sq, out float hitTime)
    {
        hitTime = 0.0f;
        for (var i = 0; i < tile.data.Header.polyCount; ++i)
        {
            var p = tile.data.Polys[i];
            if (p.GetPolyType() == DtPolyTypes.DT_POLYTYPE_OFFMESH_CONNECTION)
            {
                continue;
            }

            var pd = tile.data.DetailMeshes[i];

            if (pd != null)
            {
                var verts = new RcVec3f[3];
                for (var j = 0; j < pd.triCount; ++j)
                {
                    var t = (pd.triBase + j) * 4;
                    for (var k = 0; k < 3; ++k)
                    {
                        var v = tile.data.DetailTris[t + k];
                        if (v < p.vertCount)
                        {
                            verts[k].X = tile.data.Verts[p.verts[v] * 3];
                            verts[k].Y = tile.data.Verts[(p.verts[v] * 3) + 1];
                            verts[k].Z = tile.data.Verts[(p.verts[v] * 3) + 2];
                        }
                        else
                        {
                            verts[k].X = tile.data.DetailVerts[(pd.vertBase + v - p.vertCount) * 3];
                            verts[k].Y = tile.data.DetailVerts[((pd.vertBase + v - p.vertCount) * 3) + 1];
                            verts[k].Z = tile.data.DetailVerts[((pd.vertBase + v - p.vertCount) * 3) + 2];
                        }
                    }

                    if (RcIntersections.IntersectSegmentTriangle(sp, sq, verts[0], verts[1], verts[2], out hitTime))
                    {
                        return true;
                    }
                }
            }
            else
            {
                // FIXME: Use Poly if PolyDetail is unavailable
            }
        }

        return false;
    }
}