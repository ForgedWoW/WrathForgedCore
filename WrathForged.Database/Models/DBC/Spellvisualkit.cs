using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellvisualkit
{
    public int Id { get; set; }

    public int? StartAnimId { get; set; }

    public int? AnimId { get; set; }

    public int? HeadEffect { get; set; }

    public int? ChestEffect { get; set; }

    public int? BaseEffect { get; set; }

    public int? LeftHandEffect { get; set; }

    public int? RightHandEffect { get; set; }

    public int? BreathEffect { get; set; }

    public int? LeftWeaponEffect { get; set; }

    public int? RightWeaponEffect { get; set; }

    public int? SpecialEffect1 { get; set; }

    public int? SpecialEffect2 { get; set; }

    public int? SpecialEffect3 { get; set; }

    public int? WorldEffect { get; set; }

    public int? SoundId { get; set; }

    public int? ShakeId { get; set; }

    public int CharProc1 { get; set; }

    public int CharProc2 { get; set; }

    public int CharProc3 { get; set; }

    public int CharProc4 { get; set; }

    public float CharParamZero1 { get; set; }

    public float CharParamZero2 { get; set; }

    public float CharParamZero3 { get; set; }

    public float CharParamZero4 { get; set; }

    public float CharParamOne1 { get; set; }

    public float CharParamOne2 { get; set; }

    public float CharParamOne3 { get; set; }

    public float CharParamOne4 { get; set; }

    public float CharParamTwo1 { get; set; }

    public float CharParamTwo2 { get; set; }

    public float CharParamTwo3 { get; set; }

    public float CharParamTwo4 { get; set; }

    public float CharParamThree1 { get; set; }

    public float CharParamThree2 { get; set; }

    public float CharParamThree3 { get; set; }

    public float CharParamThree4 { get; set; }

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
