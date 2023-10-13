// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("SoundFilterElem.dbc")]
public partial class Soundfilterelem : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int SoundFilterId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int OrderIndex { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int FilterType { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float Params1 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float Params2 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
    public float Params3 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
    public float Params4 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
    public float Params5 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.FLOAT)]
    public float Params6 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.FLOAT)]
    public float Params7 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.FLOAT)]
    public float Params8 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.FLOAT)]
    public float Params9 { get; set; }
}
