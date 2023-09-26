// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("PvpDifficulty.dbc")]
    public partial class Pvpdifficulty : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? MapId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int RangeIndex { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int MinLevel { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32)]
        public int MaxLevel { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32)]
        public int Difficulty { get; set; }

        // Virtual collections and references are not annotated with DBCPropertyBinding
        public virtual Map? Map { get; set; }
    }
}
