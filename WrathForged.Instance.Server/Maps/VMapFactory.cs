// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common;
using WrathForged.Common.Maps;
using WrathForged.Common.Networking;
using WrathForged.Common.Serialization;
using WrathForged.Instance.Server.Maps.Collision;
using WrathForged.Models.Maps;
using WrathForged.Models.Maps.Enum;
using WrathForged.Models.Maps.MapFiles;

namespace WrathForged.Instance.Server.Maps;

public class VMapFactory(IConfiguration configuration, ClassFactory classFactory, ClientVMapFileReader clientVMapFileReader,
                            ForgedModelSerializer forgedModelSerializer, ILogger logger)
{
    /// <summary>
    ///     MapId, Y, X
    /// </summary>
    private const string VMAP_TILE_FILE_NAME_FORMAT = "{0:D4}_{1:D2}_{2:D2}.vmtile";
    private readonly IConfiguration _configuration = configuration;
    private readonly ClassFactory _classFactory = classFactory;
    private readonly ClientVMapFileReader _clientVMapFileReader = clientVMapFileReader;
    private readonly ForgedModelSerializer _forgedModelSerializer = forgedModelSerializer;
    private readonly ILogger _logger = logger;
    private readonly Dictionary<string, WorldCollisionModel> _loadedModelFiles = [];
    private readonly Dictionary<uint, StaticMapTree> _instanceMapTrees = [];
    public string VMapPath(string fileName) => Path.Combine(_configuration.GetDefaultValue("Data:DataDir", ".\\WoWData"), "vmaps", fileName);

    public bool LoadMap(uint mapId, int x, int y)
    {
        if (!_instanceMapTrees.TryGetValue(mapId, out var staticMapTree))
        {
            if (!_clientVMapFileReader.TryLoadMap(mapId, x, y, out var vMapTreeData))
                return false;

            staticMapTree = _classFactory.Container.LocateWithPositionalParams<StaticMapTree>(mapId, vMapTreeData);
            _instanceMapTrees[mapId] = staticMapTree;
        }

        if (!LoadMapTile(mapId, x, y, out var worldCollisionModels))
            return false;

        staticMapTree.LoadMapTile(x, y, worldCollisionModels);
        return true;
    }

    private WorldCollisionModel? AcquireModelInstance(string filename, CollisionModelSpawnFlags flags = 0)
    {
        filename = filename.TrimEnd('\0');

        if (!_loadedModelFiles.TryGetValue(filename, out var model))
        {
            using var packetBuffer = new PacketBuffer(File.ReadAllBytes(VMapPath(filename)), _logger);

            if (_forgedModelSerializer.TryDeserialize(packetBuffer, out model) == Serialization.Models.DeserializationResult.Success && model != null)
            {
                Log.Logger.Debug("VMapManager: loaded file '{0}'", filename);
                model.Flags = flags;
                _loadedModelFiles.Add(filename, model);
                return model;
            }
        }

        Log.Logger.Error("VMapManager: could not load '{0}'", filename);
        return null;
    }

    private bool LoadMapTile(uint mapId, int x, int y, out List<(CollisionModelSpawn, WorldCollisionModel)> models)
    {
        var dataDir = _configuration.GetDefaultValue("Data:DataDir", ".\\WoWData");
        var fileName = string.Format(VMAP_TILE_FILE_NAME_FORMAT, mapId, y, x);
        models = [];
        using var packetBuffer = new PacketBuffer(File.ReadAllBytes(Path.Combine(dataDir, "vmaps", fileName)), _logger);

        if (_forgedModelSerializer.TryDeserialize(packetBuffer, out VMapTileData vMapTileData) == Serialization.Models.DeserializationResult.Success)
        {
            foreach (var spawn in vMapTileData.ModelSpawns)
            {
                var model = AcquireModelInstance(spawn.Name, spawn.Flags);

                if (model != null)
                    models.Add((spawn, model));
            }

            return true;
        }

        _logger.Error("Failed to deserialize vmap tile file for map {MapId} at {X}, {Y}", mapId, x, y);
        return false;
    }
}
