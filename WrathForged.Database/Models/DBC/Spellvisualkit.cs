// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC
{
    [DBCBound("SpellVisualKit.dbc")]
    public partial class Spellvisualkit : IDBCRecord
    {
        [DBCPropertyBinding(0, DBCBindingType.INT32)]
        public int Id { get; set; }

        [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
        public int? StartAnimId { get; set; }

        [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
        public int? AnimId { get; set; }

        [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
        public int? HeadEffect { get; set; }

        [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
        public int? ChestEffect { get; set; }

        [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
        public int? BaseEffect { get; set; }

        [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
        public int? LeftHandEffect { get; set; }

        [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
        public int? RightHandEffect { get; set; }

        [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
        public int? BreathEffect { get; set; }

        [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
        public int? LeftWeaponEffect { get; set; }

        [DBCPropertyBinding(10, DBCBindingType.INT32, Nullable = true)]
        public int? RightWeaponEffect { get; set; }

        [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
        public int? SpecialEffect1 { get; set; }

        [DBCPropertyBinding(12, DBCBindingType.INT32, Nullable = true)]
        public int? SpecialEffect2 { get; set; }

        [DBCPropertyBinding(13, DBCBindingType.INT32, Nullable = true)]
        public int? SpecialEffect3 { get; set; }

        [DBCPropertyBinding(14, DBCBindingType.INT32, Nullable = true)]
        public int? WorldEffect { get; set; }

        [DBCPropertyBinding(15, DBCBindingType.INT32, Nullable = true)]
        public int? SoundId { get; set; }

        [DBCPropertyBinding(16, DBCBindingType.INT32, Nullable = true)]
        public int? ShakeId { get; set; }

        [DBCPropertyBinding(17, DBCBindingType.INT32)]
        public int CharProc1 { get; set; }

        [DBCPropertyBinding(18, DBCBindingType.INT32)]
        public int CharProc2 { get; set; }

        [DBCPropertyBinding(19, DBCBindingType.INT32)]
        public int CharProc3 { get; set; }

        [DBCPropertyBinding(20, DBCBindingType.INT32)]
        public int CharProc4 { get; set; }

        [DBCPropertyBinding(21, DBCBindingType.FLOAT)]
        public float CharParamZero1 { get; set; }

        [DBCPropertyBinding(22, DBCBindingType.FLOAT)]
        public float CharParamZero2 { get; set; }

        [DBCPropertyBinding(23, DBCBindingType.FLOAT)]
        public float CharParamZero3 { get; set; }

        [DBCPropertyBinding(24, DBCBindingType.FLOAT)]
        public float CharParamZero4 { get; set; }

        [DBCPropertyBinding(25, DBCBindingType.FLOAT)]
        public float CharParamOne1 { get; set; }

        [DBCPropertyBinding(26, DBCBindingType.FLOAT)]
        public float CharParamOne2 { get; set; }

        [DBCPropertyBinding(27, DBCBindingType.FLOAT)]
        public float CharParamOne3 { get; set; }

        [DBCPropertyBinding(28, DBCBindingType.FLOAT)]
        public float CharParamOne4 { get; set; }

        [DBCPropertyBinding(29, DBCBindingType.FLOAT)]
        public float CharParamTwo1 { get; set; }

        [DBCPropertyBinding(30, DBCBindingType.FLOAT)]
        public float CharParamTwo2 { get; set; }

        [DBCPropertyBinding(31, DBCBindingType.FLOAT)]
        public float CharParamTwo3 { get; set; }

        [DBCPropertyBinding(32, DBCBindingType.FLOAT)]
        public float CharParamTwo4 { get; set; }

        [DBCPropertyBinding(33, DBCBindingType.FLOAT)]
        public float CharParamThree1 { get; set; }

        [DBCPropertyBinding(34, DBCBindingType.FLOAT)]
        public float CharParamThree2 { get; set; }

        [DBCPropertyBinding(35, DBCBindingType.FLOAT)]
        public float CharParamThree3 { get; set; }

        [DBCPropertyBinding(36, DBCBindingType.FLOAT)]
        public float CharParamThree4 { get; set; }

        [DBCPropertyBinding(37, DBCBindingType.INT32)]
        public int Flags { get; set; }

        public virtual Animationdatum? Anim { get; set; }

        public virtual Spellvisualeffectname? BaseEffectNavigation { get; set; }

        public virtual Spellvisualeffectname? BreathEffectNavigation { get; set; }

        public virtual Spellvisualeffectname? ChestEffectNavigation { get; set; }

        public virtual Spellvisualeffectname? HeadEffectNavigation { get; set; }

        public virtual Spellvisualeffectname? LeftHandEffectNavigation { get; set; }

        public virtual Spellvisualeffectname? LeftWeaponEffectNavigation { get; set; }

        public virtual Spellvisualeffectname? RightHandEffectNavigation { get; set; }

        public virtual Spellvisualeffectname? RightWeaponEffectNavigation { get; set; }

        public virtual Spelleffectcamerashake? Shake { get; set; }

        public virtual Soundentry? Sound { get; set; }

        public virtual Spellvisualeffectname? SpecialEffect1Navigation { get; set; }

        public virtual Spellvisualeffectname? SpecialEffect2Navigation { get; set; }

        public virtual Spellvisualeffectname? SpecialEffect3Navigation { get; set; }

        public virtual ICollection<Spellvisual> SpellvisualCastKitNavigations { get; set; } = new List<Spellvisual>();

        public virtual ICollection<Spellvisual> SpellvisualCasterImpactKitNavigations { get; set; } = new List<Spellvisual>();

        public virtual ICollection<Spellvisual> SpellvisualChannelKitNavigations { get; set; } = new List<Spellvisual>();

        public virtual ICollection<Spellvisual> SpellvisualImpactAreaKitNavigations { get; set; } = new List<Spellvisual>();

        public virtual ICollection<Spellvisual> SpellvisualImpactKitNavigations { get; set; } = new List<Spellvisual>();

        public virtual ICollection<Spellvisual> SpellvisualInstantAreaKitNavigations { get; set; } = new List<Spellvisual>();

        public virtual ICollection<Spellvisual> SpellvisualMissileTargetingKitNavigations { get; set; } = new List<Spellvisual>();

        public virtual ICollection<Spellvisual> SpellvisualPersistentAreaKitNavigations { get; set; } = new List<Spellvisual>();

        public virtual ICollection<Spellvisual> SpellvisualPrecastKitNavigations { get; set; } = new List<Spellvisual>();

        public virtual ICollection<Spellvisual> SpellvisualStateDoneKitNavigations { get; set; } = new List<Spellvisual>();

        public virtual ICollection<Spellvisual> SpellvisualStateKitNavigations { get; set; } = new List<Spellvisual>();

        public virtual ICollection<Spellvisual> SpellvisualTargetImpactKitNavigations { get; set; } = new List<Spellvisual>();

        public virtual ICollection<Spellvisualkitmodelattach> Spellvisualkitmodelattaches { get; set; } = new List<Spellvisualkitmodelattach>();

        public virtual Animationdatum? StartAnim { get; set; }

        public virtual Spellvisualeffectname? WorldEffectNavigation { get; set; }
    }
}
