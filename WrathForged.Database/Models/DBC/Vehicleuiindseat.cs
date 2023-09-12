using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Vehicleuiindseat
{
    public int Id { get; set; }

    public int? VehicleUiindicatorId { get; set; }

    public int VirtualSeatIndex { get; set; }

    public float Xpos { get; set; }

    public float Ypos { get; set; }

    public virtual Vehicleuiindicator? VehicleUiindicator { get; set; }
}
