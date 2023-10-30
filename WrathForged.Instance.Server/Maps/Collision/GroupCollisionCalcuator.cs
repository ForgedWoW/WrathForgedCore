// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Common;
using WrathForged.Instance.Server.Maps.Collision.Callbacks;
using WrathForged.Models.GameMath;
using WrathForged.Models.Maps;
using WrathForged.Models.Maps.MapFiles;

namespace WrathForged.Instance.Server.Maps.Collision;

public class GroupCollisionCalculator
{
    public GroupCollisionModel GroupCollisionModel { get; set; } = new GroupCollisionModel();
    private readonly WmoLiquidCalculator? _iLiquid;
    private readonly BIHCalculator _meshTree;

    public GroupCollisionCalculator(GroupCollisionModel groupCollisionModel)
    {
        GroupCollisionModel = groupCollisionModel;
        _meshTree = new BIHCalculator(groupCollisionModel.MeshTree);
        _iLiquid = new WmoLiquidCalculator(groupCollisionModel.Liquid);
    }

    public GroupCollisionCalculator(BoundingIntervalHierarchy meshTree)
    {
        GroupCollisionModel.MeshTree = meshTree;
        _meshTree = new BIHCalculator(meshTree);
    }

    public GroupCollisionCalculator(GroupCollisionCalculator other)
    {
        GroupCollisionModel.Bounds = other.GroupCollisionModel.Bounds;
        GroupCollisionModel.MogpFlags = other.GroupCollisionModel.MogpFlags;
        GroupCollisionModel.WmoID = other.GroupCollisionModel.WmoID;
        GroupCollisionModel.Vertices = other.GroupCollisionModel.Vertices;
        GroupCollisionModel.Triangles = other.GroupCollisionModel.Triangles;
        GroupCollisionModel.MeshTree = other.GroupCollisionModel.MeshTree;
        _meshTree = other._meshTree;

        if (other.GroupCollisionModel.Liquid != null)
            _iLiquid = other._iLiquid;
    }

    public GroupCollisionCalculator(uint mogpFlags, uint groupWmoid, AxisAlignedBox bound, BoundingIntervalHierarchy meshTree)
    {
        GroupCollisionModel.Bounds = bound;
        GroupCollisionModel.MogpFlags = mogpFlags;
        GroupCollisionModel.WmoID = groupWmoid;
        GroupCollisionModel.MeshTree = meshTree;
        _meshTree = new BIHCalculator(meshTree);
    }

    public bool GetLiquidLevel(Vector3 pos, out float liqHeight)
    {
        liqHeight = 0f;

        return _iLiquid != null && _iLiquid.GetLiquidHeight(pos, out liqHeight);
    }

    public bool IntersectRay(Ray ray, ref float distance, bool stopAtFirstHit)
    {
        if (GroupCollisionModel.Triangles.Empty())
            return false;

        GModelRayCallback callback = new(GroupCollisionModel.Triangles, GroupCollisionModel.Vertices);
        _meshTree.IntersectRay(ray, callback, ref distance, stopAtFirstHit);

        return callback.Hit;
    }

    public bool IsInsideObject(Vector3 pos, Vector3 down, out float zDist)
    {
        zDist = 0f;

        if (GroupCollisionModel.Triangles.Empty() || !GroupCollisionModel.Bounds.Contains(pos))
            return false;

        var rPos = pos - (0.1f * down);
        var dist = float.PositiveInfinity;
        Ray ray = new(rPos, down);
        var hit = IntersectRay(ray, ref dist, false);

        if (hit)
            zDist = dist - 0.1f;

        return hit;
    }
}
