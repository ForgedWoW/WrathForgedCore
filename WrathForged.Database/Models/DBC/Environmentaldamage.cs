using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Environmentaldamage
{
    public int Id { get; set; }

    public int EnumId { get; set; }

    public int? VisualkitId { get; set; }

    public virtual Soundentry? Visualkit { get; set; }
}
