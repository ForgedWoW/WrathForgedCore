// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("WorldMapTransforms.dbc")]
public partial class Worldmaptransform : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? MapId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
    public float RegionMinX { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float RegionMinY { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float RegionMaxX { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float RegionMaxY { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
    public int? NewMapId { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
    public float RegionOffsetX { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
    public float RegionOffsetY { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
    public int? NewDungeonMapId { get; set; }

    public virtual Map? Map { get; set; }
    public virtual Dungeonmap? NewDungeonMap { get; set; }
    public virtual Map? NewMap { get; set; }
}
