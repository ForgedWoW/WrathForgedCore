using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Movievariation
{
    public int Id { get; set; }

    public int MovieId { get; set; }

    public int FileDataId { get; set; }
}
