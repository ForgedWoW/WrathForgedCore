using System;
using System.Collections.Generic;

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
