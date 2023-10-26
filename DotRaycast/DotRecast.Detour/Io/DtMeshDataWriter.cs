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

public class DtMeshDataWriter : DtWriter
{
    public void Write(BinaryWriter stream, DtMeshData data, RcByteOrder order, bool cCompatibility)
    {
        var header = data.Header;
        Write(stream, header.Magic, order);
        Write(stream, cCompatibility ? DtMeshHeader.DT_NAVMESH_VERSION : DtMeshHeader.DT_NAVMESH_VERSION_RECAST4J_LAST, order);
        Write(stream, header.x, order);
        Write(stream, header.y, order);
        Write(stream, header.layer, order);
        Write(stream, header.userId, order);
        Write(stream, header.polyCount, order);
        Write(stream, header.vertCount, order);
        Write(stream, header.maxLinkCount, order);
        Write(stream, header.detailMeshCount, order);
        Write(stream, header.detailVertCount, order);
        Write(stream, header.detailTriCount, order);
        Write(stream, header.bvNodeCount, order);
        Write(stream, header.offMeshConCount, order);
        Write(stream, header.offMeshBase, order);
        Write(stream, header.walkableHeight, order);
        Write(stream, header.walkableRadius, order);
        Write(stream, header.walkableClimb, order);
        Write(stream, header.bmin.X, order);
        Write(stream, header.bmin.Y, order);
        Write(stream, header.bmin.Z, order);
        Write(stream, header.bmax.X, order);
        Write(stream, header.bmax.Y, order);
        Write(stream, header.bmax.Z, order);
        Write(stream, header.bvQuantFactor, order);
        WriteVerts(stream, data.Verts, header.vertCount, order);
        WritePolys(stream, data, order, cCompatibility);
        if (cCompatibility)
        {
            var linkPlaceholder = new byte[header.maxLinkCount * DtMeshDataReader.GetSizeofLink(false)];
            stream.Write(linkPlaceholder);
        }

        WritePolyDetails(stream, data, order, cCompatibility);
        WriteVerts(stream, data.DetailVerts, header.detailVertCount, order);
        WriteDTris(stream, data);
        WriteBVTree(stream, data, order, cCompatibility);
        WriteOffMeshCons(stream, data, order);
    }

    private void WriteVerts(BinaryWriter stream, float[] verts, int count, RcByteOrder order)
    {
        for (var i = 0; i < count * 3; i++)
        {
            Write(stream, verts[i], order);
        }
    }

    private void WritePolys(BinaryWriter stream, DtMeshData data, RcByteOrder order, bool cCompatibility)
    {
        for (var i = 0; i < data.Header.polyCount; i++)
        {
            if (cCompatibility)
            {
                Write(stream, 0xFFFF, order);
            }

            for (var j = 0; j < data.Polys[i].verts.Length; j++)
            {
                Write(stream, (short)data.Polys[i].verts[j], order);
            }

            for (var j = 0; j < data.Polys[i].neis.Length; j++)
            {
                Write(stream, (short)data.Polys[i].neis[j], order);
            }

            Write(stream, (short)data.Polys[i].flags, order);
            Write(stream, (byte)data.Polys[i].vertCount);
            Write(stream, (byte)data.Polys[i].areaAndtype);
        }
    }

    private void WritePolyDetails(BinaryWriter stream, DtMeshData data, RcByteOrder order, bool cCompatibility)
    {
        for (var i = 0; i < data.Header.detailMeshCount; i++)
        {
            Write(stream, data.DetailMeshes[i].vertBase, order);
            Write(stream, data.DetailMeshes[i].triBase, order);
            Write(stream, (byte)data.DetailMeshes[i].vertCount);
            Write(stream, (byte)data.DetailMeshes[i].triCount);
            if (cCompatibility)
            {
                Write(stream, (short)0, order);
            }
        }
    }

    private void WriteDTris(BinaryWriter stream, DtMeshData data)
    {
        for (var i = 0; i < data.Header.detailTriCount * 4; i++)
        {
            Write(stream, (byte)data.DetailTris[i]);
        }
    }

    private void WriteBVTree(BinaryWriter stream, DtMeshData data, RcByteOrder order, bool cCompatibility)
    {
        for (var i = 0; i < data.Header.bvNodeCount; i++)
        {
            if (cCompatibility)
            {
                for (var j = 0; j < 3; j++)
                {
                    Write(stream, (short)data.BvTree[i].bmin[j], order);
                }

                for (var j = 0; j < 3; j++)
                {
                    Write(stream, (short)data.BvTree[i].bmax[j], order);
                }
            }
            else
            {
                for (var j = 0; j < 3; j++)
                {
                    Write(stream, data.BvTree[i].bmin[j], order);
                }

                for (var j = 0; j < 3; j++)
                {
                    Write(stream, data.BvTree[i].bmax[j], order);
                }
            }

            Write(stream, data.BvTree[i].i, order);
        }
    }

    private void WriteOffMeshCons(BinaryWriter stream, DtMeshData data, RcByteOrder order)
    {
        for (var i = 0; i < data.Header.offMeshConCount; i++)
        {
            for (var j = 0; j < 6; j++)
            {
                Write(stream, data.OffMeshCons[i].pos[j], order);
            }

            Write(stream, data.OffMeshCons[i].rad, order);
            Write(stream, (short)data.OffMeshCons[i].poly, order);
            Write(stream, (byte)data.OffMeshCons[i].flags);
            Write(stream, (byte)data.OffMeshCons[i].side);
            Write(stream, data.OffMeshCons[i].userId, order);
        }
    }
}