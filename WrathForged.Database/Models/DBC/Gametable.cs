using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Gametable
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int NumRows { get; set; }

    public int NumColumns { get; set; }
}
