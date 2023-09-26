// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("BannedAddOns.dbc")]
public partial class Bannedaddon : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.UINT32)]
    public uint NameMd51 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.UINT32)]
    public uint NameMd52 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.UINT32)]
    public uint NameMd53 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.UINT32)]
    public uint NameMd54 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.UINT32)]
    public uint VersionMd51 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.UINT32)]
    public uint VersionMd52 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.UINT32)]
    public uint VersionMd53 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.UINT32)]
    public uint VersionMd54 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int LastModified { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int Flags { get; set; }
}