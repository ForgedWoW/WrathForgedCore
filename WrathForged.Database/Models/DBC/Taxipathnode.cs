﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("TaxiPathNode.dbc")]
public partial class Taxipathnode : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? PathId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int NodeIndex { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? ContinentId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float LocX { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float LocY { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
    public float LocZ { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32)]
    public int Flags { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32)]
    public int Delay { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32)]
    public int ArrivalEventId { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32)]
    public int DepartureEventId { get; set; }

    public virtual Map? Continent { get; set; }
    public virtual Taxipath? Path { get; set; }
}
