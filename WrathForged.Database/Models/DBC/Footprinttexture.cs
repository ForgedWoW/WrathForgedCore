using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Footprinttexture
{
    public int Id { get; set; }

    public string? FootstepFilename { get; set; }

    public virtual ICollection<Creaturemodeldatum> Creaturemodeldata { get; set; } = new List<Creaturemodeldatum>();
}
