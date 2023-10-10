// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Ban List
/// </summary>
public partial class CharacterBanned
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public uint Bandate { get; set; }

    public uint Unbandate { get; set; }

    public string Bannedby { get; set; } = null!;

    public string Banreason { get; set; } = null!;

    public byte Active { get; set; }
}
