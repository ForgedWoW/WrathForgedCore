using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Guild System
/// </summary>
public partial class GuildMember
{
    /// <summary>
    /// Guild Identificator
    /// </summary>
    public uint Guildid { get; set; }

    public uint Guid { get; set; }

    public byte Rank { get; set; }

    public string Pnote { get; set; } = null!;

    public string Offnote { get; set; } = null!;
}
