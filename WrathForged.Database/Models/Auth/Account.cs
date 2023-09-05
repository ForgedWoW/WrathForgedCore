// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Auth;

/// <summary>
/// Account System
/// </summary>
public partial class Account
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    public string Username { get; set; } = null!;

    public byte[] Salt { get; set; } = null!;

    public byte[] Verifier { get; set; } = null!;

    public byte[]? SessionKeyAuth { get; set; }

    public byte[]? SessionKeyBnet { get; set; }

    public byte[]? TotpSecret { get; set; }

    public string Email { get; set; } = null!;

    public string RegMail { get; set; } = null!;

    public DateTime Joindate { get; set; }

    public string LastIp { get; set; } = null!;

    public string LastAttemptIp { get; set; } = null!;

    public uint FailedLogins { get; set; }

    public bool Locked { get; set; }

    public string LockCountry { get; set; } = null!;

    public DateTime? LastLogin { get; set; }

    public bool Online { get; set; }

    public byte Expansion { get; set; }

    public long Mutetime { get; set; }

    public string Mutereason { get; set; } = null!;

    public string Muteby { get; set; } = null!;

    public byte Locale { get; set; }

    public string Os { get; set; } = null!;

    public uint Recruiter { get; set; }

    public virtual ICollection<RbacAccountPermission> RbacAccountPermissions { get; set; } = new List<RbacAccountPermission>();
}