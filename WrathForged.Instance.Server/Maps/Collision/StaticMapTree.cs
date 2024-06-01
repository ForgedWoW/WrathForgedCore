// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections.Concurrent;
using System.Numerics;
using Serilog;
using WrathForged.Instance.Server.Maps.Collision.Callbacks;
using WrathForged.Instance.Server.Maps.Collision.Models;
using WrathForged.Models.GameMath;
using WrathForged.Models.Maps;
using WrathForged.Models.Maps.MapFiles;

namespace WrathForged.Instance.Server.Maps.Collision;

public class StaticMapTree(uint mapId, VMapTreeData vMapTreeData, ILogger logger) : IDisposable
{
    private readonly ConcurrentDictionary<uint, uint> _loadedSpawns = new();
    private readonly ConcurrentDictionary<int, bool> _loadedTiles = new();
    private readonly uint _mapId = mapId;
    private readonly ILogger _logger = logger;
    private readonly ConcurrentDictionary<uint, uint> _spawnIndices = vMapTreeData.SpawnIndices;
    private readonly BIHCalculator _tree = new(vMapTreeData.BIH);
    private readonly int _nTreeValues = vMapTreeData.BIH.Objects.Length;
    private CollisionModelInstance[] _treeValues = new CollisionModelInstance[vMapTreeData.BIH.Objects.Length];
    private bool _disposedValue;

    public void LoadMapTile(int x, int y, List<(CollisionModelSpawn spawn, WorldCollisionModel model)> worldCollisionModels)
    {
        foreach (var (spawn, model) in worldCollisionModels)
        {
            if (!_spawnIndices.TryGetValue(spawn.Id, out var referencedVal))
                continue;

            if (!_loadedSpawns.TryGetValue(referencedVal, out var count))
            {
                if (referencedVal >= _nTreeValues)
                {
                    _logger.Warning("Invalid spawn index {Index} for map {MapId}", referencedVal, _mapId);
                    continue;
                }

                _treeValues[referencedVal] = new CollisionModelInstance(spawn, model);
                _ = _loadedSpawns.TryAdd(referencedVal, 1);
            }
            else
            {
                _loadedSpawns[referencedVal] = count++;
            }
        }

        _loadedTiles[PackTileID(x, y)] = worldCollisionModels.Count != 0;
    }

    public bool GetAreaInfo(ref Vector3 pos, out AreaInfo areaInfo)
    {
        AreaInfoCallback intersectionCallBack = new(_treeValues);
        _tree.IntersectPoint(pos, intersectionCallBack);

        if (intersectionCallBack.AreaInfo.Result)
        {
            areaInfo = intersectionCallBack.AreaInfo;
            pos.Z = intersectionCallBack.AreaInfo.GroundZ;

            return true;
        }

        areaInfo = default!;
        return false;
    }

    public float GetHeight(Vector3 pPos, float maxSearchDist)
    {
        var height = float.PositiveInfinity;
        Vector3 dir = new(0, 0, -1);
        Ray ray = new(pPos, dir); // direction with length of 1
        var maxDist = maxSearchDist;

        if (GetIntersectionTime(ray, ref maxDist, false, ModelIgnoreFlags.Nothing))
            height = pPos.Z - maxDist;

        return height;
    }

    public bool GetLocationInfo(Vector3 pos, LocationInfo info)
    {
        LocationInfoCallback intersectionCallBack = new(_treeValues, info);
        _tree.IntersectPoint(pos, intersectionCallBack);

        return intersectionCallBack.Result;
    }

    public bool TryGetObjectHitPos(Vector3 pPos1, Vector3 pPos2, float pModifyDist, out Vector3 pResultHitPos)
    {
        bool result;
        var maxDist = (pPos2 - pPos1).Length();

        // prevent NaN values which can cause BIH intersection to enter infinite loop
        if (maxDist < 1e-10f)
        {
            pResultHitPos = pPos2;

            return false;
        }

        var dir = (pPos2 - pPos1) / maxDist; // direction with length of 1
        Ray ray = new(pPos1, dir);
        var dist = maxDist;

        if (GetIntersectionTime(ray, ref dist, false, ModelIgnoreFlags.Nothing))
        {
            pResultHitPos = pPos1 + (dir * dist);

            if (pModifyDist < 0)
            {
                if ((pResultHitPos - pPos1).Length() > -pModifyDist)
                    pResultHitPos += dir * pModifyDist;
                else
                    pResultHitPos = pPos1;
            }
            else
            {
                pResultHitPos += dir * pModifyDist;
            }

            result = true;
        }
        else
        {
            pResultHitPos = pPos2;
            result = false;
        }

        return result;
    }

    public bool IsInLineOfSight(Vector3 pos1, Vector3 pos2, ModelIgnoreFlags ignoreFlags)
    {
        var maxDist = (pos2 - pos1).Length();

        // return false if distance is over max float, in case of cheater teleporting to the end of the universe
        if (maxDist is float.MaxValue or float.PositiveInfinity)
            return false;

        // prevent NaN values which can cause BIH intersection to enter infinite loop
        if (maxDist < 1e-10f)
            return true;

        // direction with length of 1
        Ray ray = new(pos1, (pos2 - pos1) / maxDist);

        return !GetIntersectionTime(ray, ref maxDist, true, ignoreFlags);
    }

    public int NumLoadedTiles() => _loadedTiles.Count;

    private static int PackTileID(int tileX, int tileY) => (tileX << 16) | tileY;

    private bool GetIntersectionTime(Ray pRay, ref float pMaxDist, bool pStopAtFirstHit, ModelIgnoreFlags ignoreFlags)
    {
        var distance = pMaxDist;
        MapRayCallback intersectionCallBack = new(_treeValues, ignoreFlags);
        _tree.IntersectRay(pRay, intersectionCallBack, ref distance, pStopAtFirstHit);

        if (intersectionCallBack.DidHit)
            pMaxDist = distance;

        return intersectionCallBack.DidHit;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {

            }

            _loadedSpawns.Clear();
            _loadedTiles.Clear();
            _treeValues = [];
            _spawnIndices.Clear();
            _tree.BIH = new();
            _disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
