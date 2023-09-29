// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

public partial class GuildBankTab
{
    public uint Guildid { get; set; }

    public byte TabId { get; set; }

    public string TabName { get; set; } = null!;

    public string TabIcon { get; set; } = null!;

    public string? TabText { get; set; }
}
