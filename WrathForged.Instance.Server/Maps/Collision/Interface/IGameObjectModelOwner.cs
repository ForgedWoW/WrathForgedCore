// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;

namespace WrathForged.Instance.Server.Maps.Collision.Interface;
public interface IGameObjectModelOwner
{
    uint DisplayId { get; }
    bool IsSpawned { get; }
    byte NameSetId { get; }
    Vector3 Position { get; }
    float Orientation { get; }
    float Scale { get; }
    uint PhaseMask { get; }
}
