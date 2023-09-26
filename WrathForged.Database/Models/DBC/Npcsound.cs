// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("NPCSounds.dbc")]
    public partial class Npcsound : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? SoundId1 { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? SoundId2 { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? SoundId3 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? SoundId4 { get; set; }

        // Virtual collections and references are not annotated with DBCPropertyBinding
        public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();
        public virtual Soundentry? SoundId1Navigation { get; set; }
        public virtual Soundentry? SoundId2Navigation { get; set; }
        public virtual Soundentry? SoundId3Navigation { get; set; }
        public virtual Soundentry? SoundId4Navigation { get; set; }
    }
}
