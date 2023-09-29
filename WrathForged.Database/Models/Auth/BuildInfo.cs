// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Auth;

public partial class BuildInfo
{
    public uint Build { get; set; }

    public int? MajorVersion { get; set; }

    public int? MinorVersion { get; set; }

    public int? BugfixVersion { get; set; }

    public string? HotfixVersion { get; set; }

    public string? WinAuthSeed { get; set; }

    public string? Win64AuthSeed { get; set; }

    public string? Mac64AuthSeed { get; set; }

    public string? WinChecksumSeed { get; set; }

    public string? MacChecksumSeed { get; set; }
}
