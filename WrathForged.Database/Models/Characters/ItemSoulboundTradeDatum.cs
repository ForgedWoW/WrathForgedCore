// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Item Refund System
/// </summary>
public partial class ItemSoulboundTradeDatum
{
    /// <summary>
    /// Item GUID
    /// </summary>
    public uint ItemGuid { get; set; }

    /// <summary>
    /// Space separated GUID list of players who can receive this item in trade
    /// </summary>
    public string AllowedPlayers { get; set; } = null!;
}
