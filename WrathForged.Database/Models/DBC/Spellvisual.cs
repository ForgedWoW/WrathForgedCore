using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellvisual
{
    public int Id { get; set; }

    public int? PrecastKit { get; set; }

    public int? CastKit { get; set; }

    public int? ImpactKit { get; set; }

    public int? StateKit { get; set; }

    public int? StateDoneKit { get; set; }

    public int? ChannelKit { get; set; }

    public int HasMissile { get; set; }

    public int? MissileModel { get; set; }

    public int MissilePathType { get; set; }

    public int MissileDestinationAttachment { get; set; }

    public int? MissileSound { get; set; }

    public int? AnimEventSoundId { get; set; }

    public int Flags { get; set; }

    public int? CasterImpactKit { get; set; }

    public int? TargetImpactKit { get; set; }

    public int MissileAttachment { get; set; }

    public int MissileFollowGroundHeight { get; set; }

    public int MissileFollowGroundDropSpeed { get; set; }

    public int MissileFollowGroundApproach { get; set; }

    public int MissileFollowGroundFlags { get; set; }

    public int MissileMotion { get; set; }

    public int? MissileTargetingKit { get; set; }

    public int? InstantAreaKit { get; set; }

    public int? ImpactAreaKit { get; set; }

    public int? PersistentAreaKit { get; set; }

    public float MissileCastOffsetX { get; set; }

    public float MissileCastOffsetY { get; set; }

    public float MissileCastOffsetZ { get; set; }

    public float MissileImpactOffsetX { get; set; }

    public float MissileImpactOffsetY { get; set; }

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
