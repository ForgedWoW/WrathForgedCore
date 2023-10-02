// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("TransportPhysics.dbc")]
    public partial class Transportphysic : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.FLOAT)]
        public float WaveAmp { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
        public float WaveTimeScale { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
        public float RollAmp { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
        public float RollTimeScale { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
        public float PitchAmp { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
        public float PitchTimeScale { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
        public float MaxBank { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
        public float MaxBankTurnSpeed { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.FLOAT)]
        public float SpeedDampThresh { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.FLOAT)]
        public float SpeedDamp { get; set; }
    }
}
