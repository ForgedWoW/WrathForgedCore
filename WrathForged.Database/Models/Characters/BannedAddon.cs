// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Security.Cryptography;
using System.Text;

namespace WrathForged.Database.Models.Characters;

public partial class BannedAddon
{
    public uint Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Version { get; set; } = string.Empty;

    public uint Timestamp { get; set; }

    public virtual byte[] NameMD5 => MD5.HashData(Encoding.ASCII.GetBytes(Name));
    public virtual byte[] VersionMD5 => MD5.HashData(Encoding.ASCII.GetBytes(Version));
}
