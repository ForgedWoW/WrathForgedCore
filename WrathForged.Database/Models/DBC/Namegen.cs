using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Namegen
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? RaceId { get; set; }

    public int Sex { get; set; }

    public virtual Chrrace? Race { get; set; }
}
