using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class AccountInstanceTime
{
    public uint AccountId { get; set; }

    public uint InstanceId { get; set; }

    public ulong ReleaseTime { get; set; }
}
