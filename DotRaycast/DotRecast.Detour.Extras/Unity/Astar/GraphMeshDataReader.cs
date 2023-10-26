/*
recast4j copyright (c) 2015-2019 Piotr Piastucki piotr@jtilia.org

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
using System.IO.Compression;

namespace DotRecast.Detour.Extras.Unity.Astar;

public class GraphMeshDataReader : ZipBinaryReader
{
    public const float INT_PRECISION_FACTOR = 1000f;

    public GraphMeshData Read(ZipArchive file, string filename, GraphMeta meta, int maxVertPerPoly)
    {
        var buffer = ToByteBuffer(file, filename);
        var tileXCount = buffer.GetInt();
        if (tileXCount < 0)
        {
            return null;
        }

        var tileZCount = buffer.GetInt();
        var tiles = new DtMeshData[tileXCount * tileZCount];
        for (var z = 0; z < tileZCount; z++)
        {
            for (var x = 0; x < tileXCount; x++)
            {
                var tileIndex = x + (z * tileXCount);
                var tx = buffer.GetInt();
                var tz = buffer.GetInt();
                if (tx != x || tz != z)
                {
                    throw new ArgumentException("Inconsistent tile positions");
                }

                tiles[tileIndex] = new DtMeshData();

                _ = buffer.GetInt();

                _ = buffer.GetInt();

                var trisCount = buffer.GetInt();
                var tris = new int[trisCount];
                for (var i = 0; i < tris.Length; i++)
                {
                    tris[i] = buffer.GetInt();
                }

                var vertsCount = buffer.GetInt();
                var verts = new float[3 * vertsCount];
                for (var i = 0; i < verts.Length; i++)
                {
                    verts[i] = buffer.GetInt() / INT_PRECISION_FACTOR;
                }

                var vertsInGraphSpace = new int[3 * buffer.GetInt()];
                for (var i = 0; i < vertsInGraphSpace.Length; i++)
                {
                    vertsInGraphSpace[i] = buffer.GetInt();
                }

                var nodeCount = buffer.GetInt();
                var nodes = new DtPoly[nodeCount];
                var detailNodes = new DtPolyDetail[nodeCount];
                var detailVerts = new float[0];
                var detailTris = new int[4 * nodeCount];
                var vertMask = GetVertMask(vertsCount);
                var ymin = float.PositiveInfinity;
                var ymax = float.NegativeInfinity;
                for (var i = 0; i < nodes.Length; i++)
                {
                    nodes[i] = new DtPoly(i, maxVertPerPoly)
                    {
                        vertCount = 3
                    };

                    // XXX: What can we do with the penalty?
                    _ = buffer.GetInt();
                    nodes[i].flags = buffer.GetInt();
                    nodes[i].verts[0] = buffer.GetInt() & vertMask;
                    nodes[i].verts[1] = buffer.GetInt() & vertMask;
                    nodes[i].verts[2] = buffer.GetInt() & vertMask;
                    ymin = Math.Min(ymin, verts[(nodes[i].verts[0] * 3) + 1]);
                    ymin = Math.Min(ymin, verts[(nodes[i].verts[1] * 3) + 1]);
                    ymin = Math.Min(ymin, verts[(nodes[i].verts[2] * 3) + 1]);
                    ymax = Math.Max(ymax, verts[(nodes[i].verts[0] * 3) + 1]);
                    ymax = Math.Max(ymax, verts[(nodes[i].verts[1] * 3) + 1]);
                    ymax = Math.Max(ymax, verts[(nodes[i].verts[2] * 3) + 1]);
                    detailNodes[i] = new DtPolyDetail
                    {
                        vertBase = 0,
                        vertCount = 0,
                        triBase = i,
                        triCount = 1
                    };
                    detailTris[4 * i] = 0;
                    detailTris[(4 * i) + 1] = 1;
                    detailTris[(4 * i) + 2] = 2;
                    // Bit for each edge that belongs to poly boundary, basically all edges marked as boundary as it is
                    // a triangle
                    detailTris[(4 * i) + 3] = (1 << 4) | (1 << 2) | 1;
                }

                tiles[tileIndex].Verts = verts;
                tiles[tileIndex].Polys = nodes;
                tiles[tileIndex].DetailMeshes = detailNodes;
                tiles[tileIndex].DetailVerts = detailVerts;
                tiles[tileIndex].DetailTris = detailTris;
                var header = new DtMeshHeader
                {
                    Magic = DtMeshHeader.DT_NAVMESH_MAGIC,
                    version = DtMeshHeader.DT_NAVMESH_VERSION,
                    x = x,
                    y = z,
                    polyCount = nodeCount,
                    vertCount = vertsCount,
                    detailMeshCount = nodeCount,
                    detailTriCount = nodeCount,
                    maxLinkCount = nodeCount * 3 * 2 // XXX: Needed by Recast, not needed by recast4j
                };
                header.bmin.X = meta.forcedBoundsCenter.x - (0.5f * meta.forcedBoundsSize.x)
                                + (meta.cellSize * meta.tileSizeX * x);
                header.bmin.Y = ymin;
                header.bmin.Z = meta.forcedBoundsCenter.z - (0.5f * meta.forcedBoundsSize.z)
                                + (meta.cellSize * meta.tileSizeZ * z);
                header.bmax.X = meta.forcedBoundsCenter.x - (0.5f * meta.forcedBoundsSize.x)
                                + (meta.cellSize * meta.tileSizeX * (x + 1));
                header.bmax.Y = ymax;
                header.bmax.Z = meta.forcedBoundsCenter.z - (0.5f * meta.forcedBoundsSize.z)
                                + (meta.cellSize * meta.tileSizeZ * (z + 1));
                header.bvQuantFactor = 1.0f / meta.cellSize;
                header.offMeshBase = nodeCount;
                header.walkableClimb = meta.walkableClimb;
                header.walkableHeight = meta.walkableHeight;
                header.walkableRadius = meta.characterRadius;
                tiles[tileIndex].Header = header;
            }
        }

        return new GraphMeshData(tileXCount, tileZCount, tiles);
    }

    public static int HighestOneBit(uint i)
    {
        i |= i >> 1;
        i |= i >> 2;
        i |= i >> 4;
        i |= i >> 8;
        i |= i >> 16;
        return (int)(i - (i >> 1));
    }

    // See NavmeshBase.cs: ASTAR_RECAST_LARGER_TILES
    private int GetVertMask(int vertsCount)
    {
        var vertMask = HighestOneBit((uint)vertsCount);
        if (vertMask != vertsCount)
        {
            vertMask *= 2;
        }

        vertMask--;
        return vertMask;
    }
}