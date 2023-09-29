// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Auth;

public partial class Log
{
    public uint Time { get; set; }

    public uint Realm { get; set; }

    public string Type { get; set; } = null!;

    public byte Level { get; set; }

    public string? String { get; set; }
}
