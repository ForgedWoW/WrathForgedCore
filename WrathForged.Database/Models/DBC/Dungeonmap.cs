using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Dungeonmap
{
    public int Id { get; set; }

    public int? MapId { get; set; }

    public int FloorIndex { get; set; }

    public float MinX { get; set; }

    public float MaxX { get; set; }

    public float MinY { get; set; }

    public float MaxY { get; set; }

    public int? ParentWorldMapId { get; set; }

    public virtual ICollection<Dungeonmapchunk> Dungeonmapchunks { get; set; } = new List<Dungeonmapchunk>();

    public virtual Map? Map { get; set; }

    public virtual Worldmaparea? ParentWorldMap { get; set; }

    public virtual ICollection<Worldmaparea> Worldmapareas { get; set; } = new List<Worldmaparea>();

    public virtual ICollection<Worldmaptransform> Worldmaptransforms { get; set; } = new List<Worldmaptransform>();
}
