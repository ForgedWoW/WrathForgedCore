// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Auth;

/// <summary>
/// Banned IPs
/// </summary>
public partial class IpBanned
{
    public string Ip { get; set; } = null!;

    public long Bandate { get; set; }

    public long Unbandate { get; set; }

    public string Bannedby { get; set; } = null!;

    public string Banreason { get; set; } = null!;
}