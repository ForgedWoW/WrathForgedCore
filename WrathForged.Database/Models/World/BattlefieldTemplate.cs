using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class BattlefieldTemplate
{
    public byte TypeId { get; set; }

    public string ScriptName { get; set; } = null!;

    public string? Comment { get; set; }
}
