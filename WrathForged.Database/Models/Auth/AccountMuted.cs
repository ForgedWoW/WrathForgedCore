// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
