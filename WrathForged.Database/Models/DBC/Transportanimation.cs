using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Transportanimation
{
    public int Id { get; set; }

    public int TransportId { get; set; }

    public int TimeIndex { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public int? SequenceId { get; set; }

    public virtual Animationdatum? Sequence { get; set; }
}
