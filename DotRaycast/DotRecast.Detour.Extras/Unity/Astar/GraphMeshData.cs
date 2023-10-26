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

namespace DotRecast.Detour.Extras.Unity.Astar
{
    public class GraphMeshData(int tileXCount, int tileZCount, DtMeshData[] tiles)
    {
        public readonly int tileXCount = tileXCount;
        public readonly int tileZCount = tileZCount;
        public readonly DtMeshData[] tiles = tiles;

        public int CountNodes()
        {
            int polyCount = 0;
            foreach (DtMeshData t in tiles)
            {
                polyCount += t.Header.polyCount;
            }

            return polyCount;
        }

        public DtPoly GetNode(int node)
        {
            int index = 0;
            foreach (DtMeshData t in tiles)
            {
                if (node - index >= 0 && node - index < t.Header.polyCount)
                {
                    return t.Polys[node - index];
                }

                index += t.Header.polyCount;
            }

            return null;
        }

        public DtMeshData GetTile(int node)
        {
            int index = 0;
            foreach (DtMeshData t in tiles)
            {
                if (node - index >= 0 && node - index < t.Header.polyCount)
                {
                    return t;
                }

                index += t.Header.polyCount;
            }

            return null;
        }
    }
}