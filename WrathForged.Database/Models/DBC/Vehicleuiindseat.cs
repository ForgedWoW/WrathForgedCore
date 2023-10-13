// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("VehicleUIIndSeat.dbc")]
public partial class Vehicleuiindseat : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? VehicleUiindicatorId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32)]
    public int VirtualSeatIndex { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float Xpos { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float Ypos { get; set; }

    public virtual Vehicleuiindicator? VehicleUiindicator { get; set; }
}
