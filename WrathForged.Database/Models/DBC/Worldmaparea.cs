// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("WorldMapArea.dbc")]
public partial class Worldmaparea : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? MapId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? AreaId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.STRING, Nullable = true)]
    public string? AreaName { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float LocLeft { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float LocRight { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
    public float LocTop { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
    public float LocBottom { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
    public int? DisplayMapId { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
    public int? DefaultDungeonFloor { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32, Nullable = true)]
    public int? ParentWorldMapId { get; set; }

    public virtual Areatable? Area { get; set; }
    public virtual Dungeonmap? DefaultDungeonFloorNavigation { get; set; }
    public virtual Map? DisplayMap { get; set; }
    public virtual ICollection<Dungeonmap> Dungeonmaps { get; set; } = new List<Dungeonmap>();
    public virtual ICollection<Worldmaparea> InverseParentWorldMap { get; set; } = new List<Worldmaparea>();
    public virtual Map? Map { get; set; }
    public virtual Worldmaparea? ParentWorldMap { get; set; }
    public virtual ICollection<Worldmapoverlay> Worldmapoverlays { get; set; } = new List<Worldmapoverlay>();
}
