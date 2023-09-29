// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Taxipathnode
{
    public int Id { get; set; }

    public int? PathId { get; set; }

    public int NodeIndex { get; set; }

    public int? ContinentId { get; set; }

    public float LocX { get; set; }

    public float LocY { get; set; }

    public float LocZ { get; set; }

    public int Flags { get; set; }

    public int Delay { get; set; }

    public int ArrivalEventId { get; set; }

    public int DepartureEventId { get; set; }

    public virtual Map? Continent { get; set; }

    public virtual Taxipath? Path { get; set; }
}
