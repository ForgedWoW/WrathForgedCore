using System;
using System.Collections.Generic;

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
