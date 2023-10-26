/*
Recast4J Copyright (c) 2015 Piotr Piastucki piotr@jtilia.org

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

using System.IO;
using DotRecast.Core;

namespace DotRecast.Detour.Io;

public class DtMeshDataReader
{
    public const int DT_POLY_DETAIL_SIZE = 10;

    public DtMeshData Read(BinaryReader stream, int maxVertPerPoly = 6)
    {
        var buf = IOUtils.ToByteBuffer(stream);
        return Read(buf, maxVertPerPoly, false);
    }

    public DtMeshData Read(RcByteBuffer buf, int maxVertPerPoly = 6) => Read(buf, maxVertPerPoly, false);

    public DtMeshData Read32Bit(BinaryReader stream, int maxVertPerPoly)
    {
        var buf = IOUtils.ToByteBuffer(stream);
        return Read(buf, maxVertPerPoly, true);
    }

    public DtMeshData Read32Bit(RcByteBuffer buf, int maxVertPerPoly = 6) => Read(buf, maxVertPerPoly, true);

    public DtMeshData Read(RcByteBuffer buf, int maxVertPerPoly, bool is32Bit)
    {
        var data = new DtMeshData();
        var header = new DtMeshHeader();
        data.Header = header;
        header.Magic = buf.GetInt();
        if (header.Magic != DtMeshHeader.DT_NAVMESH_MAGIC)
        {
            header.Magic = IOUtils.SwapEndianness(header.Magic);
            if (header.Magic != DtMeshHeader.DT_NAVMESH_MAGIC)
            {
                throw new IOException("Invalid magic");
            }

            buf.Order(buf.Order() == RcByteOrder.BIG_ENDIAN ? RcByteOrder.LITTLE_ENDIAN : RcByteOrder.BIG_ENDIAN);
        }

        header.version = buf.GetInt();
        if (header.version != DtMeshHeader.DT_NAVMESH_VERSION)
        {
            if (header.version is < DtMeshHeader.DT_NAVMESH_VERSION_RECAST4J_FIRST
                or > DtMeshHeader.DT_NAVMESH_VERSION_RECAST4J_LAST)
            {
                throw new IOException("Invalid version " + header.version);
            }
        }

        var cCompatibility = header.version == DtMeshHeader.DT_NAVMESH_VERSION;
        header.x = buf.GetInt();
        header.y = buf.GetInt();
        header.layer = buf.GetInt();
        header.userId = buf.GetInt();
        header.polyCount = buf.GetInt();
        header.vertCount = buf.GetInt();
        header.maxLinkCount = buf.GetInt();
        header.detailMeshCount = buf.GetInt();
        header.detailVertCount = buf.GetInt();
        header.detailTriCount = buf.GetInt();
        header.bvNodeCount = buf.GetInt();
        header.offMeshConCount = buf.GetInt();
        header.offMeshBase = buf.GetInt();
        header.walkableHeight = buf.GetFloat();
        header.walkableRadius = buf.GetFloat();
        header.walkableClimb = buf.GetFloat();

        header.bmin.X = buf.GetFloat();
        header.bmin.Y = buf.GetFloat();
        header.bmin.Z = buf.GetFloat();

        header.bmax.X = buf.GetFloat();
        header.bmax.Y = buf.GetFloat();
        header.bmax.Z = buf.GetFloat();

        header.bvQuantFactor = buf.GetFloat();
        data.Verts = ReadVerts(buf, header.vertCount);
        data.Polys = ReadPolys(buf, header, maxVertPerPoly);
        if (cCompatibility)
        {
            buf.Position(buf.Position() + (header.maxLinkCount * GetSizeofLink(is32Bit)));
        }

        data.DetailMeshes = ReadPolyDetails(buf, header, cCompatibility);
        data.DetailVerts = ReadVerts(buf, header.detailVertCount);
        data.DetailTris = ReadDTris(buf, header);
        data.BvTree = ReadBVTree(buf, header);
        data.OffMeshCons = ReadOffMeshCons(buf, header);
        return data;
    }

    public const int LINK_SIZEOF = 16;
    public const int LINK_SIZEOF32BIT = 12;

    public static int GetSizeofLink(bool is32Bit) => is32Bit ? LINK_SIZEOF32BIT : LINK_SIZEOF;

    private float[] ReadVerts(RcByteBuffer buf, int count)
    {
        var verts = new float[count * 3];
        for (var i = 0; i < verts.Length; i++)
        {
            verts[i] = buf.GetFloat();
        }

        return verts;
    }

    private DtPoly[] ReadPolys(RcByteBuffer buf, DtMeshHeader header, int maxVertPerPoly)
    {
        var polys = new DtPoly[header.polyCount];
        for (var i = 0; i < polys.Length; i++)
        {
            polys[i] = new DtPoly(i, maxVertPerPoly);
            if (header.version < DtMeshHeader.DT_NAVMESH_VERSION_RECAST4J_NO_POLY_FIRSTLINK)
            {
                _ = buf.GetInt(); // polys[i].firstLink
            }

            for (var j = 0; j < polys[i].verts.Length; j++)
            {
                polys[i].verts[j] = buf.GetShort() & 0xFFFF;
            }

            for (var j = 0; j < polys[i].neis.Length; j++)
            {
                polys[i].neis[j] = buf.GetShort() & 0xFFFF;
            }

            polys[i].flags = buf.GetShort() & 0xFFFF;
            polys[i].vertCount = buf.Get() & 0xFF;
            polys[i].areaAndtype = buf.Get() & 0xFF;
        }

        return polys;
    }

    private DtPolyDetail[] ReadPolyDetails(RcByteBuffer buf, DtMeshHeader header, bool cCompatibility)
    {
        var polys = new DtPolyDetail[header.detailMeshCount];
        for (var i = 0; i < polys.Length; i++)
        {
            polys[i] = new DtPolyDetail
            {
                vertBase = buf.GetInt(),
                triBase = buf.GetInt(),
                vertCount = buf.Get() & 0xFF,
                triCount = buf.Get() & 0xFF
            };
            if (cCompatibility)
            {
                _ = buf.GetShort(); // C struct padding
            }
        }

        return polys;
    }

    private int[] ReadDTris(RcByteBuffer buf, DtMeshHeader header)
    {
        var tris = new int[4 * header.detailTriCount];
        for (var i = 0; i < tris.Length; i++)
        {
            tris[i] = buf.Get() & 0xFF;
        }

        return tris;
    }

    private DtBVNode[] ReadBVTree(RcByteBuffer buf, DtMeshHeader header)
    {
        var nodes = new DtBVNode[header.bvNodeCount];
        for (var i = 0; i < nodes.Length; i++)
        {
            nodes[i] = new DtBVNode();
            if (header.version < DtMeshHeader.DT_NAVMESH_VERSION_RECAST4J_32BIT_BVTREE)
            {
                for (var j = 0; j < 3; j++)
                {
                    nodes[i].bmin[j] = buf.GetShort() & 0xFFFF;
                }

                for (var j = 0; j < 3; j++)
                {
                    nodes[i].bmax[j] = buf.GetShort() & 0xFFFF;
                }
            }
            else
            {
                for (var j = 0; j < 3; j++)
                {
                    nodes[i].bmin[j] = buf.GetInt();
                }

                for (var j = 0; j < 3; j++)
                {
                    nodes[i].bmax[j] = buf.GetInt();
                }
            }

            nodes[i].i = buf.GetInt();
        }

        return nodes;
    }

    private DtOffMeshConnection[] ReadOffMeshCons(RcByteBuffer buf, DtMeshHeader header)
    {
        var cons = new DtOffMeshConnection[header.offMeshConCount];
        for (var i = 0; i < cons.Length; i++)
        {
            cons[i] = new DtOffMeshConnection();
            for (var j = 0; j < 6; j++)
            {
                cons[i].pos[j] = buf.GetFloat();
            }

            cons[i].rad = buf.GetFloat();
            cons[i].poly = buf.GetShort() & 0xFFFF;
            cons[i].flags = buf.Get() & 0xFF;
            cons[i].side = buf.Get() & 0xFF;
            cons[i].userId = buf.GetInt();
        }

        return cons;
    }
}