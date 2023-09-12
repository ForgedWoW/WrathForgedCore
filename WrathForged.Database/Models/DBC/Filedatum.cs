using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Filedatum
{
    public int Id { get; set; }

    public string? Filename { get; set; }

    public string? Filepath { get; set; }
}
