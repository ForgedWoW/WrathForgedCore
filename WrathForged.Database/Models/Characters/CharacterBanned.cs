using System;
using System.Collections.Generic;

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
