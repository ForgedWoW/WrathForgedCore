// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
