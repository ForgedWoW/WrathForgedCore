// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Models.GameMath;
using WrathForged.Models.Maps.Interfaces;

namespace WrathForged.Instance.Server.Maps.Collision;

public class GameObjectCollisionModel : ICollisionModel
{
    public AxisAlignedBox Bounds { get; set; }

    public Vector3 Position { get; set; }
}
