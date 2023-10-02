// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("UISoundLookups.dbc")]
    public partial class Uisoundlookup : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? SoundId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.STRING, Nullable = true)]
        public string? Name { get; set; }

        public virtual Soundentry? Sound { get; set; }
    }
}
