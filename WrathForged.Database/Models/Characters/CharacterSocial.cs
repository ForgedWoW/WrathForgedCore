// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterSocial
{
    /// <summary>
    /// Character Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Friend Global Unique Identifier
    /// </summary>
    public uint Friend { get; set; }

    /// <summary>
    /// Friend Flags
    /// </summary>
    public byte Flags { get; set; }

    /// <summary>
    /// Friend Note
    /// </summary>
    public string Note { get; set; } = null!;
}
