using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Auth;

/// <summary>
/// mute List
/// </summary>
public partial class AccountMuted
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public uint Mutedate { get; set; }

    public uint Mutetime { get; set; }

    public string Mutedby { get; set; } = null!;

    public string Mutereason { get; set; } = null!;
}
