// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterReputation
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public ushort Faction { get; set; }

    public int Standing { get; set; }

    public ushort Flags { get; set; }
}
