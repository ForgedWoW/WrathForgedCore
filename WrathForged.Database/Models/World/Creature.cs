using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Creature System
/// </summary>
public partial class Creature
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Creature Identifier
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// Map Identifier
    /// </summary>
    public ushort Map { get; set; }

    /// <summary>
    /// Zone Identifier
    /// </summary>
    public ushort ZoneId { get; set; }

    /// <summary>
    /// Area Identifier
    /// </summary>
    public ushort AreaId { get; set; }

    public byte SpawnMask { get; set; }

    public uint PhaseMask { get; set; }

    public uint Modelid { get; set; }

    public sbyte EquipmentId { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public float Orientation { get; set; }

    public uint Spawntimesecs { get; set; }

    public float WanderDistance { get; set; }

    public uint Currentwaypoint { get; set; }

    public uint Curhealth { get; set; }

    public uint Curmana { get; set; }

    public byte MovementType { get; set; }

    public uint Npcflag { get; set; }

    public uint UnitFlags { get; set; }

    public uint Dynamicflags { get; set; }

    public string? ScriptName { get; set; }

    public int? VerifiedBuild { get; set; }
}
