// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CharHairTextures.dbc")]
public partial class Charhairtexture : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? Race { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.UINT8)]
    public byte Gender { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.UINT8)]
    public byte Field03 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Field041 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Field042 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int Field043 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int Field044 { get; set; }

    public virtual Chrrace? RaceNavigation { get; set; }
}