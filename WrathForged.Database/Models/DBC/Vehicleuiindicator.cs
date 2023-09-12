using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Vehicleuiindicator
{
    public int Id { get; set; }

    public string? BackgroundTexture { get; set; }

    public virtual ICollection<Vehicleuiindseat> Vehicleuiindseats { get; set; } = new List<Vehicleuiindseat>();
}
