// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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
