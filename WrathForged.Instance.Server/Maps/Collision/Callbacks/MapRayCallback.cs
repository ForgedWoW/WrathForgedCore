// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Instance.Server.Maps.Collision.Interface;
using WrathForged.Models.GameMath;

namespace WrathForged.Instance.Server.Maps.Collision.Callbacks;

public class MapRayCallback(CollisionModelInstance[] prims, ModelIgnoreFlags ignoreFlags) : IRayIntersect
{
    private readonly ModelIgnoreFlags _flags = ignoreFlags;
    private readonly CollisionModelInstance[] _prims = prims;
    public bool DidHit { get; private set; }

    public bool DidRayHit(Ray ray, int idx, ref float maxDistance, bool stopAtFirstHit = true)
    {
        if (_prims[idx] == null)
            return false;

        var result = _prims[idx].IntersectRay(ray, ref maxDistance, stopAtFirstHit, _flags);

        if (result)
            DidHit = true;

        return result;
    }
}
