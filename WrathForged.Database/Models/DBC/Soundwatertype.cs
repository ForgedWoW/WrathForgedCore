using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Soundwatertype
{
    public int Id { get; set; }

    public int LiquidTypeId { get; set; }

    public int FluidSpeed { get; set; }

    public int? SoundId { get; set; }

    public virtual Soundentry? Sound { get; set; }
}
