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

namespace DotRecast.Detour.Extras
{
    public class BVTreeBuilder
    {
        public void Build(DtMeshData data)
        {
            data.BvTree = new DtBVNode[data.Header.polyCount * 2];
            data.Header.bvNodeCount = data.BvTree.Length == 0
                ? 0
                : CreateBVTree(data, data.BvTree, data.Header.bvQuantFactor);
        }

        private static int CreateBVTree(DtMeshData data, DtBVNode[] nodes, float quantFactor)
        {
            BVItem[] items = new BVItem[data.Header.polyCount];
            for (int i = 0; i < data.Header.polyCount; i++)
            {
                BVItem it = new BVItem();
                items[i] = it;
                it.i = i;
                RcVec3f bmin = new RcVec3f(data.Verts.AsSpan(data.Polys[i].verts[0] * 3));
                RcVec3f bmax = new RcVec3f(data.Verts.AsSpan(data.Polys[i].verts[0] * 3));
                for (int j = 1; j < data.Polys[i].vertCount; j++)
                {
                    bmin = RcVecUtils.Min(bmin, data.Verts, data.Polys[i].verts[j] * 3);
                    bmax = RcVecUtils.Max(bmax, data.Verts, data.Polys[i].verts[j] * 3);
                }

                it.bmin[0] = Math.Clamp((int)((bmin.X - data.Header.bmin.X) * quantFactor), 0, 0x7fffffff);
                it.bmin[1] = Math.Clamp((int)((bmin.Y - data.Header.bmin.Y) * quantFactor), 0, 0x7fffffff);
                it.bmin[2] = Math.Clamp((int)((bmin.Z - data.Header.bmin.Z) * quantFactor), 0, 0x7fffffff);
                it.bmax[0] = Math.Clamp((int)((bmax.X - data.Header.bmin.X) * quantFactor), 0, 0x7fffffff);
                it.bmax[1] = Math.Clamp((int)((bmax.Y - data.Header.bmin.Y) * quantFactor), 0, 0x7fffffff);
                it.bmax[2] = Math.Clamp((int)((bmax.Z - data.Header.bmin.Z) * quantFactor), 0, 0x7fffffff);
            }

            return DtNavMeshBuilder.Subdivide(items, data.Header.polyCount, 0, data.Header.polyCount, 0, nodes);
        }
    }
}