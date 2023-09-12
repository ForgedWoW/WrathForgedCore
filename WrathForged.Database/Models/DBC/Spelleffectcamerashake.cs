using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spelleffectcamerashake
{
    public int Id { get; set; }

    public int? CameraShake1 { get; set; }

    public int? CameraShake2 { get; set; }

    public int? CameraShake3 { get; set; }

    public virtual Camerashake? CameraShake1Navigation { get; set; }

    public virtual Camerashake? CameraShake2Navigation { get; set; }

    public virtual Camerashake? CameraShake3Navigation { get; set; }

    public virtual ICollection<Spellvisualkit> Spellvisualkits { get; set; } = new List<Spellvisualkit>();
}
