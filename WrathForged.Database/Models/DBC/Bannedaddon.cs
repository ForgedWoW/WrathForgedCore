// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("BannedAddOns.dbc")]
public partial class Bannedaddon
{
    [DBCPropertyBinding(0, DBCBindingType.UINT)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.UINT)]
    public uint NameMd51 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.UINT)]
    public uint NameMd52 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.UINT)]
    public uint NameMd53 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.UINT)]
    public uint NameMd54 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.UINT)]
    public uint VersionMd51 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.UINT)]
    public uint VersionMd52 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.UINT)]
    public uint VersionMd53 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.UINT)]
    public uint VersionMd54 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.UINT)]
    public int LastModified { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.UINT)]
    public int Flags { get; set; }
}