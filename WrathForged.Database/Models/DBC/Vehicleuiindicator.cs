// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("VehicleUIIndicator.dbc")]
    public partial class Vehicleuiindicator : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.STRING, Nullable = true)]
        public string? BackgroundTexture { get; set; }

        public virtual ICollection<Vehicleuiindseat> Vehicleuiindseats { get; set; } = new List<Vehicleuiindseat>();
    }
}
