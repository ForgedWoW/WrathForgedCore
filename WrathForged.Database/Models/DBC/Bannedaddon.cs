using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Bannedaddon
{
    public int Id { get; set; }

    public uint NameMd51 { get; set; }

    public uint NameMd52 { get; set; }

    public uint NameMd53 { get; set; }

    public uint NameMd54 { get; set; }

    public uint VersionMd51 { get; set; }

    public uint VersionMd52 { get; set; }

    public uint VersionMd53 { get; set; }

    public uint VersionMd54 { get; set; }

    public int LastModified { get; set; }

    public int Flags { get; set; }
}
