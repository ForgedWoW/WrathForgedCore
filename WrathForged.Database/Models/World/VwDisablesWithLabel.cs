using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class VwDisablesWithLabel
{
    public string SourceType { get; set; } = null!;

    public uint Entry { get; set; }

    public short Flags { get; set; }

    public string Params0 { get; set; } = null!;

    public string Params1 { get; set; } = null!;

    public string Comment { get; set; } = null!;
}
