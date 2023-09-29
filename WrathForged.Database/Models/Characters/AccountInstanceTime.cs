// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

public partial class AccountInstanceTime
{
    public uint AccountId { get; set; }

    public uint InstanceId { get; set; }

    public ulong ReleaseTime { get; set; }
}
