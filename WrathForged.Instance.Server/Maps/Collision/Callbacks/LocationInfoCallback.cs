// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Instance.Server.Maps.Collision.Interface;
using WrathForged.Instance.Server.Maps.Collision.Models;

namespace WrathForged.Instance.Server.Maps.Collision.Callbacks;

public class LocationInfoCallback(CollisionModelInstance[] prims, LocationInfo locationInfo) : IPointIntersect
{
    private readonly LocationInfo _locInfo = locationInfo;
    private readonly CollisionModelInstance[] _prims = prims;

    public bool Result { get; set; }

    public void PointIntersectedObject(Vector3 point, int idx)
    {
        if (_prims[idx] != null && _prims[idx].GetLocationInfo(point, _locInfo))
            Result = true;
    }
}
