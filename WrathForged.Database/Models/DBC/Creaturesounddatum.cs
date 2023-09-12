using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Creaturesounddatum
{
    public int Id { get; set; }

    public int? SoundExertionId { get; set; }

    public int? SoundExertionCriticalId { get; set; }

    public int? SoundInjuryId { get; set; }

    public int? SoundInjuryCriticalId { get; set; }

    public int? SoundInjuryCrushingBlowId { get; set; }

    public int? SoundDeathId { get; set; }

    public int? SoundStunId { get; set; }

    public int? SoundStandId { get; set; }

    public int? SoundFootstepId { get; set; }

    public int? SoundAggroId { get; set; }

    public int? SoundWingFlapId { get; set; }

    public int? SoundWingGlideId { get; set; }

    public int? SoundAlertId { get; set; }

    public int? SoundFidget1 { get; set; }

    public int? SoundFidget2 { get; set; }

    public int? SoundFidget3 { get; set; }

    public int? SoundFidget4 { get; set; }

    public int? SoundFidget5 { get; set; }

    public int CustomAttack1 { get; set; }

    public int CustomAttack2 { get; set; }

    public int CustomAttack3 { get; set; }

    public int CustomAttack4 { get; set; }

    public int? NpcsoundId { get; set; }

    public int? LoopSoundId { get; set; }

    public int CreatureImpactType { get; set; }

    public int? SoundJumpStartId { get; set; }

    public int? SoundJumpEndId { get; set; }

    public int? SoundPetAttackId { get; set; }

    public int? SoundPetOrderId { get; set; }

    public int? SoundPetDismissId { get; set; }

    public float FidgetDelaySecondsMin { get; set; }

    public float FidgetDelaySecondsMax { get; set; }

    public int? BirthSoundId { get; set; }

    public int? SpellCastDirectedSoundId { get; set; }

    public int? SubmergeSoundId { get; set; }

    public int? SubmergedSoundId { get; set; }

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
