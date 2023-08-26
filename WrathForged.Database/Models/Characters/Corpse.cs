using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Death System
/// </summary>
public partial class Corpse
{
    /// <summary>
    /// Character Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public float Orientation { get; set; }

    /// <summary>
    /// Map Identifier
    /// </summary>
    public ushort MapId { get; set; }

    public uint PhaseMask { get; set; }

    public uint DisplayId { get; set; }

    public string ItemCache { get; set; } = null!;

    public uint Bytes1 { get; set; }

    public uint Bytes2 { get; set; }

    public uint GuildId { get; set; }

    public byte Flags { get; set; }

    public byte DynFlags { get; set; }

    public uint Time { get; set; }

    public byte CorpseType { get; set; }

    /// <summary>
    /// Instance Identifier
    /// </summary>
    public uint InstanceId { get; set; }
}
