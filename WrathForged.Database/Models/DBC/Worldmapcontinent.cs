// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("WorldMapContinent.dbc")]
public partial class Worldmapcontinent : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? MapId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int LeftBoundary { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32)]
    public int RightBoundary { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32)]
    public int TopBoundary { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32)]
    public int BottomBoundary { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
    public float ContinentOffsetX { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
    public float ContinentOffsetY { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
    public float Scale { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.FLOAT)]
    public float TaxiMinX { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.FLOAT)]
    public float TaxiMinY { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.FLOAT)]
    public float TaxiMaxX { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.FLOAT)]
    public float TaxiMaxY { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32)]
    public int WorldMapId { get; set; }

    public virtual Map? Map { get; set; }
}
