// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Instance.Server.Maps.Collision.Interface;
using WrathForged.Models.GameMath;

namespace WrathForged.Instance.Server.Maps.Collision.Callbacks;
internal class WModelRayCallBack(List<GroupCollisionCalculator> mod) : IRayIntersect
{
    public bool Hit { get; set; } = false;

    private readonly List<GroupCollisionCalculator> _models = mod;

    public bool DidRayHit(Ray ray, int entry, ref float distance, bool pStopAtFirstHit)
    {
        var result = _models[entry].IntersectRay(ray, ref distance, pStopAtFirstHit);
        if (result)
            Hit = true;

        return Hit;
    }
}
