// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class PoolMember
{
    public ushort Type { get; set; }

    public uint SpawnId { get; set; }

    public uint PoolSpawnId { get; set; }

    public float Chance { get; set; }

    public string? Description { get; set; }
}
