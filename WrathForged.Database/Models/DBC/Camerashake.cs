// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Database.DBC;

namespace WrathForged.Database.Models.DBC;

[DBCBound("CameraShakes.dbc")]
public partial class Camerashake
{
    [DBCPropertyBinding(0, DBCBindingType.INT)]
    public int Id { get; set; }

    [DBCPropertyBinding(1, DBCBindingType.INT)]
    public int ShakeType { get; set; }

    [DBCPropertyBinding(2, DBCBindingType.INT)]
    public int Direction { get; set; }

    [DBCPropertyBinding(3, DBCBindingType.FLOAT)]
    public float Amplitude { get; set; }

    [DBCPropertyBinding(4, DBCBindingType.FLOAT)]
    public float Frequency { get; set; }

    [DBCPropertyBinding(5, DBCBindingType.FLOAT)]
    public float Duration { get; set; }

    [DBCPropertyBinding(6, DBCBindingType.FLOAT)]
    public float Phase { get; set; }

    [DBCPropertyBinding(7, DBCBindingType.FLOAT)]
    public float Coefficient { get; set; }

    public virtual ICollection<Creaturemodeldatum> CreaturemodeldatumDeathThudShakeSizeNavigations { get; set; } = new List<Creaturemodeldatum>();

    public virtual ICollection<Creaturemodeldatum> CreaturemodeldatumFootstepShakeSizeNavigations { get; set; } = new List<Creaturemodeldatum>();

    public virtual ICollection<Spelleffectcamerashake> SpelleffectcamerashakeCameraShake1Navigations { get; set; } = new List<Spelleffectcamerashake>();

    public virtual ICollection<Spelleffectcamerashake> SpelleffectcamerashakeCameraShake2Navigations { get; set; } = new List<Spelleffectcamerashake>();

    public virtual ICollection<Spelleffectcamerashake> SpelleffectcamerashakeCameraShake3Navigations { get; set; } = new List<Spelleffectcamerashake>();
}