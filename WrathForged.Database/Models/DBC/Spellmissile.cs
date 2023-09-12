using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellmissile
{
    public int Id { get; set; }

    public int Flags { get; set; }

    public float DefaultPitchMin { get; set; }

    public float DefaultPitchMax { get; set; }

    public float DefaultSpeedMin { get; set; }

    public float DefaultSpeedMax { get; set; }

    public float RandomizeFacingMin { get; set; }

    public float RandomizeFacingMax { get; set; }

    public float RandomizePitchMin { get; set; }

    public float RandomizePitchMax { get; set; }

    public float RandomizeSpeedMin { get; set; }

    public float RandomizeSpeedMax { get; set; }

    public float Gravity { get; set; }

    public float MaxDuration { get; set; }

    public float CollisionRadius { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
