// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("Light.dbc")]
public partial class Light : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int ContinentId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
    public float X { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float Y { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float Z { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float FalloffStart { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
    public float FalloffEnd { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int LightParamsId1 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int LightParamsId2 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int LightParamsId3 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int LightParamsId4 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int LightParamsId5 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int LightParamsId6 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int LightParamsId7 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int LightParamsId8 { get; set; }

    public virtual ICollection<Areatable> Areatables { get; set; } = new List<Areatable>();
}
