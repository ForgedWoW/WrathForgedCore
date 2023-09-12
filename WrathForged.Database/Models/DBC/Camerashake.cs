using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Camerashake
{
    public int Id { get; set; }

    public int ShakeType { get; set; }

    public int Direction { get; set; }

    public float Amplitude { get; set; }

    public float Frequency { get; set; }

    public float Duration { get; set; }

    public float Phase { get; set; }

    public float Coefficient { get; set; }

    public virtual ICollection<Creaturemodeldatum> CreaturemodeldatumDeathThudShakeSizeNavigations { get; set; } = new List<Creaturemodeldatum>();

    public virtual ICollection<Creaturemodeldatum> CreaturemodeldatumFootstepShakeSizeNavigations { get; set; } = new List<Creaturemodeldatum>();

    public virtual ICollection<Spelleffectcamerashake> SpelleffectcamerashakeCameraShake1Navigations { get; set; } = new List<Spelleffectcamerashake>();

    public virtual ICollection<Spelleffectcamerashake> SpelleffectcamerashakeCameraShake2Navigations { get; set; } = new List<Spelleffectcamerashake>();

    public virtual ICollection<Spelleffectcamerashake> SpelleffectcamerashakeCameraShake3Navigations { get; set; } = new List<Spelleffectcamerashake>();
}
