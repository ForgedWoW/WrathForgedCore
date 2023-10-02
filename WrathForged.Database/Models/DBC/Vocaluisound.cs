// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("VocalUISounds.dbc")]
    public partial class Vocaluisound : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int VocalUienum { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? RaceId { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? NormalSoundId1 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? NormalSoundId2 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
        public int? PissedSoundId1 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
        public int? PissedSoundId2 { get; set; }

        public virtual Soundentry? NormalSoundId1Navigation { get; set; }
        public virtual Soundentry? NormalSoundId2Navigation { get; set; }
        public virtual Soundentry? PissedSoundId1Navigation { get; set; }
        public virtual Soundentry? PissedSoundId2Navigation { get; set; }
        public virtual Chrrace? Race { get; set; }
    }
}
