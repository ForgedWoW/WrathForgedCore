// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Worldmapoverlay
{
    public int Id { get; set; }

    public int? MapAreaId { get; set; }

    public int? AreaId1 { get; set; }

    public int? AreaId2 { get; set; }

    public int? AreaId3 { get; set; }

    public int? AreaId4 { get; set; }

    public int MapPointX { get; set; }

    public int MapPointY { get; set; }

    public string? TextureName { get; set; }

    public int TextureWidth { get; set; }

    public int TextureHeight { get; set; }

    public int OffsetX { get; set; }

    public int OffsetY { get; set; }

    public int HitRectTop { get; set; }

    public int HitRectLeft { get; set; }

    public int HitRectBottom { get; set; }

    public int HitRectRight { get; set; }

    public virtual Areatable? AreaId1Navigation { get; set; }

    public virtual Areatable? AreaId2Navigation { get; set; }

    public virtual Areatable? AreaId3Navigation { get; set; }

    public virtual Areatable? AreaId4Navigation { get; set; }

    public virtual Worldmaparea? MapArea { get; set; }
}
