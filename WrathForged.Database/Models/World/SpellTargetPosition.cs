using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Spell System
/// </summary>
public partial class SpellTargetPosition
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    public byte EffectIndex { get; set; }

    public ushort MapId { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public float Orientation { get; set; }

    public int? VerifiedBuild { get; set; }
}
