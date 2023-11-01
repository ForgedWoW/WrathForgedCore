// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Common.Maths;
using WrathForged.Instance.Server.Maps.Collision.Models;
using WrathForged.Models.GameMath;
using WrathForged.Models.Maps.Enum;
using WrathForged.Models.Maps.Interfaces;
using WrathForged.Models.Maps.MapFiles;

namespace WrathForged.Instance.Server.Maps.Collision;

public class CollisionModelInstance
{
    private readonly WorldCollisionCalculator _iModel;
    private readonly Matrix4x4 _iInvRot;
    private readonly float _iInvScale;

    public CollisionModelInstance(CollisionModelSpawn spawn, WorldCollisionModel worldCollisionModel)
    {
        Data = spawn;
        _iModel = new WorldCollisionCalculator(worldCollisionModel);
        _ = MathFunctions.FromEulerAnglesZYX(MathFunctions.PI * spawn.Rotation.Y / 180.0f, MathFunctions.PI * spawn.Rotation.X / 180.0f, MathFunctions.PI * spawn.Rotation.Z / 180.0f).Inverse(out _iInvRot);
        _iInvScale = 1.0f / spawn.Scale;
    }

    public ICollisionModelMinimalData Data { get; }

    public bool TryGetLiquidLevel(Vector3 p, LocationInfo info, out float liqHeight)
    {
        // child bounds are defined in object space:
        var pModel = _iInvRot.Multiply(p - Data.Position) * _iInvScale;

        //Vector3 zDirModel = iInvRot * Vector3(0.f, 0.f, -1.f);
        if (info.HitModel?.GetLiquidLevel(pModel, out var zDist) == true)
        {
            // calculate world height (zDist in model coords):
            // assume WMO not tilted (wouldn't make much sense anyway)
            liqHeight = (zDist * Data.Scale) + Data.Position.Z;

            return true;
        }

        liqHeight = 0;
        return false;
    }

    public bool GetLocationInfo(Vector3 p, LocationInfo info)
    {
        if (_iModel == null)
            return false;

        // M2 files don't contain area info, only WMO files
        if (Convert.ToBoolean(Data.Flags & CollisionModelSpawnFlags.M2))
            return false;

        if (!Data.Bounds.Contains(p))
            return false;

        // child bounds are defined in object space:
        var pModel = _iInvRot.Multiply(p - Data.Position) * _iInvScale;
        var zDirModel = _iInvRot.Multiply(new Vector3(0.0f, 0.0f, -1.0f));

        if (_iModel.GetLocationInfo(pModel, zDirModel, out var zDist, out var groupInfo))
        {
            var modelGround = pModel + (zDist * zDirModel);
            // Transform back to world space. Note that:
            // Mat * vec == vec * Mat.transpose()
            // and for rotation matrices: Mat.inverse() == Mat.transpose()
            var worldZ = (_iInvRot.Multiply(modelGround * Data.Scale) + Data.Position).Z;

            if (info.GroundZ < worldZ) // hm...could it be handled automatically with zDist at intersection?
            {
                info.RootId = groupInfo.RootId;
                info.HitModel = groupInfo.HitModel;
                info.GroundZ = worldZ;
                info.HitInstance = this;

                return true;
            }
        }

        return false;
    }

    public void IntersectPoint(Vector3 p, AreaInfo info)
    {
        if (_iModel == null)
            return;

        // M2 files don't contain area info, only WMO files
        if (Convert.ToBoolean(Data.Flags & CollisionModelSpawnFlags.M2))
            return;

        if (!Data.Bounds.Contains(p))
            return;

        // child bounds are defined in object space:
        var pModel = _iInvRot.Multiply(p - Data.Position) * _iInvScale;
        var zDirModel = _iInvRot.Multiply(new Vector3(0.0f, 0.0f, -1.0f));

        if (_iModel.IntersectPoint(pModel, zDirModel, out var zDist, info))
        {
            var modelGround = pModel + (zDist * zDirModel);
            // Transform back to world space. Note that:
            // Mat * vec == vec * Mat.transpose()
            // and for rotation matrices: Mat.inverse() == Mat.transpose()
            var worldZ = ((_iInvRot.Multiply(modelGround) * Data.Scale) + Data.Position).Z;

            if (info.GroundZ < worldZ)
            {
                info.GroundZ = worldZ;
                info.AdtId = Data.AdtId;
            }
        }
    }

    public bool IntersectRay(Ray pRay, ref float pMaxDist, bool pStopAtFirstHit, ModelIgnoreFlags ignoreFlags)
    {
        if (_iModel == null)
            return false;

        var time = pRay.IntersectionTime(Data.Bounds);

        if (float.IsInfinity(time))
            return false;

        // child bounds are defined in object space:
        var p = _iInvRot.Multiply(pRay.Origin - Data.Position) * _iInvScale;
        var modRay = new Ray(p, _iInvRot.Multiply(pRay.Direction));
        var distance = pMaxDist * _iInvScale;
        var hit = _iModel.IntersectRay(modRay, ref distance, pStopAtFirstHit, ignoreFlags);

        if (hit)
        {
            distance *= Data.Scale;
            pMaxDist = distance;
        }

        return hit;
    }
}
