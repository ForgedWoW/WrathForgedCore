// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Models.GameMath;

namespace WrathForged.Models.Maps.Interfaces;
public interface ICollisionModel
{
    AxisAlignedBox Bounds { get; }
    Vector3 Position { get; }
}
