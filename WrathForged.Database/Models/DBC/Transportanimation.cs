// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("TransportAnimation.dbc")]
    public partial class Transportanimation : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int TransportId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int TimeIndex { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
        public float PosX { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
        public float PosY { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
        public float PosZ { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
        public int? SequenceId { get; set; }

        public virtual Animationdatum? Sequence { get; set; }
    }
}
