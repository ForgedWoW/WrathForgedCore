/*
Copyright (c) 2009-2010 Mikko Mononen memon@inside.org
recast4j copyright (c) 2015-2019 Piotr Piastucki piotr@jtilia.org
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
using System.Collections.Generic;
using DotRecast.Core;
using DotRecast.Core.Numerics;

namespace DotRecast.Detour;

public class DtNavMesh
{
    public const int DT_SALT_BITS = 16;
    public const int DT_TILE_BITS = 28;
    public const int DT_POLY_BITS = 20;

    /// A flag that indicates that an entity links to an external entity.
    /// (E.g. A polygon edge is a portal that links to another polygon.)
    public const int DT_EXT_LINK = 0x8000;

    /// A value that indicates the entity does not link to anything.
    public const int DT_NULL_LINK = unchecked((int)0xffffffff);

    /// A flag that indicates that an off-mesh connection can be traversed in
    /// both directions. (Is bidirectional.)
    public const int DT_OFFMESH_CON_BIDIR = 1;

    /// The maximum number of user defined area ids.
    public const int DT_MAX_AREAS = 64;

    /// Limit raycasting during any angle pahfinding
    /// The limit is given as a multiple of the character radius
    public const float DT_RAY_CAST_LIMIT_PROPORTIONS = 50.0f;

    private readonly DtNavMeshParams m_params;

    /// < Current initialization params. TODO: do not store this info twice.
    private readonly RcVec3f m_orig;

    /// < Origin of the tile (0,0)
    // float m_orig[3]; ///< Origin of the tile (0,0)
    private readonly float m_tileWidth;

    private readonly float m_tileHeight;

    /// < Dimensions of each tile.
    private readonly int m_maxTiles;

    /// < Max number of tiles.
    private readonly int m_tileLutMask;

    /// < Tile hash lookup mask.
    private readonly Dictionary<int, List<DtMeshTile>> posLookup = [];

    private readonly LinkedList<DtMeshTile> availableTiles = new();
    private readonly DtMeshTile[] m_tiles;

    /// < List of tiles.
    /** The maximum number of vertices per navigation polygon. */
    private readonly int m_maxVertPerPoly;

    private int m_tileCount;

    public DtNavMesh(DtMeshData data, int maxVertsPerPoly, int flags)
        : this(GetNavMeshParams(data), maxVertsPerPoly) => AddTile(data, flags, 0);

    public DtNavMesh(DtNavMeshParams option, int maxVertsPerPoly = 6)
    {
        m_params = option;
        m_orig = option.orig;
        m_tileWidth = option.tileWidth;
        m_tileHeight = option.tileHeight;
        // Init tiles
        m_maxTiles = option.maxTiles;
        m_maxVertPerPoly = maxVertsPerPoly;
        m_tileLutMask = Math.Max(1, DtUtils.NextPow2(option.maxTiles)) - 1;
        m_tiles = new DtMeshTile[m_maxTiles];
        for (var i = 0; i < m_maxTiles; i++)
        {
            m_tiles[i] = new DtMeshTile(i)
            {
                salt = 1
            };
            _ = availableTiles.AddLast(m_tiles[i]);
        }
    }

    private static DtNavMeshParams GetNavMeshParams(DtMeshData data)
    {
        var option = new DtNavMeshParams
        {
            orig = data.Header.bmin,
            tileWidth = data.Header.bmax.X - data.Header.bmin.X,
            tileHeight = data.Header.bmax.Z - data.Header.bmin.Z,
            maxTiles = 1,
            maxPolys = data.Header.polyCount
        };
        return option;
    }

    /**
 * The maximum number of tiles supported by the navigation mesh.
 *
 * @return The maximum number of tiles supported by the navigation mesh.
 */
    public int GetMaxTiles() => m_maxTiles;

    /**
 * Returns tile in the tile array.
 */
    public DtMeshTile GetTile(int i) => m_tiles[i];

    /**
 * Gets the polygon reference for the tile's base polygon.
 *
 * @param tile
 *            The tile.
 * @return The polygon reference for the base polygon in the specified tile.
 */
    public long GetPolyRefBase(DtMeshTile tile)
    {
        if (tile == null)
        {
            return 0;
        }

        var it = tile.index;
        return EncodePolyId(tile.salt, it, 0);
    }

    /// @{
    /// @name Encoding and Decoding
    /// These functions are generally meant for internal use only.
    /// Derives a standard polygon reference.
    ///  @note This function is generally meant for internal use only.
    ///  @param[in]	salt	The tile's salt value.
    ///  @param[in]	it		The index of the tile.
    ///  @param[in]	ip		The index of the polygon within the tile.
    public static long EncodePolyId(int salt, int it, int ip) => (((long)salt) << (DT_POLY_BITS + DT_TILE_BITS)) | ((long)it << DT_POLY_BITS) | (long)ip;

    /// Decodes a standard polygon reference.
    /// @note This function is generally meant for internal use only.
    /// @param[in] ref The polygon reference to decode.
    /// @param[out] salt The tile's salt value.
    /// @param[out] it The index of the tile.
    /// @param[out] ip The index of the polygon within the tile.
    /// @see #encodePolyId
    private static void DecodePolyId(long refs, out int salt, out int it, out int ip)
    {
        var saltMask = (1L << DT_SALT_BITS) - 1;
        var tileMask = (1L << DT_TILE_BITS) - 1;
        var polyMask = (1L << DT_POLY_BITS) - 1;
        salt = (int)((refs >> (DT_POLY_BITS + DT_TILE_BITS)) & saltMask);
        it = (int)((refs >> DT_POLY_BITS) & tileMask);
        ip = (int)(refs & polyMask);
    }

    /// Extracts a tile's salt value from the specified polygon reference.
    /// @note This function is generally meant for internal use only.
    /// @param[in] ref The polygon reference.
    /// @see #encodePolyId
    private static int DecodePolyIdSalt(long refs)
    {
        var saltMask = (1L << DT_SALT_BITS) - 1;
        return (int)((refs >> (DT_POLY_BITS + DT_TILE_BITS)) & saltMask);
    }

    /// Extracts the tile's index from the specified polygon reference.
    /// @note This function is generally meant for internal use only.
    /// @param[in] ref The polygon reference.
    /// @see #encodePolyId
    public static int DecodePolyIdTile(long refs)
    {
        var tileMask = (1L << DT_TILE_BITS) - 1;
        return (int)((refs >> DT_POLY_BITS) & tileMask);
    }

    /// Extracts the polygon's index (within its tile) from the specified
    /// polygon reference.
    /// @note This function is generally meant for internal use only.
    /// @param[in] ref The polygon reference.
    /// @see #encodePolyId
    private static int DecodePolyIdPoly(long refs)
    {
        var polyMask = (1L << DT_POLY_BITS) - 1;
        return (int)(refs & polyMask);
    }

    private int AllocLink(DtMeshTile tile)
    {
        if (tile.linksFreeList == DT_NULL_LINK)
        {
            var link = new DtLink
            {
                next = DT_NULL_LINK
            };
            tile.links.Add(link);
            return tile.links.Count - 1;
        }

        var linkIdx = tile.linksFreeList;
        tile.linksFreeList = tile.links[linkIdx].next;
        return linkIdx;
    }

    private void FreeLink(DtMeshTile tile, int link)
    {
        tile.links[link].next = tile.linksFreeList;
        tile.linksFreeList = link;
    }

    /**
 * Calculates the tile grid location for the specified world position.
 *
 * @param pos
 *            The world position for the query. [(x, y, z)]
 * @return 2-element int array with (tx,ty) tile location
 */
    public void CalcTileLoc(RcVec3f pos, out int tx, out int ty)
    {
        tx = (int)MathF.Floor((pos.X - m_orig.X) / m_tileWidth);
        ty = (int)MathF.Floor((pos.Z - m_orig.Z) / m_tileHeight);
    }

    /// Gets the tile and polygon for the specified polygon reference.
    ///  @param[in]		ref		The reference for the a polygon.
    ///  @param[out]	tile	The tile containing the polygon.
    ///  @param[out]	poly	The polygon.
    /// @return The status flags for the operation.
    public DtStatus GetTileAndPolyByRef(long refs, out DtMeshTile tile, out DtPoly poly)
    {
        tile = null;
        poly = null;

        if (refs == 0)
        {
            return DtStatus.DT_FAILURE;
        }

        DecodePolyId(refs, out var salt, out var it, out var ip);
        if (it >= m_maxTiles)
        {
            return DtStatus.DT_FAILURE | DtStatus.DT_INVALID_PARAM;
        }

        if (m_tiles[it].salt != salt || m_tiles[it].data.Header == null)
        {
            return DtStatus.DT_FAILURE | DtStatus.DT_INVALID_PARAM;
        }

        if (ip >= m_tiles[it].data.Header.polyCount)
        {
            return DtStatus.DT_FAILURE | DtStatus.DT_INVALID_PARAM;
        }

        tile = m_tiles[it];
        poly = m_tiles[it].data.Polys[ip];

        return DtStatus.DT_SUCCSESS;
    }

    /// @par
    ///
    /// @warning Only use this function if it is known that the provided polygon
    /// reference is valid. This function is faster than #getTileAndPolyByRef,
    /// but
    /// it does not validate the reference.
    public void GetTileAndPolyByRefUnsafe(long refs, out DtMeshTile tile, out DtPoly poly)
    {
        DecodePolyId(refs, out _, out var it, out var ip);
        tile = m_tiles[it];
        poly = m_tiles[it].data.Polys[ip];
    }

    public bool IsValidPolyRef(long refs)
    {
        if (refs == 0)
        {
            return false;
        }

        DecodePolyId(refs, out var salt, out var it, out var ip);
        return it < m_maxTiles && m_tiles[it].salt == salt && m_tiles[it].data != null && ip < m_tiles[it].data.Header.polyCount;
    }

    public ref readonly DtNavMeshParams GetParams() => ref m_params;

    // TODO: These methods are duplicates from dtNavMeshQuery, but are needed
    // for off-mesh connection finding.

    private List<long> QueryPolygonsInTile(DtMeshTile tile, RcVec3f qmin, RcVec3f qmax)
    {
        List<long> polys = [];
        if (tile.data.BvTree != null)
        {
            var nodeIndex = 0;
            var tbmin = tile.data.Header.bmin;
            var tbmax = tile.data.Header.bmax;
            var qfac = tile.data.Header.bvQuantFactor;
            // Calculate quantized box
            var bmin = new int[3];
            var bmax = new int[3];
            // dtClamp query box to world box.
            var minx = Math.Clamp(qmin.X, tbmin.X, tbmax.X) - tbmin.X;
            var miny = Math.Clamp(qmin.Y, tbmin.Y, tbmax.Y) - tbmin.Y;
            var minz = Math.Clamp(qmin.Z, tbmin.Z, tbmax.Z) - tbmin.Z;
            var maxx = Math.Clamp(qmax.X, tbmin.X, tbmax.X) - tbmin.X;
            var maxy = Math.Clamp(qmax.Y, tbmin.Y, tbmax.Y) - tbmin.Y;
            var maxz = Math.Clamp(qmax.Z, tbmin.Z, tbmax.Z) - tbmin.Z;
            // Quantize
            bmin[0] = (int)(qfac * minx) & 0x7ffffffe;
            bmin[1] = (int)(qfac * miny) & 0x7ffffffe;
            bmin[2] = (int)(qfac * minz) & 0x7ffffffe;
            bmax[0] = (int)((qfac * maxx) + 1) | 1;
            bmax[1] = (int)((qfac * maxy) + 1) | 1;
            bmax[2] = (int)((qfac * maxz) + 1) | 1;

            // Traverse tree
            var @base = GetPolyRefBase(tile);
            var end = tile.data.Header.bvNodeCount;
            while (nodeIndex < end)
            {
                var node = tile.data.BvTree[nodeIndex];
                var overlap = DtUtils.OverlapQuantBounds(bmin, bmax, node.bmin, node.bmax);
                var isLeafNode = node.i >= 0;

                if (isLeafNode && overlap)
                {
                    polys.Add(@base | (long)node.i);
                }

                if (overlap || isLeafNode)
                {
                    nodeIndex++;
                }
                else
                {
                    var escapeIndex = -node.i;
                    nodeIndex += escapeIndex;
                }
            }

            return polys;
        }
        else
        {
            var bmin = new RcVec3f();
            var bmax = new RcVec3f();
            var @base = GetPolyRefBase(tile);
            for (var i = 0; i < tile.data.Header.polyCount; ++i)
            {
                var p = tile.data.Polys[i];
                // Do not return off-mesh connection polygons.
                if (p.GetPolyType() == DtPolyTypes.DT_POLYTYPE_OFFMESH_CONNECTION)
                {
                    continue;
                }

                // Calc polygon bounds.
                var v = p.verts[0] * 3;
                bmin = new RcVec3f(tile.data.Verts.AsSpan(v));
                bmax = new RcVec3f(tile.data.Verts.AsSpan(v));
                for (var j = 1; j < p.vertCount; ++j)
                {
                    v = p.verts[j] * 3;
                    bmin = RcVecUtils.Min(bmin, tile.data.Verts, v);
                    bmax = RcVecUtils.Max(bmax, tile.data.Verts, v);
                }

                if (DtUtils.OverlapBounds(qmin, qmax, bmin, bmax))
                {
                    polys.Add(@base | (long)i);
                }
            }

            return polys;
        }
    }

    public long UpdateTile(DtMeshData data, int flags)
    {
        var refs = GetTileRefAt(data.Header.x, data.Header.y, data.Header.layer);
        refs = RemoveTile(refs);
        return AddTile(data, flags, refs);
    }

    /// Adds a tile to the navigation mesh.
    /// @param[in] data Data for the new tile mesh. (See: #dtCreateNavMeshData)
    /// @param[in] dataSize Data size of the new tile mesh.
    /// @param[in] flags Tile flags. (See: #dtTileFlags)
    /// @param[in] lastRef The desired reference for the tile. (When reloading a
    /// tile.) [opt] [Default: 0]
    /// @param[out] result The tile reference. (If the tile was succesfully
    /// added.) [opt]
    /// @return The status flags for the operation.
    /// @par
    ///
    /// The add operation will fail if the data is in the wrong format, the
    /// allocated tile
    /// space is full, or there is a tile already at the specified reference.
    ///
    /// The lastRef parameter is used to restore a tile with the same tile
    /// reference it had previously used. In this case the #long's for the
    /// tile will be restored to the same values they were before the tile was
    /// removed.
    ///
    /// The nav mesh assumes exclusive access to the data passed and will make
    /// changes to the dynamic portion of the data. For that reason the data
    /// should not be reused in other nav meshes until the tile has been successfully
    /// removed from this nav mesh.
    ///
    /// @see dtCreateNavMeshData, #removeTile
    public long AddTile(DtMeshData data, int flags, long lastRef)
    {
        // Make sure the data is in right format.
        var header = data.Header;

        // Make sure the location is free.
        if (GetTileAt(header.x, header.y, header.layer) != null)
        {
            throw new Exception("Tile already exists");
        }

        // Allocate a tile.
        DtMeshTile tile;
        if (lastRef == 0)
        {
            // Make sure we could allocate a tile.
            if (0 == availableTiles.Count)
            {
                throw new Exception("Could not allocate a tile");
            }

            tile = availableTiles.First?.Value;
            availableTiles.RemoveFirst();
            m_tileCount++;
        }
        else
        {
            // Try to relocate the tile to specific index with same salt.
            var tileIndex = DecodePolyIdTile(lastRef);
            if (tileIndex >= m_maxTiles)
            {
                throw new Exception("Tile index too high");
            }

            // Try to find the specific tile id from the free list.
            var target = m_tiles[tileIndex];
            // Remove from freelist
            if (!availableTiles.Remove(target))
            {
                // Could not find the correct location.
                throw new Exception("Could not find tile");
            }

            tile = target;
            // Restore salt.
            tile.salt = DecodePolyIdSalt(lastRef);
        }

        tile.data = data;
        tile.flags = flags;
        tile.links.Clear();
        tile.polyLinks = new int[data.Polys.Length];
        Array.Fill(tile.polyLinks, DtNavMesh.DT_NULL_LINK);

        // Insert tile into the position lut.
        GetTileListByPos(header.x, header.y).Add(tile);

        // Patch header pointers.

        // If there are no items in the bvtree, reset the tree pointer.
        if (tile.data.BvTree != null && tile.data.BvTree.Length == 0)
        {
            tile.data.BvTree = null;
        }

        // Init tile.

        ConnectIntLinks(tile);
        // Base off-mesh connections to their starting polygons and connect connections inside the tile.
        BaseOffMeshLinks(tile);
        ConnectExtOffMeshLinks(tile, tile, -1);

        // Connect with layers in current tile.
        var neis = GetTilesAt(header.x, header.y);
        for (var j = 0; j < neis.Count; ++j)
        {
            if (neis[j] == tile)
            {
                continue;
            }

            ConnectExtLinks(tile, neis[j], -1);
            ConnectExtLinks(neis[j], tile, -1);
            ConnectExtOffMeshLinks(tile, neis[j], -1);
            ConnectExtOffMeshLinks(neis[j], tile, -1);
        }

        // Connect with neighbour tiles.
        for (var i = 0; i < 8; ++i)
        {
            neis = GetNeighbourTilesAt(header.x, header.y, i);
            for (var j = 0; j < neis.Count; ++j)
            {
                ConnectExtLinks(tile, neis[j], i);
                ConnectExtLinks(neis[j], tile, DtUtils.OppositeTile(i));
                ConnectExtOffMeshLinks(tile, neis[j], i);
                ConnectExtOffMeshLinks(neis[j], tile, DtUtils.OppositeTile(i));
            }
        }

        return GetTileRef(tile);
    }

    /// Removes the specified tile from the navigation mesh.
    /// @param[in] ref The reference of the tile to remove.
    /// @param[out] data Data associated with deleted tile.
    /// @param[out] dataSize Size of the data associated with deleted tile.
    ///
    /// This function returns the data for the tile so that, if desired,
    /// it can be added back to the navigation mesh at a later point.
    ///
    /// @see #addTile
    public long RemoveTile(long refs)
    {
        if (refs == 0)
        {
            return 0;
        }

        var tileIndex = DecodePolyIdTile(refs);
        var tileSalt = DecodePolyIdSalt(refs);
        if (tileIndex >= m_maxTiles)
        {
            throw new Exception("Invalid tile index");
        }

        var tile = m_tiles[tileIndex];
        if (tile.salt != tileSalt)
        {
            throw new Exception("Invalid tile salt");
        }

        // Remove tile from hash lookup.
        _ = GetTileListByPos(tile.data.Header.x, tile.data.Header.y).Remove(tile);

        // Remove connections to neighbour tiles.
        // Create connections with neighbour tiles.

        // Disconnect from other layers in current tile.
        var nneis = GetTilesAt(tile.data.Header.x, tile.data.Header.y);
        foreach (var j in nneis)
        {
            if (j == tile)
            {
                continue;
            }

            UnconnectLinks(j, tile);
        }

        // Disconnect from neighbour tiles.
        for (var i = 0; i < 8; ++i)
        {
            nneis = GetNeighbourTilesAt(tile.data.Header.x, tile.data.Header.y, i);
            foreach (var j in nneis)
            {
                UnconnectLinks(j, tile);
            }
        }

        // Reset tile.
        tile.data = null;

        tile.flags = 0;
        tile.links.Clear();
        tile.linksFreeList = DtNavMesh.DT_NULL_LINK;

        // Update salt, salt should never be zero.
        tile.salt = (tile.salt + 1) & ((1 << DT_SALT_BITS) - 1);
        if (tile.salt == 0)
        {
            tile.salt++;
        }

        // Add to free list.
        _ = availableTiles.AddFirst(tile);
        m_tileCount--;
        return GetTileRef(tile);
    }

    /// Builds internal polygons links for a tile.
    private void ConnectIntLinks(DtMeshTile tile)
    {
        if (tile == null)
        {
            return;
        }

        var @base = GetPolyRefBase(tile);

        for (var i = 0; i < tile.data.Header.polyCount; ++i)
        {
            var poly = tile.data.Polys[i];
            tile.polyLinks[poly.index] = DT_NULL_LINK;

            if (poly.GetPolyType() == DtPolyTypes.DT_POLYTYPE_OFFMESH_CONNECTION)
            {
                continue;
            }

            // Build edge links backwards so that the links will be
            // in the linked list from lowest index to highest.
            for (var j = poly.vertCount - 1; j >= 0; --j)
            {
                // Skip hard and non-internal edges.
                if (poly.neis[j] == 0 || (poly.neis[j] & DT_EXT_LINK) != 0)
                {
                    continue;
                }

                var idx = AllocLink(tile);
                var link = tile.links[idx];
                link.refs = @base | (long)(poly.neis[j] - 1);
                link.edge = j;
                link.side = 0xff;
                link.bmin = link.bmax = 0;
                // Add to linked list.
                link.next = tile.polyLinks[poly.index];
                tile.polyLinks[poly.index] = idx;
            }
        }
    }

    private void UnconnectLinks(DtMeshTile tile, DtMeshTile target)
    {
        if (tile == null || target == null)
        {
            return;
        }

        var targetNum = DecodePolyIdTile(GetTileRef(target));

        for (var i = 0; i < tile.data.Header.polyCount; ++i)
        {
            var poly = tile.data.Polys[i];
            var j = tile.polyLinks[poly.index];
            var pj = DT_NULL_LINK;
            while (j != DT_NULL_LINK)
            {
                if (DecodePolyIdTile(tile.links[j].refs) == targetNum)
                {
                    // Remove link.
                    var nj = tile.links[j].next;
                    if (pj == DT_NULL_LINK)
                    {
                        tile.polyLinks[poly.index] = nj;
                    }
                    else
                    {
                        tile.links[pj].next = nj;
                    }

                    FreeLink(tile, j);
                    j = nj;
                }
                else
                {
                    // Advance
                    pj = j;
                    j = tile.links[j].next;
                }
            }
        }
    }

    private void ConnectExtLinks(DtMeshTile tile, DtMeshTile target, int side)
    {
        if (tile == null)
        {
            return;
        }

        var connectPolys = new List<DtConnectPoly>();

        // Connect border links.
        for (var i = 0; i < tile.data.Header.polyCount; ++i)
        {
            var poly = tile.data.Polys[i];

            // Create new links.
            // short m = DT_EXT_LINK | (short)side;

            var nv = poly.vertCount;
            for (var j = 0; j < nv; ++j)
            {
                // Skip non-portal edges.
                if ((poly.neis[j] & DT_EXT_LINK) == 0)
                {
                    continue;
                }

                var dir = poly.neis[j] & 0xff;
                if (side != -1 && dir != side)
                {
                    continue;
                }

                // Create new links
                var va = poly.verts[j] * 3;
                var vb = poly.verts[(j + 1) % nv] * 3;

                _ = FindConnectingPolys(tile.data.Verts, va, vb, target, DtUtils.OppositeTile(dir), ref connectPolys);
                foreach (var connectPoly in connectPolys)
                {
                    var idx = AllocLink(tile);
                    var link = tile.links[idx];
                    link.refs = connectPoly.refs;
                    link.edge = j;
                    link.side = dir;

                    link.next = tile.polyLinks[poly.index];
                    tile.polyLinks[poly.index] = idx;

                    // Compress portal limits to a byte value.
                    if (dir is 0 or 4)
                    {
                        var tmin = (connectPoly.tmin - tile.data.Verts[va + 2])
                                     / (tile.data.Verts[vb + 2] - tile.data.Verts[va + 2]);
                        var tmax = (connectPoly.tmax - tile.data.Verts[va + 2])
                                     / (tile.data.Verts[vb + 2] - tile.data.Verts[va + 2]);
                        if (tmin > tmax)
                        {
                            (tmax, tmin) = (tmin, tmax);
                        }

                        link.bmin = (int)MathF.Round(Math.Clamp(tmin, 0.0f, 1.0f) * 255.0f);
                        link.bmax = (int)MathF.Round(Math.Clamp(tmax, 0.0f, 1.0f) * 255.0f);
                    }
                    else if (dir is 2 or 6)
                    {
                        var tmin = (connectPoly.tmin - tile.data.Verts[va])
                                     / (tile.data.Verts[vb] - tile.data.Verts[va]);
                        var tmax = (connectPoly.tmax - tile.data.Verts[va])
                                     / (tile.data.Verts[vb] - tile.data.Verts[va]);
                        if (tmin > tmax)
                        {
                            (tmax, tmin) = (tmin, tmax);
                        }

                        link.bmin = (int)MathF.Round(Math.Clamp(tmin, 0.0f, 1.0f) * 255.0f);
                        link.bmax = (int)MathF.Round(Math.Clamp(tmax, 0.0f, 1.0f) * 255.0f);
                    }
                }
            }
        }
    }

    private void ConnectExtOffMeshLinks(DtMeshTile tile, DtMeshTile target, int side)
    {
        if (tile == null)
        {
            return;
        }

        // Connect off-mesh links.
        // We are interested on links which land from target tile to this tile.
        var oppositeSide = (side == -1) ? 0xff : DtUtils.OppositeTile(side);

        for (var i = 0; i < target.data.Header.offMeshConCount; ++i)
        {
            var targetCon = target.data.OffMeshCons[i];
            if (targetCon.side != oppositeSide)
            {
                continue;
            }

            var targetPoly = target.data.Polys[targetCon.poly];
            // Skip off-mesh connections which start location could not be
            // connected at all.
            if (target.polyLinks[targetPoly.index] == DT_NULL_LINK)
            {
                continue;
            }

            var ext = new RcVec3f()
            {
                X = targetCon.rad,
                Y = target.data.Header.walkableClimb,
                Z = targetCon.rad
            };

            // Find polygon to connect to.
            var p = new RcVec3f
            {
                X = targetCon.pos[3],
                Y = targetCon.pos[4],
                Z = targetCon.pos[5]
            };
            var refs = FindNearestPolyInTile(tile, p, ext, out var nearestPt);
            if (refs == 0)
            {
                continue;
            }

            // findNearestPoly may return too optimistic results, further check
            // to make sure.

            if (RcMath.Sqr(nearestPt.X - p.X) + RcMath.Sqr(nearestPt.Z - p.Z) > RcMath.Sqr(targetCon.rad))
            {
                continue;
            }

            // Make sure the location is on current mesh.
            target.data.Verts[targetPoly.verts[1] * 3] = nearestPt.X;
            target.data.Verts[(targetPoly.verts[1] * 3) + 1] = nearestPt.Y;
            target.data.Verts[(targetPoly.verts[1] * 3) + 2] = nearestPt.Z;

            // Link off-mesh connection to target poly.
            var idx = AllocLink(target);
            var link = target.links[idx];
            link.refs = refs;
            link.edge = 1;
            link.side = oppositeSide;
            link.bmin = link.bmax = 0;
            // Add to linked list.
            link.next = target.polyLinks[targetPoly.index];
            target.polyLinks[targetPoly.index] = idx;

            // Link target poly to off-mesh connection.
            if ((targetCon.flags & DT_OFFMESH_CON_BIDIR) != 0)
            {
                var tidx = AllocLink(tile);
                var landPolyIdx = DecodePolyIdPoly(refs);
                var landPoly = tile.data.Polys[landPolyIdx];
                link = tile.links[tidx];
                link.refs = GetPolyRefBase(target) | (long)targetCon.poly;
                link.edge = 0xff;
                link.side = side == -1 ? 0xff : side;
                link.bmin = link.bmax = 0;
                // Add to linked list.
                link.next = tile.polyLinks[landPoly.index];
                tile.polyLinks[landPoly.index] = tidx;
            }
        }
    }

    private int FindConnectingPolys(float[] verts, int va, int vb, DtMeshTile tile, int side,
        ref List<DtConnectPoly> cons)
    {
        if (tile == null)
            return 0;

        cons.Clear();

        var amin = RcVec2f.Zero;
        var amax = RcVec2f.Zero;
        CalcSlabEndPoints(verts, va, vb, ref amin, ref amax, side);
        var apos = GetSlabCoord(verts, va, side);

        // Remove links pointing to 'side' and compact the links array.
        var bmin = RcVec2f.Zero;
        var bmax = RcVec2f.Zero;
        var m = DT_EXT_LINK | side;
        var n = 0;
        var @base = GetPolyRefBase(tile);

        for (var i = 0; i < tile.data.Header.polyCount; ++i)
        {
            var poly = tile.data.Polys[i];
            var nv = poly.vertCount;
            for (var j = 0; j < nv; ++j)
            {
                // Skip edges which do not point to the right side.
                if (poly.neis[j] != m)
                {
                    continue;
                }

                var vc = poly.verts[j] * 3;
                var vd = poly.verts[(j + 1) % nv] * 3;
                var bpos = GetSlabCoord(tile.data.Verts, vc, side);
                // Segments are not close enough.
                if (MathF.Abs(apos - bpos) > 0.01f)
                {
                    continue;
                }

                // Check if the segments touch.
                CalcSlabEndPoints(tile.data.Verts, vc, vd, ref bmin, ref bmax, side);

                if (!OverlapSlabs(amin, amax, bmin, bmax, 0.01f, tile.data.Header.walkableClimb))
                {
                    continue;
                }

                // Add return value.
                var refs = @base | (long)i;
                var tmin = Math.Max(amin.X, bmin.X);
                var tmax = Math.Min(amax.X, bmax.X);
                cons.Add(new DtConnectPoly(refs, tmin, tmax));
                n++;
                break;
            }
        }

        return n;
    }

    private static float GetSlabCoord(float[] verts, int va, int side)
    {
        if (side is 0 or 4)
        {
            return verts[va];
        }
        else if (side is 2 or 6)
        {
            return verts[va + 2];
        }

        return 0;
    }

    private static void CalcSlabEndPoints(float[] verts, int va, int vb, ref RcVec2f bmin, ref RcVec2f bmax, int side)
    {
        if (side is 0 or 4)
        {
            if (verts[va + 2] < verts[vb + 2])
            {
                bmin.X = verts[va + 2];
                bmin.Y = verts[va + 1];
                bmax.X = verts[vb + 2];
                bmax.Y = verts[vb + 1];
            }
            else
            {
                bmin.X = verts[vb + 2];
                bmin.Y = verts[vb + 1];
                bmax.X = verts[va + 2];
                bmax.Y = verts[va + 1];
            }
        }
        else if (side is 2 or 6)
        {
            if (verts[va + 0] < verts[vb + 0])
            {
                bmin.X = verts[va + 0];
                bmin.Y = verts[va + 1];
                bmax.X = verts[vb + 0];
                bmax.Y = verts[vb + 1];
            }
            else
            {
                bmin.X = verts[vb + 0];
                bmin.Y = verts[vb + 1];
                bmax.X = verts[va + 0];
                bmax.Y = verts[va + 1];
            }
        }
    }

    private bool OverlapSlabs(RcVec2f amin, RcVec2f amax, RcVec2f bmin, RcVec2f bmax, float px, float py)
    {
        // Check for horizontal overlap.
        // The segment is shrunken a little so that slabs which touch
        // at end points are not connected.
        var minx = Math.Max(amin.X + px, bmin.X + px);
        var maxx = Math.Min(amax.X - px, bmax.X - px);
        if (minx > maxx)
        {
            return false;
        }

        // Check vertical overlap.
        var ad = (amax.Y - amin.Y) / (amax.X - amin.X);
        var ak = amin.Y - (ad * amin.X);
        var bd = (bmax.Y - bmin.Y) / (bmax.X - bmin.X);
        var bk = bmin.Y - (bd * bmin.X);
        var aminy = (ad * minx) + ak;
        var amaxy = (ad * maxx) + ak;
        var bminy = (bd * minx) + bk;
        var bmaxy = (bd * maxx) + bk;
        var dmin = bminy - aminy;
        var dmax = bmaxy - amaxy;

        // Crossing segments always overlap.
        if (dmin * dmax < 0)
        {
            return true;
        }

        // Check for overlap at endpoints.
        var thr = py * 2 * (py * 2);
        return dmin * dmin <= thr || dmax * dmax <= thr;
    }

    /**
 * Builds internal polygons links for a tile.
 *
 * @param tile
 */
    private void BaseOffMeshLinks(DtMeshTile tile)
    {
        if (tile == null)
        {
            return;
        }

        var @base = GetPolyRefBase(tile);

        // Base off-mesh connection start points.
        for (var i = 0; i < tile.data.Header.offMeshConCount; ++i)
        {
            var con = tile.data.OffMeshCons[i];
            var poly = tile.data.Polys[con.poly];

            var ext = new RcVec3f()
            {
                X = con.rad,
                Y = tile.data.Header.walkableClimb,
                Z = con.rad,
            };

            // Find polygon to connect to.
            var refs = FindNearestPolyInTile(tile, new RcVec3f(con.pos[0], con.pos[1], con.pos[2]), ext, out var nearestPt);
            if (refs == 0)
            {
                continue;
            }

            var p = con.pos; // First vertex
            // findNearestPoly may return too optimistic results, further check
            // to make sure.
            if (RcMath.Sqr(nearestPt.X - p[0]) + RcMath.Sqr(nearestPt.Z - p[2]) > RcMath.Sqr(con.rad))
            {
                continue;
            }

            // Make sure the location is on current mesh.
            tile.data.Verts[poly.verts[0] * 3] = nearestPt.X;
            tile.data.Verts[(poly.verts[0] * 3) + 1] = nearestPt.Y;
            tile.data.Verts[(poly.verts[0] * 3) + 2] = nearestPt.Z;

            // Link off-mesh connection to target poly.
            var idx = AllocLink(tile);
            var link = tile.links[idx];
            link.refs = refs;
            link.edge = 0;
            link.side = 0xff;
            link.bmin = link.bmax = 0;
            // Add to linked list.
            link.next = tile.polyLinks[poly.index];
            tile.polyLinks[poly.index] = idx;

            // Start end-point is always connect back to off-mesh connection.
            var tidx = AllocLink(tile);
            var landPolyIdx = DecodePolyIdPoly(refs);
            var landPoly = tile.data.Polys[landPolyIdx];
            link = tile.links[tidx];
            link.refs = @base | (long)con.poly;
            link.edge = 0xff;
            link.side = 0xff;
            link.bmin = link.bmax = 0;
            // Add to linked list.
            link.next = tile.polyLinks[landPoly.index];
            tile.polyLinks[landPoly.index] = tidx;
        }
    }

    /**
 * Returns closest point on polygon.
 *
 * @param ref
 * @param pos
 * @return
 */
    private RcVec3f ClosestPointOnDetailEdges(DtMeshTile tile, DtPoly poly, RcVec3f pos, bool onlyBoundary)
    {
        var ANY_BOUNDARY_EDGE = (DtDetailTriEdgeFlags.DT_DETAIL_EDGE_BOUNDARY << 0) |
                                (DtDetailTriEdgeFlags.DT_DETAIL_EDGE_BOUNDARY << 2) |
                                (DtDetailTriEdgeFlags.DT_DETAIL_EDGE_BOUNDARY << 4);
        var ip = poly.index;
        var dmin = float.MaxValue;
        float tmin = 0;
        var pmin = new RcVec3f();
        var pmax = new RcVec3f();

        if (tile.data.DetailMeshes != null)
        {
            var pd = tile.data.DetailMeshes[ip];
            for (var i = 0; i < pd.triCount; i++)
            {
                var ti = (pd.triBase + i) * 4;
                var tris = tile.data.DetailTris;
                if (onlyBoundary && (tris[ti + 3] & ANY_BOUNDARY_EDGE) == 0)
                {
                    continue;
                }

                var v = new RcVec3f[3];
                for (var j = 0; j < 3; ++j)
                {
                    if (tris[ti + j] < poly.vertCount)
                    {
                        var index = poly.verts[tris[ti + j]] * 3;
                        v[j] = new RcVec3f
                        {
                            X = tile.data.Verts[index],
                            Y = tile.data.Verts[index + 1],
                            Z = tile.data.Verts[index + 2]
                        };
                    }
                    else
                    {
                        var index = (pd.vertBase + (tris[ti + j] - poly.vertCount)) * 3;
                        v[j] = new RcVec3f
                        {
                            X = tile.data.DetailVerts[index],
                            Y = tile.data.DetailVerts[index + 1],
                            Z = tile.data.DetailVerts[index + 2]
                        };
                    }
                }

                for (int k = 0, j = 2; k < 3; j = k++)
                {
                    if ((GetDetailTriEdgeFlags(tris[ti + 3], j) & DtDetailTriEdgeFlags.DT_DETAIL_EDGE_BOUNDARY) == 0
                        && (onlyBoundary || tris[ti + j] < tris[ti + k]))
                    {
                        // Only looking at boundary edges and this is internal, or
                        // this is an inner edge that we will see again or have already seen.
                        continue;
                    }

                    var d = DtUtils.DistancePtSegSqr2D(pos, v[j], v[k], out var t);
                    if (d < dmin)
                    {
                        dmin = d;
                        tmin = t;
                        pmin = v[j];
                        pmax = v[k];
                    }
                }
            }
        }
        else
        {
            var v = new RcVec3f[2];
            for (var j = 0; j < poly.vertCount; ++j)
            {
                var k = (j + 1) % poly.vertCount;
                v[0].X = tile.data.Verts[poly.verts[j] * 3];
                v[0].Y = tile.data.Verts[(poly.verts[j] * 3) + 1];
                v[0].Z = tile.data.Verts[(poly.verts[j] * 3) + 2];
                v[1].X = tile.data.Verts[poly.verts[k] * 3];
                v[1].Y = tile.data.Verts[(poly.verts[k] * 3) + 1];
                v[1].Z = tile.data.Verts[(poly.verts[k] * 3) + 2];

                var d = DtUtils.DistancePtSegSqr2D(pos, v[0], v[1], out var t);
                if (d < dmin)
                {
                    dmin = d;
                    tmin = t;
                    pmin = v[0];
                    pmax = v[1];
                }
            }
        }

        return RcVec3f.Lerp(pmin, pmax, tmin);
    }

    public bool GetPolyHeight(DtMeshTile tile, DtPoly poly, RcVec3f pos, out float height)
    {
        height = 0;

        // Off-mesh connections do not have detail polys and getting height
        // over them does not make sense.
        if (poly.GetPolyType() == DtPolyTypes.DT_POLYTYPE_OFFMESH_CONNECTION)
        {
            return false;
        }

        var ip = poly.index;

        var verts = new float[m_maxVertPerPoly * 3];
        var nv = poly.vertCount;
        for (var i = 0; i < nv; ++i)
        {
            Array.Copy(tile.data.Verts, poly.verts[i] * 3, verts, i * 3, 3);
        }

        if (!DtUtils.PointInPolygon(pos, verts, nv))
        {
            return false;
        }

        // Find height at the location.
        if (tile.data.DetailMeshes != null)
        {
            var pd = tile.data.DetailMeshes[ip];
            for (var j = 0; j < pd.triCount; ++j)
            {
                var t = (pd.triBase + j) * 4;
                var v = new RcVec3f[3];
                for (var k = 0; k < 3; ++k)
                {
                    if (tile.data.DetailTris[t + k] < poly.vertCount)
                    {
                        var index = poly.verts[tile.data.DetailTris[t + k]] * 3;
                        v[k] = new RcVec3f
                        {
                            X = tile.data.Verts[index],
                            Y = tile.data.Verts[index + 1],
                            Z = tile.data.Verts[index + 2]
                        };
                    }
                    else
                    {
                        var index = (pd.vertBase + (tile.data.DetailTris[t + k] - poly.vertCount)) * 3;
                        v[k] = new RcVec3f
                        {
                            X = tile.data.DetailVerts[index],
                            Y = tile.data.DetailVerts[index + 1],
                            Z = tile.data.DetailVerts[index + 2]
                        };
                    }
                }

                if (DtUtils.ClosestHeightPointTriangle(pos, v[0], v[1], v[2], out var h))
                {
                    height = h;
                    return true;
                }
            }
        }
        else
        {
            var v = new RcVec3f[3];
            v[0].X = tile.data.Verts[poly.verts[0] * 3];
            v[0].Y = tile.data.Verts[(poly.verts[0] * 3) + 1];
            v[0].Z = tile.data.Verts[(poly.verts[0] * 3) + 2];
            for (var j = 1; j < poly.vertCount - 1; ++j)
            {
                for (var k = 0; k < 2; ++k)
                {
                    v[k + 1].X = tile.data.Verts[poly.verts[j + k] * 3];
                    v[k + 1].Y = tile.data.Verts[(poly.verts[j + k] * 3) + 1];
                    v[k + 1].Z = tile.data.Verts[(poly.verts[j + k] * 3) + 2];
                }

                if (DtUtils.ClosestHeightPointTriangle(pos, v[0], v[1], v[2], out var h))
                {
                    height = h;
                    return true;
                }
            }
        }

        // If all triangle checks failed above (can happen with degenerate triangles
        // or larger floating point values) the point is on an edge, so just select
        // closest. This should almost never happen so the extra iteration here is
        // ok.
        var closest = ClosestPointOnDetailEdges(tile, poly, pos, false);
        height = closest.Y;
        return true;
    }

    public void ClosestPointOnPoly(long refs, RcVec3f pos, out RcVec3f closest, out bool posOverPoly)
    {
        GetTileAndPolyByRefUnsafe(refs, out var tile, out var poly);
        closest = pos;

        if (GetPolyHeight(tile, poly, pos, out var h))
        {
            closest.Y = h;
            posOverPoly = true;
            return;
        }

        posOverPoly = false;

        // Off-mesh connections don't have detail polygons.
        if (poly.GetPolyType() == DtPolyTypes.DT_POLYTYPE_OFFMESH_CONNECTION)
        {
            var i = poly.verts[0] * 3;
            var v0 = new RcVec3f { X = tile.data.Verts[i], Y = tile.data.Verts[i + 1], Z = tile.data.Verts[i + 2] };
            i = poly.verts[1] * 3;
            var v1 = new RcVec3f { X = tile.data.Verts[i], Y = tile.data.Verts[i + 1], Z = tile.data.Verts[i + 2] };
            _ = DtUtils.DistancePtSegSqr2D(pos, v0, v1, out var t);
            closest = RcVec3f.Lerp(v0, v1, t);
            return;
        }

        // Outside poly that is not an offmesh connection.
        closest = ClosestPointOnDetailEdges(tile, poly, pos, true);
    }

    /// Find nearest polygon within a tile.
    private long FindNearestPolyInTile(DtMeshTile tile, RcVec3f center, RcVec3f halfExtents, out RcVec3f nearestPt)
    {
        nearestPt = RcVec3f.Zero;

        var bmin = RcVec3f.Subtract(center, halfExtents);
        var bmax = RcVec3f.Add(center, halfExtents);

        // Get nearby polygons from proximity grid.
        var polys = QueryPolygonsInTile(tile, bmin, bmax);

        // Find nearest polygon amongst the nearby polygons.
        long nearest = 0;
        var nearestDistanceSqr = float.MaxValue;
        for (var i = 0; i < polys.Count; ++i)
        {
            var refs = polys[i];
            float d;
            ClosestPointOnPoly(refs, center, out var closestPtPoly, out var posOverPoly);

            // If a point is directly over a polygon and closer than
            // climb height, favor that instead of straight line nearest point.
            var diff = RcVec3f.Subtract(center, closestPtPoly);
            if (posOverPoly)
            {
                d = MathF.Abs(diff.Y) - tile.data.Header.walkableClimb;
                d = d > 0 ? d * d : 0;
            }
            else
            {
                d = diff.LengthSquared();
            }

            if (d < nearestDistanceSqr)
            {
                nearestPt = closestPtPoly;
                nearestDistanceSqr = d;
                nearest = refs;
            }
        }

        return nearest;
    }

    private DtMeshTile GetTileAt(int x, int y, int layer)
    {
        foreach (var tile in GetTileListByPos(x, y))
        {
            if (tile.data.Header != null && tile.data.Header.x == x && tile.data.Header.y == y
                && tile.data.Header.layer == layer)
            {
                return tile;
            }
        }

        return null;
    }

    private List<DtMeshTile> GetNeighbourTilesAt(int x, int y, int side)
    {
        int nx = x, ny = y;
        switch (side)
        {
            case 0:
                nx++;
                break;
            case 1:
                nx++;
                ny++;
                break;
            case 2:
                ny++;
                break;
            case 3:
                nx--;
                ny++;
                break;
            case 4:
                nx--;
                break;
            case 5:
                nx--;
                ny--;
                break;
            case 6:
                ny--;
                break;
            case 7:
                nx++;
                ny--;
                break;
        }

        return GetTilesAt(nx, ny);
    }

    public List<DtMeshTile> GetTilesAt(int x, int y)
    {
        List<DtMeshTile> tiles = [];
        foreach (var tile in GetTileListByPos(x, y))
        {
            if (tile.data.Header != null && tile.data.Header.x == x && tile.data.Header.y == y)
            {
                tiles.Add(tile);
            }
        }

        return tiles;
    }

    public long GetTileRefAt(int x, int y, int layer) => GetTileRef(GetTileAt(x, y, layer));

    public DtMeshTile GetTileByRef(long refs)
    {
        if (refs == 0)
        {
            return null;
        }

        var tileIndex = DecodePolyIdTile(refs);
        var tileSalt = DecodePolyIdSalt(refs);
        if (tileIndex >= m_maxTiles)
        {
            return null;
        }

        var tile = m_tiles[tileIndex];
        return tile.salt != tileSalt ? null : tile;
    }

    public long GetTileRef(DtMeshTile tile) => tile == null ? 0 : EncodePolyId(tile.salt, tile.index, 0);

    public static int ComputeTileHash(int x, int y, int mask)
    {
        var h1 = 0x8da6b343; // Large multiplicative constants;
        var h2 = 0xd8163841; // here arbitrarily chosen primes
        var n = (h1 * (uint)x) + (h2 * (uint)y);
        return (int)(n & mask);
    }

    /// Gets the endpoints for an off-mesh connection, ordered by "direction of travel".
    ///  @param[in]		prevRef		The reference of the polygon before the connection.
    ///  @param[in]		polyRef		The reference of the off-mesh connection polygon.
    ///  @param[out]	startPos	The start position of the off-mesh connection. [(x, y, z)]
    ///  @param[out]	endPos		The end position of the off-mesh connection. [(x, y, z)]
    /// @return The status flags for the operation.
    /// 
    /// @par
    ///
    /// Off-mesh connections are stored in the navigation mesh as special 2-vertex 
    /// polygons with a single edge. At least one of the vertices is expected to be 
    /// inside a normal polygon. So an off-mesh connection is "entered" from a 
    /// normal polygon at one of its endpoints. This is the polygon identified by 
    /// the prevRef parameter.
    public DtStatus GetOffMeshConnectionPolyEndPoints(long prevRef, long polyRef, ref RcVec3f startPos, ref RcVec3f endPos)
    {
        if (polyRef == 0)
        {
            return DtStatus.DT_FAILURE;
        }

        // Get current polygon
        DecodePolyId(polyRef, out var salt, out var it, out var ip);
        if (it >= m_maxTiles)
        {
            return DtStatus.DT_FAILURE | DtStatus.DT_INVALID_PARAM;
        }

        if (m_tiles[it].salt != salt || m_tiles[it].data.Header == null)
        {
            return DtStatus.DT_FAILURE | DtStatus.DT_INVALID_PARAM;
        }

        var tile = m_tiles[it];
        if (ip >= tile.data.Header.polyCount)
        {
            return DtStatus.DT_FAILURE | DtStatus.DT_INVALID_PARAM;
        }

        var poly = tile.data.Polys[ip];

        // Make sure that the current poly is indeed off-mesh link.
        if (poly.GetPolyType() != DtPolyTypes.DT_POLYTYPE_OFFMESH_CONNECTION)
        {
            return DtStatus.DT_FAILURE;
        }

        // Figure out which way to hand out the vertices.
        int idx0 = 0, idx1 = 1;

        // Find link that points to first vertex.
        for (var i = tile.polyLinks[poly.index]; i != DT_NULL_LINK; i = tile.links[i].next)
        {
            if (tile.links[i].edge == 0)
            {
                if (tile.links[i].refs != prevRef)
                {
                    idx0 = 1;
                    idx1 = 0;
                }

                break;
            }
        }

        startPos = new RcVec3f(tile.data.Verts.AsSpan(poly.verts[idx0] * 3));
        endPos = new RcVec3f(tile.data.Verts.AsSpan(poly.verts[idx1] * 3));

        return DtStatus.DT_SUCCSESS;
    }

    public int GetMaxVertsPerPoly() => m_maxVertPerPoly;

    public int GetTileCount() => m_tileCount;

    public int GetAvailableTileCount() => availableTiles.Count;

    public DtStatus SetPolyFlags(long refs, int flags)
    {
        if (refs == 0)
        {
            return DtStatus.DT_FAILURE;
        }

        DecodePolyId(refs, out var salt, out var it, out var ip);
        if (it >= m_maxTiles)
        {
            return DtStatus.DT_INVALID_PARAM;
        }

        if (m_tiles[it].salt != salt || m_tiles[it].data == null || m_tiles[it].data.Header == null)
        {
            return DtStatus.DT_INVALID_PARAM;
        }

        var tile = m_tiles[it];
        if (ip >= tile.data.Header.polyCount)
        {
            return DtStatus.DT_INVALID_PARAM;
        }

        var poly = tile.data.Polys[ip];

        // Change flags.
        poly.flags = flags;
        return DtStatus.DT_SUCCSESS;
    }

    /// Gets the user defined flags for the specified polygon.
    ///  @param[in]		ref				The polygon reference.
    ///  @param[out]	resultFlags		The polygon flags.
    /// @return The status flags for the operation.
    public DtStatus GetPolyFlags(long refs, out int resultFlags)
    {
        resultFlags = 0;

        if (refs == 0)
        {
            return DtStatus.DT_FAILURE;
        }

        DecodePolyId(refs, out var salt, out var it, out var ip);
        if (it >= m_maxTiles)
        {
            return DtStatus.DT_FAILURE | DtStatus.DT_INVALID_PARAM;
        }

        if (m_tiles[it].salt != salt || m_tiles[it].data == null || m_tiles[it].data.Header == null)
        {
            return DtStatus.DT_FAILURE | DtStatus.DT_INVALID_PARAM;
        }

        var tile = m_tiles[it];
        if (ip >= tile.data.Header.polyCount)
        {
            return DtStatus.DT_FAILURE | DtStatus.DT_INVALID_PARAM;
        }

        var poly = tile.data.Polys[ip];

        resultFlags = poly.flags;

        return DtStatus.DT_SUCCSESS;
    }

    public DtStatus SetPolyArea(long refs, char area)
    {
        if (refs == 0)
        {
            return DtStatus.DT_FAILURE;
        }

        DecodePolyId(refs, out var salt, out var it, out var ip);
        if (it >= m_maxTiles)
        {
            return DtStatus.DT_FAILURE;
        }

        if (m_tiles[it].salt != salt || m_tiles[it].data == null || m_tiles[it].data.Header == null)
        {
            return DtStatus.DT_INVALID_PARAM;
        }

        var tile = m_tiles[it];
        if (ip >= tile.data.Header.polyCount)
        {
            return DtStatus.DT_INVALID_PARAM;
        }

        var poly = tile.data.Polys[ip];

        poly.SetArea(area);

        return DtStatus.DT_SUCCSESS;
    }

    public DtStatus GetPolyArea(long refs, out int resultArea)
    {
        resultArea = 0;

        if (refs == 0)
        {
            return DtStatus.DT_FAILURE;
        }

        DecodePolyId(refs, out var salt, out var it, out var ip);
        if (it >= m_maxTiles)
        {
            return DtStatus.DT_FAILURE | DtStatus.DT_INVALID_PARAM;
        }

        if (m_tiles[it].salt != salt || m_tiles[it].data == null || m_tiles[it].data.Header == null)
        {
            return DtStatus.DT_FAILURE | DtStatus.DT_INVALID_PARAM;
        }

        var tile = m_tiles[it];
        if (ip >= tile.data.Header.polyCount)
        {
            return DtStatus.DT_FAILURE | DtStatus.DT_INVALID_PARAM;
        }

        var poly = tile.data.Polys[ip];
        resultArea = poly.GetArea();

        return DtStatus.DT_SUCCSESS;
    }

    public RcVec3f GetPolyCenter(long refs)
    {
        var center = RcVec3f.Zero;

        var status = GetTileAndPolyByRef(refs, out var tile, out var poly);
        if (status.Succeeded())
        {
            for (var i = 0; i < poly.vertCount; ++i)
            {
                var v = poly.verts[i] * 3;
                center.X += tile.data.Verts[v];
                center.Y += tile.data.Verts[v + 1];
                center.Z += tile.data.Verts[v + 2];
            }

            var s = 1.0f / poly.vertCount;
            center.X *= s;
            center.Y *= s;
            center.Z *= s;
        }

        return center;
    }

    /**
 * Get flags for edge in detail triangle.
 *
 * @param triFlags
 *            The flags for the triangle (last component of detail vertices above).
 * @param edgeIndex
 *            The index of the first vertex of the edge. For instance, if 0,
 * @return flags for edge AB.
 */
    public static int GetDetailTriEdgeFlags(int triFlags, int edgeIndex) => (triFlags >> (edgeIndex * 2)) & 0x3;

    private List<DtMeshTile> GetTileListByPos(int x, int z)
    {
        var tileHash = ComputeTileHash(x, z, m_tileLutMask);
        if (!posLookup.TryGetValue(tileHash, out var tiles))
        {
            tiles = [];
            posLookup.Add(tileHash, tiles);
        }

        return tiles;
    }

    public void ComputeBounds(out RcVec3f bmin, out RcVec3f bmax)
    {
        bmin = new RcVec3f(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
        bmax = new RcVec3f(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        for (var t = 0; t < GetMaxTiles(); ++t)
        {
            var tile = GetTile(t);
            if (tile != null && tile.data != null)
            {
                for (var i = 0; i < tile.data.Verts.Length; i += 3)
                {
                    bmin.X = Math.Min(bmin.X, tile.data.Verts[i]);
                    bmin.Y = Math.Min(bmin.Y, tile.data.Verts[i + 1]);
                    bmin.Z = Math.Min(bmin.Z, tile.data.Verts[i + 2]);
                    bmax.X = Math.Max(bmax.X, tile.data.Verts[i]);
                    bmax.Y = Math.Max(bmax.Y, tile.data.Verts[i + 1]);
                    bmax.Z = Math.Max(bmax.Z, tile.data.Verts[i + 2]);
                }
            }
        }
    }
}