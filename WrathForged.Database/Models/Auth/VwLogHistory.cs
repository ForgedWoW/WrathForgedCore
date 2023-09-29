// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Auth;

public partial class VwLogHistory
{
    public DateTime? FirstLogged { get; set; }

    public DateTime? LastLogged { get; set; }

    public long Occurrences { get; set; }

    public string? Realm { get; set; }

    public string Type { get; set; } = null!;

    public byte Level { get; set; }

    public string? String { get; set; }
}
