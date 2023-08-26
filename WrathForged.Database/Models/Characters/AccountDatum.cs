using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class AccountDatum
{
    /// <summary>
    /// Account Identifier
    /// </summary>
    public uint AccountId { get; set; }

    public byte Type { get; set; }

    public uint Time { get; set; }

    public byte[] Data { get; set; } = null!;
}
