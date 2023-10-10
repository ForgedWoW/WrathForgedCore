// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterQueststatus
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Quest Identifier
    /// </summary>
    public uint Quest { get; set; }

    public byte Status { get; set; }

    public byte Explored { get; set; }

    public uint Timer { get; set; }

    public ushort Mobcount1 { get; set; }

    public ushort Mobcount2 { get; set; }

    public ushort Mobcount3 { get; set; }

    public ushort Mobcount4 { get; set; }

    public ushort Itemcount1 { get; set; }

    public ushort Itemcount2 { get; set; }

    public ushort Itemcount3 { get; set; }

    public ushort Itemcount4 { get; set; }

    public ushort Itemcount5 { get; set; }

    public ushort Itemcount6 { get; set; }

    public ushort Playercount { get; set; }
}
