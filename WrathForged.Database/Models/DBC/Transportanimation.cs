// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
