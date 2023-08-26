using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class PageTextLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? Text { get; set; }

    public int? VerifiedBuild { get; set; }
}
