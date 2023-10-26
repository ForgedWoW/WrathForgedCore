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
using DotRecast.Core;
using DotRecast.Core.Numerics;

namespace DotRecast.Detour.Extras.Unity.Astar
{
    public class OffMeshLinkCreator
    {
        public void Build(GraphMeshData graphData, NodeLink2[] links, int nodeOffset)
        {
            if (links.Length > 0)
            {
                foreach (NodeLink2 l in links)
                {
                    DtMeshData startTile = graphData.GetTile(l.startNode - nodeOffset);
                    DtPoly startNode = graphData.GetNode(l.startNode - nodeOffset);
                    DtMeshData endTile = graphData.GetTile(l.endNode - nodeOffset);
                    DtPoly endNode = graphData.GetNode(l.endNode - nodeOffset);
                    if (startNode != null && endNode != null)
                    {
                        // FIXME: Optimise
                        startTile.Polys = RcArrayUtils.CopyOf(startTile.Polys, startTile.Polys.Length + 1);
                        int poly = startTile.Header.polyCount;
                        startTile.Polys[poly] = new DtPoly(poly, 2);
                        startTile.Polys[poly].verts[0] = startTile.Header.vertCount;
                        startTile.Polys[poly].verts[1] = startTile.Header.vertCount + 1;
                        startTile.Polys[poly].SetPolyType(DtPolyTypes.DT_POLYTYPE_OFFMESH_CONNECTION);
                        startTile.Verts = RcArrayUtils.CopyOf(startTile.Verts, startTile.Verts.Length + 6);
                        startTile.Header.polyCount++;
                        startTile.Header.vertCount += 2;
                        DtOffMeshConnection connection = new DtOffMeshConnection();
                        connection.poly = poly;
                        connection.pos = new float[]
                        {
                            l.clamped1.X, l.clamped1.Y, l.clamped1.Z,
                            l.clamped2.X, l.clamped2.Y, l.clamped2.Z
                        };
                        connection.rad = 0.1f;
                        connection.side = startTile == endTile
                            ? 0xFF
                            : DtNavMeshBuilder.ClassifyOffMeshPoint(new RcVec3f(connection.pos.AsSpan(3)), startTile.Header.bmin, startTile.Header.bmax);
                        connection.userId = (int)l.linkID;
                        if (startTile.OffMeshCons == null)
                        {
                            startTile.OffMeshCons = new DtOffMeshConnection[1];
                        }
                        else
                        {
                            startTile.OffMeshCons = RcArrayUtils.CopyOf(startTile.OffMeshCons, startTile.OffMeshCons.Length + 1);
                        }

                        startTile.OffMeshCons[startTile.OffMeshCons.Length - 1] = connection;
                        startTile.Header.offMeshConCount++;
                    }
                }
            }
        }
    }
}