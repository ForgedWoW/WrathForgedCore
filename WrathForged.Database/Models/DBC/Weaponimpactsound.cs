using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Weaponimpactsound
{
    public int Id { get; set; }

    public int WeaponSubClassId { get; set; }

    public int ParrySoundType { get; set; }

    public int? ImpactSoundId1 { get; set; }

    public int? ImpactSoundId2 { get; set; }

    public int? ImpactSoundId3 { get; set; }

    public int? ImpactSoundId4 { get; set; }

    public int? ImpactSoundId5 { get; set; }

    public int? ImpactSoundId6 { get; set; }

    public int? ImpactSoundId7 { get; set; }

    public int? ImpactSoundId8 { get; set; }

    public int? ImpactSoundId9 { get; set; }

    public int? ImpactSoundId10 { get; set; }

    public int? CritImpactSoundId1 { get; set; }

    public int? CritImpactSoundId2 { get; set; }

    public int? CritImpactSoundId3 { get; set; }

    public int? CritImpactSoundId4 { get; set; }

    public int? CritImpactSoundId5 { get; set; }

    public int? CritImpactSoundId6 { get; set; }

    public int? CritImpactSoundId7 { get; set; }

    public int? CritImpactSoundId8 { get; set; }

    public int? CritImpactSoundId9 { get; set; }

    public int? CritImpactSoundId10 { get; set; }

    public virtual Soundentry? CritImpactSoundId10Navigation { get; set; }

    public virtual Soundentry? CritImpactSoundId1Navigation { get; set; }

    public virtual Soundentry? CritImpactSoundId2Navigation { get; set; }

    public virtual Soundentry? CritImpactSoundId3Navigation { get; set; }

    public virtual Soundentry? CritImpactSoundId4Navigation { get; set; }

    public virtual Soundentry? CritImpactSoundId5Navigation { get; set; }

    public virtual Soundentry? CritImpactSoundId6Navigation { get; set; }

    public virtual Soundentry? CritImpactSoundId7Navigation { get; set; }

    public virtual Soundentry? CritImpactSoundId8Navigation { get; set; }

    public virtual Soundentry? CritImpactSoundId9Navigation { get; set; }

    public virtual Soundentry? ImpactSoundId10Navigation { get; set; }

    public virtual Soundentry? ImpactSoundId1Navigation { get; set; }

    public virtual Soundentry? ImpactSoundId2Navigation { get; set; }

    public virtual Soundentry? ImpactSoundId3Navigation { get; set; }

    public virtual Soundentry? ImpactSoundId4Navigation { get; set; }

    public virtual Soundentry? ImpactSoundId5Navigation { get; set; }

    public virtual Soundentry? ImpactSoundId6Navigation { get; set; }

    public virtual Soundentry? ImpactSoundId7Navigation { get; set; }

    public virtual Soundentry? ImpactSoundId8Navigation { get; set; }

    public virtual Soundentry? ImpactSoundId9Navigation { get; set; }
}
