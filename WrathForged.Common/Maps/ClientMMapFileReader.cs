// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Text;
using DotRecast.Detour;
using DotRecast.Detour.Io;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Models.Maps.MapFiles;

namespace WrathForged.Common.Maps;

public class ClientMMapFileReader(IConfiguration configuration, ILogger logger, DtMeshDataReader dtMeshDataReader)
{
    private readonly IConfiguration _configuration = configuration;
    private readonly ILogger _logger = logger;
    private readonly DtMeshDataReader _dtMeshDataReader = dtMeshDataReader;
    private const string MAP_FILE_NAME_FORMAT = "{0:D4}.mmap";
    private const string TILE_FILE_NAME_FORMAT = "{0:D4}{1:D2}{2:D2}.mmtile";

    public DtNavMeshParams LoadFileParams(uint mapId)
    {
        var dataDir = _configuration.GetDefaultValue("Data:DataDir", ".\\WoWData");
        var fileName = string.Format(MAP_FILE_NAME_FORMAT, mapId);
        using BinaryReader reader = new(new FileStream(Path.Combine(dataDir, "mmaps", fileName), FileMode.Open, FileAccess.Read), Encoding.UTF8);

        _logger.Information("Loading mmap file for map {MapId}", mapId);
        return new()
        {
            orig =
            {
                [0] = reader.ReadSingle(),
                [1] = reader.ReadSingle(),
                [2] = reader.ReadSingle()
            },
            tileWidth = reader.ReadSingle(),
            tileHeight = reader.ReadSingle(),
            maxTiles = reader.ReadInt32(),
            maxPolys = reader.ReadInt32()
        };
    }

    public DtMeshData? LoadMeshData(uint mapId, int x, int y)
    {
        var dataDir = _configuration.GetDefaultValue("Data:DataDir", ".\\WoWData");
        var fileName = string.Format(TILE_FILE_NAME_FORMAT, mapId, x, y);
        using BinaryReader reader = new(new FileStream(Path.Combine(dataDir, "mmaps", fileName), FileMode.Open, FileAccess.Read), Encoding.UTF8);
        var mmapTileHeader = new MmapTileHeader()
        {
            DtVersion = reader.ReadUInt32(),
            MMAPMagic = reader.ReadUInt32(),
            MMAPVersion = reader.ReadUInt32(),
            Size = reader.ReadUInt32(),
            UsesLiquids = reader.ReadByte()
        };

        if (mmapTileHeader.MMAPMagic != 0x4d4d4150)
        {
            _logger.Error("Invalid mmap magic for map {MapId} tile {X} {Y}", mapId, x, y);
            return null;
        }

        if (mmapTileHeader.MMAPVersion != 15)
        {
            _logger.Error("Invalid mmap version for map {MapId} tile {X} {Y}", mapId, x, y);
            return null;
        }

        return _dtMeshDataReader.Read(reader);
    }
}
