// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Worldmapcontinent
{
    public int Id { get; set; }

    public int? MapId { get; set; }

    public int LeftBoundary { get; set; }

    public int RightBoundary { get; set; }

    public int TopBoundary { get; set; }

    public int BottomBoundary { get; set; }

    public float ContinentOffsetX { get; set; }

    public float ContinentOffsetY { get; set; }

    public float Scale { get; set; }

    public float TaxiMinX { get; set; }

    public float TaxiMinY { get; set; }

    public float TaxiMaxX { get; set; }

    public float TaxiMaxY { get; set; }

    public int WorldMapId { get; set; }

    public virtual Map? Map { get; set; }
}
