/*
Recast4J Copyright (c) 2015-2018 Piotr Piastucki piotr@jtilia.org

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

public class DtMeshSetWriter : DtWriter
{
    private readonly DtMeshDataWriter writer = new();
    private readonly DtNavMeshParamWriter paramWriter = new();

    public void Write(BinaryWriter stream, DtNavMesh mesh, RcByteOrder order, bool cCompatibility)
    {
        WriteHeader(stream, mesh, order, cCompatibility);
        WriteTiles(stream, mesh, order, cCompatibility);
    }

    private void WriteHeader(BinaryWriter stream, DtNavMesh mesh, RcByteOrder order, bool cCompatibility)
    {
        Write(stream, NavMeshSetHeader.NAVMESHSET_MAGIC, order);
        Write(stream, cCompatibility ? NavMeshSetHeader.NAVMESHSET_VERSION : NavMeshSetHeader.NAVMESHSET_VERSION_RECAST4J, order);
        var numTiles = 0;
        for (var i = 0; i < mesh.GetMaxTiles(); ++i)
        {
            var tile = mesh.GetTile(i);
            if (tile == null || tile.data == null || tile.data.Header == null)
            {
                continue;
            }

            numTiles++;
        }

        Write(stream, numTiles, order);
        paramWriter.Write(stream, mesh.GetParams(), order);
        if (!cCompatibility)
        {
            Write(stream, mesh.GetMaxVertsPerPoly(), order);
        }
    }

    private void WriteTiles(BinaryWriter stream, DtNavMesh mesh, RcByteOrder order, bool cCompatibility)
    {
        for (var i = 0; i < mesh.GetMaxTiles(); ++i)
        {
            var tile = mesh.GetTile(i);
            if (tile == null || tile.data == null || tile.data.Header == null)
            {
                continue;
            }

            var tileHeader = new NavMeshTileHeader
            {
                tileRef = mesh.GetTileRef(tile)
            };
            using var msw = new MemoryStream();
            using var bw = new BinaryWriter(msw);
            writer.Write(bw, tile.data, order, cCompatibility);
            bw.Flush();
            bw.Close();

            var ba = msw.ToArray();
            tileHeader.dataSize = ba.Length;
            Write(stream, tileHeader.tileRef, order);
            Write(stream, tileHeader.dataSize, order);
            if (cCompatibility)
            {
                Write(stream, 0, order); // C struct padding
            }

            stream.Write(ba);
        }
    }
}