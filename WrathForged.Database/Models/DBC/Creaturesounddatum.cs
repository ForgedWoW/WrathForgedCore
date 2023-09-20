// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CreatureSoundData.dbc")]
public partial class Creaturesounddatum : IDBCRecord
{
    [DBCPropertyBinding(0, DBCBindingType.INT32)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT32, Nullable = true)]
    public int? SoundExertionId { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT32, Nullable = true)]
    public int? SoundExertionCriticalId { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.INT32, Nullable = true)]
    public int? SoundInjuryId { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.INT32, Nullable = true)]
    public int? SoundInjuryCriticalId { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.INT32, Nullable = true)]
    public int? SoundInjuryCrushingBlowId { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.INT32, Nullable = true)]
    public int? SoundDeathId { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.INT32, Nullable = true)]
    public int? SoundStunId { get; set; }

    [DBCPropertyBinding(8, DBCBindingType.INT32, Nullable = true)]
    public int? SoundStandId { get; set; }

    [DBCPropertyBinding(9, DBCBindingType.INT32, Nullable = true)]
    public int? SoundFootstepId { get; set; }

    [DBCPropertyBinding(10, DBCBindingType.INT32, Nullable = true)]
    public int? SoundAggroId { get; set; }

    [DBCPropertyBinding(11, DBCBindingType.INT32, Nullable = true)]
    public int? SoundWingFlapId { get; set; }

    [DBCPropertyBinding(12, DBCBindingType.INT32, Nullable = true)]
    public int? SoundWingGlideId { get; set; }

    [DBCPropertyBinding(13, DBCBindingType.INT32, Nullable = true)]
    public int? SoundAlertId { get; set; }

    [DBCPropertyBinding(14, DBCBindingType.INT32, Nullable = true)]
    public int? SoundFidget1 { get; set; }

    [DBCPropertyBinding(15, DBCBindingType.INT32, Nullable = true)]
    public int? SoundFidget2 { get; set; }

    [DBCPropertyBinding(16, DBCBindingType.INT32, Nullable = true)]
    public int? SoundFidget3 { get; set; }

    [DBCPropertyBinding(17, DBCBindingType.INT32, Nullable = true)]
    public int? SoundFidget4 { get; set; }

    [DBCPropertyBinding(18, DBCBindingType.INT32, Nullable = true)]
    public int? SoundFidget5 { get; set; }

    [DBCPropertyBinding(19, DBCBindingType.INT32)]
    public int CustomAttack1 { get; set; }

    [DBCPropertyBinding(20, DBCBindingType.INT32)]
    public int CustomAttack2 { get; set; }

    [DBCPropertyBinding(21, DBCBindingType.INT32)]
    public int CustomAttack3 { get; set; }

    [DBCPropertyBinding(22, DBCBindingType.INT32)]
    public int CustomAttack4 { get; set; }

    [DBCPropertyBinding(23, DBCBindingType.INT32, Nullable = true)]
    public int? NpcsoundId { get; set; }

    [DBCPropertyBinding(24, DBCBindingType.INT32, Nullable = true)]
    public int? LoopSoundId { get; set; }

    [DBCPropertyBinding(25, DBCBindingType.INT32)]
    public int CreatureImpactType { get; set; }

    [DBCPropertyBinding(26, DBCBindingType.INT32, Nullable = true)]
    public int? SoundJumpStartId { get; set; }

    [DBCPropertyBinding(27, DBCBindingType.INT32, Nullable = true)]
    public int? SoundJumpEndId { get; set; }

    [DBCPropertyBinding(28, DBCBindingType.INT32, Nullable = true)]
    public int? SoundPetAttackId { get; set; }

    [DBCPropertyBinding(29, DBCBindingType.INT32, Nullable = true)]
    public int? SoundPetOrderId { get; set; }

    [DBCPropertyBinding(30, DBCBindingType.INT32, Nullable = true)]
    public int? SoundPetDismissId { get; set; }

    [DBCPropertyBinding(31, DBCBindingType.FLOAT)]
    public float FidgetDelaySecondsMin { get; set; }

    [DBCPropertyBinding(32, DBCBindingType.FLOAT)]
    public float FidgetDelaySecondsMax { get; set; }

    [DBCPropertyBinding(33, DBCBindingType.INT32, Nullable = true)]
    public int? BirthSoundId { get; set; }

    [DBCPropertyBinding(34, DBCBindingType.INT32, Nullable = true)]
    public int? SpellCastDirectedSoundId { get; set; }

    [DBCPropertyBinding(35, DBCBindingType.INT32, Nullable = true)]
    public int? SubmergeSoundId { get; set; }

    [DBCPropertyBinding(36, DBCBindingType.INT32, Nullable = true)]
    public int? SubmergedSoundId { get; set; }

    [DBCPropertyBinding(37, DBCBindingType.INT32)]
    public int CreatureSoundDataIdpet { get; set; }

    public virtual Soundentry? BirthSound { get; set; }

    public virtual ICollection<Creaturedisplayinfo> Creaturedisplayinfos { get; set; } = new List<Creaturedisplayinfo>();

    public virtual ICollection<Creaturemodeldatum> Creaturemodeldata { get; set; } = new List<Creaturemodeldatum>();

    public virtual Soundentry? LoopSound { get; set; }

    public virtual Soundentry? Npcsound { get; set; }

    public virtual Soundentry? SoundAggro { get; set; }

    public virtual Soundentry? SoundAlert { get; set; }

    public virtual Soundentry? SoundDeath { get; set; }

    public virtual Soundentry? SoundExertion { get; set; }

    public virtual Soundentry? SoundExertionCritical { get; set; }

    public virtual Soundentry? SoundFidget1Navigation { get; set; }

    public virtual Soundentry? SoundFidget2Navigation { get; set; }

    public virtual Soundentry? SoundFidget3Navigation { get; set; }

    public virtual Soundentry? SoundFidget4Navigation { get; set; }

    public virtual Soundentry? SoundFidget5Navigation { get; set; }

    public virtual Soundentry? SoundFootstep { get; set; }

    public virtual Soundentry? SoundInjury { get; set; }

    public virtual Soundentry? SoundInjuryCritical { get; set; }

    public virtual Soundentry? SoundInjuryCrushingBlow { get; set; }

    public virtual Soundentry? SoundJumpEnd { get; set; }

    public virtual Soundentry? SoundJumpStart { get; set; }

    public virtual Soundentry? SoundPetAttack { get; set; }

    public virtual Soundentry? SoundPetDismiss { get; set; }

    public virtual Soundentry? SoundPetOrder { get; set; }

    public virtual Soundentry? SoundStand { get; set; }

    public virtual Soundentry? SoundStun { get; set; }

    public virtual Soundentry? SoundWingFlap { get; set; }

    public virtual Soundentry? SoundWingGlide { get; set; }

    public virtual Soundentry? SpellCastDirectedSound { get; set; }

    public virtual Soundentry? SubmergeSound { get; set; }

    public virtual Soundentry? SubmergedSound { get; set; }
}