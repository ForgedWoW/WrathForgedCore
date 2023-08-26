using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class NpcTextLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? Text00 { get; set; }

    public string? Text01 { get; set; }

    public string? Text10 { get; set; }

    public string? Text11 { get; set; }

    public string? Text20 { get; set; }

    public string? Text21 { get; set; }

    public string? Text30 { get; set; }

    public string? Text31 { get; set; }

    public string? Text40 { get; set; }

    public string? Text41 { get; set; }

    public string? Text50 { get; set; }

    public string? Text51 { get; set; }

    public string? Text60 { get; set; }

    public string? Text61 { get; set; }

    public string? Text70 { get; set; }

    public string? Text71 { get; set; }
}
