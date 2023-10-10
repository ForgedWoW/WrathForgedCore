// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Guild System
/// </summary>
public partial class GuildRank
{
    public uint Guildid { get; set; }

    public byte Rid { get; set; }

    public string Rname { get; set; } = null!;

    public uint Rights { get; set; }

    public uint BankMoneyPerDay { get; set; }
}
