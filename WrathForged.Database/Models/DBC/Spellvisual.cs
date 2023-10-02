// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SpellVisual.dbc")]
    public partial class Spellvisual : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? PrecastKit { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? CastKit { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? ImpactKit { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? StateKit { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
        public int? StateDoneKit { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
        public int? ChannelKit { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32)]
        public int HasMissile { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
        public int? MissileModel { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32)]
        public int MissilePathType { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32)]
        public int MissileDestinationAttachment { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
        public int? MissileSound { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32, Nullable = true)]
        public int? AnimEventSoundId { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32)]
        public int Flags { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.INT32, Nullable = true)]
        public int? CasterImpactKit { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.INT32, Nullable = true)]
        public int? TargetImpactKit { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.INT32)]
        public int MissileAttachment { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.INT32)]
        public int MissileFollowGroundHeight { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.INT32)]
        public int MissileFollowGroundDropSpeed { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.INT32)]
        public int MissileFollowGroundApproach { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.INT32)]
        public int MissileFollowGroundFlags { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.INT32)]
        public int MissileMotion { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.INT32, Nullable = true)]
        public int? MissileTargetingKit { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.INT32, Nullable = true)]
        public int? InstantAreaKit { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.INT32, Nullable = true)]
        public int? ImpactAreaKit { get; set; }

        [DBCPropertyBinding(25, DBCBindingType.INT32, Nullable = true)]
        public int? PersistentAreaKit { get; set; }

        [DBCPropertyBinding(26, DBCBindingType.FLOAT)]
        public float MissileCastOffsetX { get; set; }

        [DBCPropertyBinding(27, DBCBindingType.FLOAT)]
        public float MissileCastOffsetY { get; set; }

        [DBCPropertyBinding(28, DBCBindingType.FLOAT)]
        public float MissileCastOffsetZ { get; set; }

        [DBCPropertyBinding(29, DBCBindingType.FLOAT)]
        public float MissileImpactOffsetX { get; set; }

        [DBCPropertyBinding(30, DBCBindingType.FLOAT)]
        public float MissileImpactOffsetY { get; set; }

        [DBCPropertyBinding(31, DBCBindingType.FLOAT)]
        public float MissileImpactOffsetZ { get; set; }

        public virtual Soundentry? AnimEventSound { get; set; }

        public virtual Spellvisualkit? CastKitNavigation { get; set; }

        public virtual Spellvisualkit? CasterImpactKitNavigation { get; set; }

        public virtual Spellvisualkit? ChannelKitNavigation { get; set; }

        public virtual Spellvisualkit? ImpactAreaKitNavigation { get; set; }

        public virtual Spellvisualkit? ImpactKitNavigation { get; set; }

        public virtual Spellvisualkit? InstantAreaKitNavigation { get; set; }

        public virtual Spellvisualeffectname? MissileModelNavigation { get; set; }

        public virtual Soundentry? MissileSoundNavigation { get; set; }

        public virtual Spellvisualkit? MissileTargetingKitNavigation { get; set; }

        public virtual Spellvisualkit? PersistentAreaKitNavigation { get; set; }

        public virtual Spellvisualkit? PrecastKitNavigation { get; set; }

        public virtual ICollection<Spell> SpellSpellVisualId1Navigations { get; set; } = new List<Spell>();

        public virtual ICollection<Spell> SpellSpellVisualId2Navigations { get; set; } = new List<Spell>();

        public virtual Spellvisualkit? StateDoneKitNavigation { get; set; }

        public virtual Spellvisualkit? StateKitNavigation { get; set; }

        public virtual Spellvisualkit? TargetImpactKitNavigation { get; set; }
    }
}