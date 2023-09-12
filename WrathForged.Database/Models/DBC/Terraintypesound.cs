using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Terraintypesound
{
    public int Id { get; set; }

    public virtual ICollection<Terraintype> Terraintypes { get; set; } = new List<Terraintype>();
}
