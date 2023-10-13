// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("DungeonMap.dbc")]
public partial class Dungeonmap : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? MapId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int FloorIndex { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float MinX { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float MaxX { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float MinY { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
    public float MaxY { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
    public int? ParentWorldMapId { get; set; }

    public virtual ICollection<Dungeonmapchunk> Dungeonmapchunks { get; set; } = new List<Dungeonmapchunk>();
    public virtual Map? Map { get; set; }
    public virtual Worldmaparea? ParentWorldMap { get; set; }
    public virtual ICollection<Worldmaparea> Worldmapareas { get; set; } = new List<Worldmaparea>();
    public virtual ICollection<Worldmaptransform> Worldmaptransforms { get; set; } = new List<Worldmaptransform>();
}
