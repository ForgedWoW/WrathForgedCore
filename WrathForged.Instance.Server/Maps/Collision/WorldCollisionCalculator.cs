// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Common;
using WrathForged.Instance.Server.Maps.Collision.Callbacks;
using WrathForged.Instance.Server.Maps.Collision.Models;
using WrathForged.Models.GameMath;
using WrathForged.Models.Maps.Enum;
using WrathForged.Models.Maps.Interfaces;
using WrathForged.Models.Maps.MapFiles;

namespace WrathForged.Instance.Server.Maps.Collision;

public class WorldCollisionCalculator(WorldCollisionModel worldCollisionModel) : ICollisionModel
{
    public uint Flags { get; set; }
    public WorldCollisionModel CollisionModel { get; set; } = worldCollisionModel;

    public BIHCalculator GroupTree { get; set; } = new BIHCalculator(worldCollisionModel.GroupTree);

    public AxisAlignedBox Bounds { get; set; }

    public Vector3 Position { get; set; }

    public List<GroupCollisionCalculator> GroupCollisionCalculators { get; } = worldCollisionModel.GroupModels.Select(x => new GroupCollisionCalculator(x)).ToList();

    public bool GetLocationInfo(Vector3 p, Vector3 down, out float dist, out GroupLocationCalculator info)
    {
        dist = 0f;

        if (CollisionModel.GroupModels.Empty())
        {
            info = default!;
            return false;
        }

        WModelAreaCallback callback = new(GroupCollisionCalculators, down);
        GroupTree.IntersectPoint(p, callback);

        if (callback.Hit != null)
        {
            info = new GroupLocationCalculator(callback.Hit)
            {
                RootId = CollisionModel.RootWmoid
            };
            dist = callback.ZDist;
            return true;
        }

        info = default!;
        return false;
    }

    public bool IntersectPoint(Vector3 p, Vector3 down, out float dist, AreaInfo info)
    {
        dist = 0f;

        if (CollisionModel.GroupModels.Empty())
            return false;

        WModelAreaCallback callback = new(GroupCollisionCalculators, down);
        GroupTree.IntersectPoint(p, callback);

        if (callback.Hit == null)
            return false;

        info.RootId = CollisionModel.RootWmoid;
        info.GroupId = callback.Hit.GroupCollisionModel.WmoID;
        info.Flags = callback.Hit.GroupCollisionModel.MogpFlags;
        info.Result = true;
        dist = callback.ZDist;

        return true;
    }

    public bool IntersectRay(Ray ray, ref float distance, bool stopAtFirstHit, ModelIgnoreFlags ignoreFlags)
    {
        // If the caller asked us to ignore certain objects we should check flags
        if ((ignoreFlags & ModelIgnoreFlags.M2) != ModelIgnoreFlags.Nothing)
            // M2 models are not taken into account for LoS calculation if caller requested their ignoring.
            if ((Flags & (uint)CollisionModelSpawnFlags.M2) != 0)
                return false;

        // small M2 workaround, maybe better make separate class with virtual intersection funcs
        // in any case, there's no need to use a bound tree if we only have one submodel
        if (CollisionModel.GroupModels.Count == 1)
            return GroupCollisionCalculators[0].IntersectRay(ray, ref distance, stopAtFirstHit);

        WModelRayCallBack isc = new(GroupCollisionCalculators);
        GroupTree.IntersectRay(ray, isc, ref distance, stopAtFirstHit);

        return isc.Hit;
    }
}
