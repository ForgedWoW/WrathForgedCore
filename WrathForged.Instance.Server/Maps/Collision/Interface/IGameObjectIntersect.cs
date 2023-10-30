// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;

namespace WrathForged.Instance.Server.Maps.Collision.Interface;
public interface IGameObjectIntersect
{
    void GameObjectIntersectedObject(Vector3 point, GameObjectCollisionModel gameObject);
}
