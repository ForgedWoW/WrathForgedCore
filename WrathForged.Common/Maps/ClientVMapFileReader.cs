// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common.Networking;
using WrathForged.Common.Serialization;
using WrathForged.Models.Maps;

namespace WrathForged.Common.Maps;

public class ClientVMapFileReader(IConfiguration configuration, ClassFactory classFactory, ForgedModelSerializer forgedModelSerializer, ILogger logger)
{
    /// <summary>
    ///     MapId, Y, X
    /// </summary>
    private const string VMAP_TILE_FILE_NAME_FORMAT = "{0:D4}_{1:D2}_{2:D2}.vmtile";

    /// <summary>
    ///     MapId
    /// </summary>
    private const string VMAP_TREE_FILE_NAME_FORMAT = "{0:D4}.vmtree";
    private readonly IConfiguration _configuration = configuration;
    private readonly ClassFactory _classFactory = classFactory;
    private readonly ForgedModelSerializer _forgedModelSerializer = forgedModelSerializer;
    private readonly ILogger _logger = logger;

    public VMapTreeData? LoadMap(uint mapId, int x, int y)
    {
        var dataDir = _configuration.GetDefaultValue("Data:DataDir", ".\\WoWData");
        var fileName = string.Format(VMAP_TREE_FILE_NAME_FORMAT, mapId);

        using var packetBuffer = new PacketBuffer(File.ReadAllBytes(Path.Combine(dataDir, "vmaps", fileName)), _logger);

        if (_forgedModelSerializer.TryDeserialize(packetBuffer, out VMapTreeData vMapTreeData) == WrathForged.Serialization.Models.DeserializationResult.Success)
        {
            return vMapTreeData;
        }

        _logger.Error("Failed to deserialize vmap tree file for map {MapId}", mapId);
        return null;
    }
}
