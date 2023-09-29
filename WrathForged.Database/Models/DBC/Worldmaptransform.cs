// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Worldmaptransform
{
    public int Id { get; set; }

    public int? MapId { get; set; }

    public float RegionMinX { get; set; }

    public float RegionMinY { get; set; }

    public float RegionMaxX { get; set; }

    public float RegionMaxY { get; set; }

    public int? NewMapId { get; set; }

    public float RegionOffsetX { get; set; }

    public float RegionOffsetY { get; set; }

    public int? NewDungeonMapId { get; set; }

    public virtual Map? Map { get; set; }

    public virtual Dungeonmap? NewDungeonMap { get; set; }

    public virtual Map? NewMap { get; set; }
}
