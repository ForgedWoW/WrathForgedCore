// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SoundEmitters.dbc")]
    public partial class Soundemitter : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.FLOAT)]
        public float PositionX { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.FLOAT)]
        public float PositionY { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
        public float PositionZ { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
        public float DirectionX { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
        public float DirectionY { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
        public float DirectionZ { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int? SoundEntriesId { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32)]
        public int? MapId { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.STRING)]
        public string? Name { get; set; }

        public virtual Map? Map { get; set; }

        public virtual Soundentry? SoundEntries { get; set; }
    }
}
