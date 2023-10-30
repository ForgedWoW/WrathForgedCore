// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Maps.Enum;

[Flags]
public enum CollisionModelSpawnFlags
{
    M2 = 1,
    WorldSpawn = 1 << 1,
    HasBound = 1 << 2,
}
