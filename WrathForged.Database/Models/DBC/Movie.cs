using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Movie
{
    public int Id { get; set; }

    public string? Filename { get; set; }

    public int Volume { get; set; }
}
