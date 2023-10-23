// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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

    public void ReadMap(string mapName)
    {
        var dataDir = _configuration.GetDefaultValue("Data:DataDir", ".\\WoWData");

        using PacketBuffer packetBuffer = new(File.ReadAllBytes(Path.Combine(dataDir, mapName)), _logger);

        if (_serializer.TryDeserialize<MapFileHeader>(packetBuffer, out var mapFileHeader) == DeserializationResult.Success)
        {
            GridMap gridMap = new()
            {
                FileHeader = mapFileHeader
            };

            if (mapFileHeader.AreaMapOffset > 0)
            {
                packetBuffer.Reader.BaseStream.Position = mapFileHeader.AreaMapOffset;

                if (_serializer.TryDeserialize(packetBuffer, out MapAreaHeader mapAreaHeader) == DeserializationResult.Success)
                {
                    gridMap.AreaHeader = mapAreaHeader;
                }
                else
                {
                    _logger.Error("Failed to deserialize map area header for {MapFile}.", mapName);
                }
            }
        }
        else
        {
            _logger.Error("Failed to deserialize map file header for {MapFile}.", mapName);
        }
    }
}
