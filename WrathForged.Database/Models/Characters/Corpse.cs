// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
