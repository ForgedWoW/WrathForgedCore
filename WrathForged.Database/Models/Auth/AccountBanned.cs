using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Auth;

/// <summary>
/// Ban List
/// </summary>
public partial class AccountBanned
{
    /// <summary>
    /// Account id
    /// </summary>
    public uint Id { get; set; }

    public uint Bandate { get; set; }

    public uint Unbandate { get; set; }

    public string Bannedby { get; set; } = null!;

    public string Banreason { get; set; } = null!;

    public byte Active { get; set; }
}
