// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("WeaponImpactSounds.dbc")]
    public partial class Weaponimpactsound : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32)]
        public int WeaponSubClassId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32)]
        public int ParrySoundType { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? ImpactSoundId1 { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? ImpactSoundId2 { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
        public int? ImpactSoundId3 { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
        public int? ImpactSoundId4 { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
        public int? ImpactSoundId5 { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
        public int? ImpactSoundId6 { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
        public int? ImpactSoundId7 { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32, Nullable = true)]
        public int? ImpactSoundId8 { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
        public int? ImpactSoundId9 { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32, Nullable = true)]
        public int? ImpactSoundId10 { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32, Nullable = true)]
        public int? CritImpactSoundId1 { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.INT32, Nullable = true)]
        public int? CritImpactSoundId2 { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.INT32, Nullable = true)]
        public int? CritImpactSoundId3 { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.INT32, Nullable = true)]
        public int? CritImpactSoundId4 { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.INT32, Nullable = true)]
        public int? CritImpactSoundId5 { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.INT32, Nullable = true)]
        public int? CritImpactSoundId6 { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.INT32, Nullable = true)]
        public int? CritImpactSoundId7 { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.INT32, Nullable = true)]
        public int? CritImpactSoundId8 { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.INT32, Nullable = true)]
        public int? CritImpactSoundId9 { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.INT32, Nullable = true)]
        public int? CritImpactSoundId10 { get; set; }

        public virtual Soundentry? CritImpactSoundId10Navigation { get; set; }
        public virtual Soundentry? CritImpactSoundId1Navigation { get; set; }
        public virtual Soundentry? CritImpactSoundId2Navigation { get; set; }
        public virtual Soundentry? CritImpactSoundId3Navigation { get; set; }
        public virtual Soundentry? CritImpactSoundId4Navigation { get; set; }
        public virtual Soundentry? CritImpactSoundId5Navigation { get; set; }
        public virtual Soundentry? CritImpactSoundId6Navigation { get; set; }
        public virtual Soundentry? CritImpactSoundId7Navigation { get; set; }
        public virtual Soundentry? CritImpactSoundId8Navigation { get; set; }
        public virtual Soundentry? CritImpactSoundId9Navigation { get; set; }
        public virtual Soundentry? ImpactSoundId10Navigation { get; set; }
        public virtual Soundentry? ImpactSoundId1Navigation { get; set; }
        public virtual Soundentry? ImpactSoundId2Navigation { get; set; }
        public virtual Soundentry? ImpactSoundId3Navigation { get; set; }
        public virtual Soundentry? ImpactSoundId4Navigation { get; set; }
        public virtual Soundentry? ImpactSoundId5Navigation { get; set; }
        public virtual Soundentry? ImpactSoundId6Navigation { get; set; }
        public virtual Soundentry? ImpactSoundId7Navigation { get; set; }
        public virtual Soundentry? ImpactSoundId8Navigation { get; set; }
        public virtual Soundentry? ImpactSoundId9Navigation { get; set; }
    }
}
