// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("RandPropPoints.dbc")]
public partial class Randproppoint : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int Epic1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int Epic2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int Epic3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int Epic4 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int Epic5 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int Superior1 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int Superior2 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int Superior3 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int Superior4 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int Superior5 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int Good1 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int Good2 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int Good3 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int Good4 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32)]
    public int Good5 { get; set; }
}
