// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Maps.MapFiles;

namespace WrathForged.Instance.Server.Maps.Collision;

public class CollisionModelInstance
{
    public required CollisionModelSpawn Spawn { get; set; }
}
