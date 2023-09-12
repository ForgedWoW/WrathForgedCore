using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Dungeonmapchunk
{
    public int Id { get; set; }

    public int? MapId { get; set; }

    public int? WmoGroupId { get; set; }

    public int? DungeonMapId { get; set; }

    public float MinZ { get; set; }

    public virtual Dungeonmap? DungeonMap { get; set; }

    public virtual Map? Map { get; set; }
}
