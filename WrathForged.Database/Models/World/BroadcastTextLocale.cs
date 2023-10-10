// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class BroadcastTextLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? Text { get; set; }

    public string? Text1 { get; set; }

    public int? VerifiedBuild { get; set; }
}
