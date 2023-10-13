// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SoundSamplePreferences.dbc")]
public partial class Soundsamplepreference : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Field01 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Field02 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Field03 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Field04 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Field05 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int Field06 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int Field07 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
    public float Field08 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.FLOAT)]
    public float Field09 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int Field10 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int Field11 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int Field12 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.FLOAT)]
    public float Field13 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int Field14 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.FLOAT)]
    public float Field15 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32)]
    public int Field16 { get; set; }
}
