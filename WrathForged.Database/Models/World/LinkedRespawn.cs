using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Creature Respawn Link System
/// </summary>
public partial class LinkedRespawn
{
    /// <summary>
    /// dependent creature
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// master creature
    /// </summary>
    public uint LinkedGuid { get; set; }

    public byte LinkType { get; set; }
}
