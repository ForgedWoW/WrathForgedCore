// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using DotRecast.Detour;
using WrathForged.Common.Maps;
using WrathForged.Models.Maps;

namespace WrathForged.Instance.Server.Maps;

public class MMapFactory(ClientMMapFileReader clientMMapFileReader)
{
    private readonly ClientMMapFileReader _clientMMapFileReader = clientMMapFileReader;
    private readonly Dictionary<uint, MMapData> _mMapData = [];

    public bool LoadMap(uint mapId, int x, int y)
    {
        if (!LoadMMapFile(mapId))
            return false;

        // get this mmap data
        var mmap = _mMapData[mapId];

        // check if we already have this tile loaded
        var packedGridPos = PackTileID(x, y);

        if (mmap.LoadedTileRefs.ContainsKey(packedGridPos))
            return false;

        var loadedTile = _clientMMapFileReader.LoadMeshData(mapId, x, y);

        if (loadedTile == null)
            return false;

        mmap.LoadedTileRefs[packedGridPos] = mmap.NavMesh.AddTile(loadedTile, 1, 0);
        return true;
    }

    private bool LoadMMapFile(uint mapId)
    {
        if (_mMapData.ContainsKey(mapId))
            return true;

        var mmapData = new MMapData(new DtNavMesh(_clientMMapFileReader.LoadFileParams(mapId)));

        _mMapData[mapId] = mmapData;
        return true;
    }

    private static uint PackTileID(int x, int y) => (uint)((x << 16) | y);
}
