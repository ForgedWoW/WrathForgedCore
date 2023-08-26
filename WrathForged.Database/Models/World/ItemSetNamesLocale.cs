using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class ItemSetNamesLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? Name { get; set; }

    public int? VerifiedBuild { get; set; }
}
