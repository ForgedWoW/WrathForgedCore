using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Soundemitter
{
    public int Id { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public float DirectionX { get; set; }

    public float DirectionY { get; set; }

    public float DirectionZ { get; set; }

    public int? SoundEntriesId { get; set; }

    public int? MapId { get; set; }

    public string? Name { get; set; }

    public virtual Map? Map { get; set; }

    public virtual Soundentry? SoundEntries { get; set; }
}
