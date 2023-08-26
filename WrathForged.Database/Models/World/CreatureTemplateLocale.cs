using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class CreatureTemplateLocale
{
    public uint Entry { get; set; }

    public string Locale { get; set; } = null!;

    public string? Name { get; set; }

    public string? Title { get; set; }

    public int? VerifiedBuild { get; set; }
}
