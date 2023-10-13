// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("LightIntBand.dbc")]
public partial class Lightintband : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Num { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Time1 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Time2 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Time3 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Time4 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int Time5 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int Time6 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int Time7 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int Time8 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int Time9 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int Time10 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int Time11 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int Time12 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int Time13 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32)]
    public int Time14 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32)]
    public int Time15 { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32)]
    public int Time16 { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public int Data1 { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.INT32)]
    public int Data2 { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.INT32)]
    public int Data3 { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32)]
    public int Data4 { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int Data5 { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.INT32)]
    public int Data6 { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.INT32)]
    public int Data7 { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.INT32)]
    public int Data8 { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.INT32)]
    public int Data9 { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.INT32)]
    public int Data10 { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.INT32)]
    public int Data11 { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.INT32)]
    public int Data12 { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.INT32)]
    public int Data13 { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.INT32)]
    public int Data14 { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.INT32)]
    public int Data15 { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.INT32)]
    public int Data16 { get; set; }
}
