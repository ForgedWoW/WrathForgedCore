// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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

    public long Bandate { get; set; }

    public long Unbandate { get; set; }

    public string Bannedby { get; set; } = null!;

    public string Banreason { get; set; } = null!;

    public byte Active { get; set; }
}