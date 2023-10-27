// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using DotRecast.Detour;
using WrathForged.Common.Maps;
using WrathForged.Database.Models.World;
using WrathForged.Models.Maps;

namespace WrathForged.Instance.Server.Maps;

public class MMapFactory
{
    private readonly ClientMMapFileReader _clientMMapFileReader;
    private readonly Dictionary<uint, MMapData> _mMapData = [];
    private readonly HashSet<uint> _disabledMMaps = [];

    public MMapFactory(ClientMMapFileReader clientMMapFileReader, WorldDatabase worldDatabase)
    {
        _clientMMapFileReader = clientMMapFileReader;

        var disabledMMaps = worldDatabase.Disables.Where(x => x.SourceType == 7);

        foreach (var disabledMMap in disabledMMaps)
            _ = _disabledMMaps.Add(disabledMMap.Entry);
    }

    public bool TryGetMMap(uint mapId, out MMapData mmapData)
    {
        if (_mMapData.TryGetValue(mapId, out var data))
        {
            mmapData = data;
            return true;
        }

        mmapData = default!;
        return false;
    }

    public bool LoadMMap(uint mapId, int x, int y)
    {
        if (_disabledMMaps.Contains(mapId) || !LoadMMapFile(mapId))
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
        if (_disabledMMaps.Contains(mapId))
            return false;

        if (_mMapData.ContainsKey(mapId))
            return true;

        var mmapData = new MMapData(new DtNavMesh(_clientMMapFileReader.LoadFileParams(mapId)));

        _mMapData[mapId] = mmapData;
        return true;
    }

    private static int PackTileID(int x, int y) => (x << 16) | y;
}
