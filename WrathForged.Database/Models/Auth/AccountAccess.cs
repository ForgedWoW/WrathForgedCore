// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Auth;

public partial class AccountAccess
{
    public uint AccountId { get; set; }

    public byte SecurityLevel { get; set; }

    public int RealmId { get; set; }

    public string? Comment { get; set; }
}
