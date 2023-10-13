// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Auth;

public class InstanceMaps
{
    public uint InstanceId { get; set; }
    public uint MapId { get; set; }
    public uint Difficulty { get; set; }

    public virtual required InstanceList InstanceList { get; set; }
}
