// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Item Refund System
/// </summary>
public partial class ItemRefundInstance
{
    /// <summary>
    /// Item GUID
    /// </summary>
    public uint ItemGuid { get; set; }

    /// <summary>
    /// Player GUID
    /// </summary>
    public uint PlayerGuid { get; set; }

    public uint PaidMoney { get; set; }

    public ushort PaidExtendedCost { get; set; }
}
