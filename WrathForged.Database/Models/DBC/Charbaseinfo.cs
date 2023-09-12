using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Charbaseinfo
{
    public int Id { get; set; }

    public int? RaceId { get; set; }

    public int? ClassId { get; set; }

    public virtual Chrclass? Class { get; set; }

    public virtual Chrrace? Race { get; set; }
}
