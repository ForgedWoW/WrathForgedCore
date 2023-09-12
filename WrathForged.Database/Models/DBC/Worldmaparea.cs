using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Worldmaparea
{
    public int Id { get; set; }

    public int? MapId { get; set; }

    public int? AreaId { get; set; }

    public string? AreaName { get; set; }

    public float LocLeft { get; set; }

    public float LocRight { get; set; }

    public float LocTop { get; set; }

    public float LocBottom { get; set; }

    public int? DisplayMapId { get; set; }

    public int? DefaultDungeonFloor { get; set; }

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
