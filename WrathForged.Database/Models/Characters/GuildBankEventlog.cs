// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

public partial class GuildBankEventlog
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
    /// Guild bank TabId
    /// </summary>
    public byte TabId { get; set; }

    /// <summary>
    /// Event type
    /// </summary>
    public byte EventType { get; set; }

    public uint PlayerGuid { get; set; }

    public uint ItemOrMoney { get; set; }

    public ushort ItemStackCount { get; set; }

    /// <summary>
    /// Destination Tab Id
    /// </summary>
    public byte DestTabId { get; set; }

    /// <summary>
    /// Event UNIX time
    /// </summary>
    public uint TimeStamp { get; set; }
}
