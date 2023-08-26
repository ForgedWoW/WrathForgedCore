using System;
using System.Collections.Generic;

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
