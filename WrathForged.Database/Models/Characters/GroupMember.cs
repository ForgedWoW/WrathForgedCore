using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Groups
/// </summary>
public partial class GroupMember
{
    public uint Guid { get; set; }

    public uint MemberGuid { get; set; }

    public byte MemberFlags { get; set; }

    public byte Subgroup { get; set; }

    public byte Roles { get; set; }
}
