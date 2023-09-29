// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Stored respawn times
/// </summary>
public partial class Respawn
{
    public ushort Type { get; set; }

    public uint SpawnId { get; set; }

    public ulong RespawnTime { get; set; }

    public ushort MapId { get; set; }

    public uint InstanceId { get; set; }
}
