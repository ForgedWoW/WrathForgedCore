// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("ScalingStatDistribution.dbc")]
public partial class Scalingstatdistribution : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32)]
    public int StatId1 { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int StatId2 { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int StatId3 { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int StatId4 { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int StatId5 { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32)]
    public int StatId6 { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int StatId7 { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int StatId8 { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int StatId9 { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int StatId10 { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32)]
    public int Bonus1 { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32)]
    public int Bonus2 { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int Bonus3 { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32)]
    public int Bonus4 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32)]
    public int Bonus5 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32)]
    public int Bonus6 { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32)]
    public int Bonus7 { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32)]
    public int Bonus8 { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.INT32)]
    public int Bonus9 { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.INT32)]
    public int Bonus10 { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32)]
    public int Maxlevel { get; set; }
}
