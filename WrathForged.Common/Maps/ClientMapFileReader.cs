// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common.Networking;
using WrathForged.Common.Serialization;
using WrathForged.Models.Maps;
using WrathForged.Models.Maps.MapFiles;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Maps;

public class ClientMapFileReader(ForgedModelSerializer serializer, IConfiguration configuration, ILogger logger)
{
    private readonly ForgedModelSerializer _serializer = serializer;
    private readonly IConfiguration _configuration = configuration;
    private readonly ILogger _logger = logger;

    private static readonly uint[][] _indices =
    [
        [3, 0, 4],
        [0, 1, 4],
        [1, 2, 4],
        [2, 5, 4],
        [5, 8, 4],
        [8, 7, 4],
        [7, 6, 4],
        [6, 3, 4]
    ];
    private static readonly Vector2[] _boundGridCords =
    [
        new(0.0f, 0.0f),
        new(0.0f, -266.66666f),
        new(0.0f, -533.33331f),
        new(-266.66666f, 0.0f),
        new(-266.66666f, -266.66666f),
        new(-266.66666f, -533.33331f),
        new(-533.33331f, 0.0f),
        new(-533.33331f, -266.66666f),
        new(-533.33331f, -533.33331f)
    ];

    public GridMap? ReadMap(string mapName)
    {
        var dataDir = _configuration.GetDefaultValue("Data:DataDir", ".\\WoWData");

        using PacketBuffer packetBuffer = new(File.ReadAllBytes(Path.Combine(dataDir, mapName)), _logger);

        if (_serializer.TryDeserialize<MapFileHeader>(packetBuffer, out var mapFileHeader) == DeserializationResult.Success)
        {
            GridMap gridMap = new()
            {
                FileHeader = mapFileHeader
            };

            ReadAreaMap(mapName, packetBuffer, mapFileHeader, gridMap);
            ReadHeightMap(mapName, packetBuffer, mapFileHeader, gridMap);
            ReadMapLiquidMap(mapName, packetBuffer, mapFileHeader, gridMap);
            ReadMapHolesMap(mapName, packetBuffer, mapFileHeader, gridMap);

            return gridMap;
        }
        else
        {
            _logger.Error("Failed to deserialize map file header for {MapFile}.", mapName);
        }

        return null;
    }

    private void ReadMapHolesMap(string mapName, PacketBuffer packetBuffer, MapFileHeader mapFileHeader, GridMap gridMap)
    {
        if (mapFileHeader.HolesOffset > 0)
        {
            packetBuffer.Reader.BaseStream.Position = mapFileHeader.HolesOffset;

            if (_serializer.TryDeserialize(packetBuffer, out MapHolesData mapHolesData) == DeserializationResult.Success)
            {
                gridMap.HolesData = mapHolesData;
            }
            else
            {
                _logger.Error("Failed to deserialize map holes header for {MapFile}.", mapName);
            }
        }
    }

    private void ReadMapLiquidMap(string mapName, PacketBuffer packetBuffer, MapFileHeader mapFileHeader, GridMap gridMap)
    {
        if (mapFileHeader.LiquidMapOffset > 0)
        {
            packetBuffer.Reader.BaseStream.Position = mapFileHeader.LiquidMapOffset;

            if (_serializer.TryDeserialize(packetBuffer, out MapLiquidData mapLiquidData) == DeserializationResult.Success)
            {
                gridMap.LiquidData = mapLiquidData;
            }
            else
            {
                _logger.Error("Failed to deserialize map liquid header for {MapFile}.", mapName);
            }
        }
    }

    private void ReadHeightMap(string mapName, PacketBuffer packetBuffer, MapFileHeader mapFileHeader, GridMap gridMap)
    {
        if (mapFileHeader.HeightMapOffset > 0)
        {
            packetBuffer.Reader.BaseStream.Position = mapFileHeader.HeightMapOffset;

            if (_serializer.TryDeserialize(packetBuffer, out MapHeightData mapHeightData) == DeserializationResult.Success)
            {
                gridMap.HeightData = mapHeightData;

                if (gridMap.HeightData.Flags.HasFlag(Models.Maps.Enum.MapHeightFlags.HasFlightBounds) &&
                    gridMap.HeightData.MaxHeights != null && gridMap.HeightData.MinHeights != null)
                {

                    for (uint quarterIndex = 0; quarterIndex < 8; ++quarterIndex)
                    {
                        var point1 = new Vector3(
                            _boundGridCords[_indices[quarterIndex][0]].X,
                            _boundGridCords[_indices[quarterIndex][0]].Y,
                            gridMap.HeightData.MinHeights[_indices[quarterIndex][0]]
                        );

                        var point2 = new Vector3(
                            _boundGridCords[_indices[quarterIndex][1]].X,
                            _boundGridCords[_indices[quarterIndex][1]].Y,
                            gridMap.HeightData.MinHeights[_indices[quarterIndex][1]]
                        );

                        var point3 = new Vector3(
                            _boundGridCords[_indices[quarterIndex][2]].X,
                            _boundGridCords[_indices[quarterIndex][2]].Y,
                            gridMap.HeightData.MinHeights[_indices[quarterIndex][2]]
                        );

                        gridMap.HeightData.MinHeightPlanes[quarterIndex] = Plane.CreateFromVertices(point1, point2, point3);
                    }
                }
            }
            else
            {
                _logger.Error("Failed to deserialize map height header for {MapFile}.", mapName);
            }
        }
    }

    private void ReadAreaMap(string mapName, PacketBuffer packetBuffer, MapFileHeader mapFileHeader, GridMap gridMap)
    {
        if (mapFileHeader.AreaMapOffset > 0)
        {
            packetBuffer.Reader.BaseStream.Position = mapFileHeader.AreaMapOffset;

            if (_serializer.TryDeserialize(packetBuffer, out MapAreaData mapAreaData) == DeserializationResult.Success)
            {
                gridMap.AreaData = mapAreaData;
            }
            else
            {
                _logger.Error("Failed to deserialize map area header for {MapFile}.", mapName);
            }
        }
    }
}
