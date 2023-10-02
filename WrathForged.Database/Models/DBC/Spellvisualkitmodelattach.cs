// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SpellVisualKitModelAttach.dbc")]
    public partial class Spellvisualkitmodelattach : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? ParentSpellVisualKitId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? SpellVisualEffectNameId { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32)]
        public int AttachmentId { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
        public float OffsetX { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
        public float OffsetY { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
        public float OffsetZ { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
        public float Yaw { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.FLOAT)]
        public float Pitch { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.FLOAT)]
        public float Roll { get; set; }

        public virtual Spellvisualkit? ParentSpellVisualKit { get; set; }
        public virtual Spellvisualeffectname? SpellVisualEffectName { get; set; }
    }
}
