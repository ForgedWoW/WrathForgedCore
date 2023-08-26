using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Auth;

/// <summary>
/// Used to log ips of individual actions
/// </summary>
public partial class LogsIpAction
{
    /// <summary>
    /// Unique Identifier
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// Account ID
    /// </summary>
    public uint AccountId { get; set; }

    /// <summary>
    /// Character Guid
    /// </summary>
    public ulong CharacterGuid { get; set; }

    /// <summary>
    /// Realm ID
    /// </summary>
    public uint RealmId { get; set; }

    public byte Type { get; set; }

    public string Ip { get; set; } = null!;

    /// <summary>
    /// Notes inserted by system
    /// </summary>
    public string? Systemnote { get; set; }

    /// <summary>
    /// Unixtime
    /// </summary>
    public uint Unixtime { get; set; }

    /// <summary>
    /// Timestamp
    /// </summary>
    public DateTime Time { get; set; }

    /// <summary>
    /// Allows users to add a comment
    /// </summary>
    public string? Comment { get; set; }
}
