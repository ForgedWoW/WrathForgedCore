// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Models.GameMath;
using WrathForged.Models.Maps.Enum;

namespace WrathForged.Models.Maps.Interfaces;
public interface ICollisionModelMinimalData
{
    ushort AdtId { get; set; }
    AxisAlignedBox Bounds { get; set; }
    CollisionModelSpawnFlags Flags { get; set; }
    uint Id { get; set; }
    string Name { get; set; }
    Vector3 Position { get; set; }
    float Scale { get; set; }
}