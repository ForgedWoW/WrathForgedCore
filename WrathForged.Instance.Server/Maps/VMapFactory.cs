// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common;
using WrathForged.Common.Maps;
using WrathForged.Common.Networking;
using WrathForged.Common.Serialization;
using WrathForged.Database.Models.DBC;
using WrathForged.Database.Models.World;
using WrathForged.Instance.Server.Maps.Collision;
using WrathForged.Instance.Server.Maps.Collision.Models;
using WrathForged.Instance.Server.Maps.Models;
using WrathForged.Models.Maps;
using WrathForged.Models.Maps.Enum;
using WrathForged.Models.Maps.MapFiles;
using Z.EntityFramework.Plus;

namespace WrathForged.Instance.Server.Maps;

public class VMapFactory(IConfiguration configuration, ClassFactory classFactory, ClientVMapFileReader clientVMapFileReader,
                   ForgedModelSerializer forgedModelSerializer, ILogger logger, WorldDatabase worldDatabase)
{
    /// <summary>
    ///     MapId, Y, X
    /// </summary>
    private const string VMAP_TILE_FILE_NAME_FORMAT = "{0:D4}_{1:D2}_{2:D2}.vmtile";
    private const byte VMAP_AREA_FLAG = 0x01;
    private const byte VMAP_HEIGHT = 0x02;
    private const byte VMAP_LOS = 0x04;
    private const byte VMAP_LIQUID_STATUS = 0x08;

    private readonly IConfiguration _configuration = configuration;
    private readonly ClassFactory _classFactory = classFactory;
    private readonly ClientVMapFileReader _clientVMapFileReader = clientVMapFileReader;
    private readonly ForgedModelSerializer _forgedModelSerializer = forgedModelSerializer;
    private readonly ILogger _logger = logger;
    private readonly Dictionary<string, WorldCollisionModel> _loadedModelFiles = [];
    private readonly Dictionary<uint, StaticMapTree> _instanceMapTrees = [];
    private readonly Dictionary<uint, Disable> _disabledVmaps = worldDatabase.Disables.Where(d => d.SourceType == 6).ToDictionary(d => d.Entry, d => d);

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

    public AreaAndLiquidData GetAreaAndLiquidData(uint mapId, Vector3 position, uint reqLiquidType)
    {
        var data = new AreaAndLiquidData();

        if (VMapIsDisabled(mapId, VMAP_LIQUID_STATUS))
        {
            data.FloorZ = position.Z;

            if (TryGetAreaInfo(mapId, position, out var areaInfo))
            {
                data.AreaInfo = areaInfo;
                data.FloorZ = areaInfo.GroundZ;
            }

            return data;
        }

        if (_instanceMapTrees.TryGetValue(mapId, out var instanceTree))
        {
            LocationInfo info = new();
            var pos = ConvertPositionToInternalRep(position);

            if (instanceTree.GetLocationInfo(pos, info) && info.HitModel != null && info.HitInstance != null)
            {
                data.FloorZ = info.GroundZ;
                var liquidType = info.HitModel.GroupCollisionModel.Liquid.Type;

                if (reqLiquidType == 0 || Convert.ToBoolean(GetLiquidTypeFlags(liquidType) & reqLiquidType))
                    if (info.HitInstance.TryGetLiquidLevel(pos, info, out var liquidLevel))
                        data.LiquidInfo = new AreaAndLiquidData.LiquidInfoModel(liquidType, liquidLevel);

                if (!VMapIsDisabled(mapId, VMAP_LIQUID_STATUS))
                    data.AreaInfo = new AreaInfo()
                    {
                        AdtId = info.HitInstance.Data.AdtId,
                        RootId = info.RootId,
                        GroupId = info.HitModel.GroupCollisionModel.WmoID,
                        Flags = info.HitModel.GroupCollisionModel.MogpFlags
                    };
            }
        }

        return data;
    }

    public bool TryGetAreaInfo(uint mapId, Vector3 position, out AreaInfo areaInfoModel)
    {
        if (!VMapIsDisabled(mapId, VMAP_AREA_FLAG))
            if (_instanceMapTrees.TryGetValue(mapId, out var instanceTree))
            {
                var pos = ConvertPositionToInternalRep(position);
                return instanceTree.GetAreaInfo(ref pos, out areaInfoModel);
            }

        areaInfoModel = default!;
        return false;
    }

    public float GetHeight(uint mapId, Vector3 position, float maxSearchDist)
    {
        if (!VMapIsDisabled(mapId, VMAP_HEIGHT))
            if (_instanceMapTrees.TryGetValue(mapId, out var instanceTree))
            {
                var pos = ConvertPositionToInternalRep(position);
                var height = instanceTree.GetHeight(pos, maxSearchDist);

                if (float.IsInfinity(height))
                    height = MapConst.VMAP_INVALID_HEIGHT_VALUE; // No height

                return height;
            }

        return MapConst.VMAP_INVALID_HEIGHT_VALUE;
    }

    public bool TryGetLiquidLevel(uint mapId, Vector3 position, uint reqLiquidType, out LiquidLevelInfo liquidLevelInfo)
    {
        if (!VMapIsDisabled(mapId, VMAP_LIQUID_STATUS))
            if (_instanceMapTrees.TryGetValue(mapId, out var instanceTree))
            {
                LocationInfo info = new();
                var pos = ConvertPositionToInternalRep(position);

                if (instanceTree.GetLocationInfo(pos, info))
                {
                    liquidLevelInfo = new()
                    {
                        Floor = info.GroundZ,
                        Type = info.HitModel?.GroupCollisionModel.Liquid.Type ?? 0, // entry from LiquidType.dbc
                        MogpFlags = info.HitModel?.GroupCollisionModel.MogpFlags ?? 0
                    };

                    if (reqLiquidType != 0 && !Convert.ToBoolean(GetLiquidTypeFlags(liquidLevelInfo.Type) & reqLiquidType))
                    {
                        liquidLevelInfo = default!;
                        return false;
                    }

                    if (info.HitInstance?.TryGetLiquidLevel(pos, info, out var level) == true)
                    {
                        liquidLevelInfo.Level = level;
                        return true;
                    }
                }
            }

        liquidLevelInfo = default!;
        return false;
    }

    public bool TryGetObjectHitPos(uint mapId, Vector3 originalPosition1, Vector3 originalPosition2, float modifyDist, out Vector3 resultPos)
    {
        if (!VMapIsDisabled(mapId, VMAP_LOS))
            if (_instanceMapTrees.TryGetValue(mapId, out var instanceTree))
            {
                var pos1 = ConvertPositionToInternalRep(originalPosition1);
                var pos2 = ConvertPositionToInternalRep(originalPosition2);
                var result = instanceTree.TryGetObjectHitPos(pos1, pos2, modifyDist, out resultPos);
                resultPos = ConvertPositionToInternalRep(resultPos);

                return result;
            }

        resultPos = originalPosition2;
        return false;
    }

    public bool IsInLineOfSight(uint mapId, Vector3 originalPosition1, Vector3 originalPosition2, ModelIgnoreFlags ignoreFlags)
    {
        if (!VMapIsDisabled(mapId, VMAP_LOS))
            return true;

        if (_instanceMapTrees.TryGetValue(mapId, out var instanceTree))
        {
            var pos1 = ConvertPositionToInternalRep(originalPosition1);
            var pos2 = ConvertPositionToInternalRep(originalPosition2);

            if (pos1 != pos2)
                return instanceTree.IsInLineOfSight(pos1, pos2, ignoreFlags);
        }

        return true;
    }

    private static Vector3 ConvertPositionToInternalRep(Vector3 position)
    {
        Vector3 pos = new();
        var mid = 0.5f * 64.0f * 533.33333333f;
        pos.X = mid - position.X;
        pos.Y = mid - position.Y;
        pos.Z = position.Z;

        return pos;
    }

    private uint GetLiquidTypeFlags(uint liquidType)
    {
        using var dbcDB = _classFactory.Locate<DBCDatabase>();

        var liquid = dbcDB.Liquidtypes.FromCache().FirstOrDefault(l => l.Id == liquidType);

        return liquid != null ? 1u << liquid.Type : 0;
    }

    private bool VMapIsDisabled(uint mapId, byte flag) => _disabledVmaps.TryGetValue(mapId, out var disable) && (disable.Flags & flag) != 0;
}
