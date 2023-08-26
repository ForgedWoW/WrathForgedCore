using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class GmTicket
{
    public uint Id { get; set; }

    /// <summary>
    /// 0 open, 1 closed, 2 character deleted
    /// </summary>
    public byte Type { get; set; }

    /// <summary>
    /// Global Unique Identifier of ticket creator
    /// </summary>
    public uint PlayerGuid { get; set; }

    /// <summary>
    /// Name of ticket creator
    /// </summary>
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint CreateTime { get; set; }

    public ushort MapId { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public uint LastModifiedTime { get; set; }

    public int ClosedBy { get; set; }

    /// <summary>
    /// GUID of admin to whom ticket is assigned
    /// </summary>
    public uint AssignedTo { get; set; }

    public string Comment { get; set; } = null!;

    public string Response { get; set; } = null!;

    public byte Completed { get; set; }

    public byte Escalated { get; set; }

    public byte Viewed { get; set; }

    public byte NeedMoreHelp { get; set; }

    /// <summary>
    /// GUID of GM who resolved the ticket
    /// </summary>
    public int ResolvedBy { get; set; }
}
