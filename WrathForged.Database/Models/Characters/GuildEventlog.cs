// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Guild Eventlog
/// </summary>
public partial class GuildEventlog
{
    /// <summary>
    /// Guild Identificator
    /// </summary>
    public uint Guildid { get; set; }

    /// <summary>
    /// Log record identificator - auxiliary column
    /// </summary>
    public uint LogGuid { get; set; }

    /// <summary>
    /// Event type
    /// </summary>
    public byte EventType { get; set; }

    /// <summary>
    /// Player 1
    /// </summary>
    public uint PlayerGuid1 { get; set; }

    /// <summary>
    /// Player 2
    /// </summary>
    public uint PlayerGuid2 { get; set; }

    /// <summary>
    /// New rank(in case promotion/demotion)
    /// </summary>
    public byte NewRank { get; set; }

    /// <summary>
    /// Event UNIX time
    /// </summary>
    public uint TimeStamp { get; set; }
}
