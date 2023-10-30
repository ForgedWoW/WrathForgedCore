// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.GameMath;

namespace WrathForged.Instance.Server.Maps.Collision.Interface;
public interface IRayIntersect
{
    bool DidRayHit(Ray ray, int idx, ref float maxDistance, bool stopAtFirstHit);
}
