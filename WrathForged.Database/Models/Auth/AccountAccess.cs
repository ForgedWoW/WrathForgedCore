using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Auth;

public partial class AccountAccess
{
    public uint AccountId { get; set; }

    public byte SecurityLevel { get; set; }

    public int RealmId { get; set; }

    public string? Comment { get; set; }
}
