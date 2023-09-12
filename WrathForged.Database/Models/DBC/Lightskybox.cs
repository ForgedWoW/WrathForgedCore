using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Lightskybox
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Flags { get; set; }

    public virtual ICollection<Lightparam> Lightparams { get; set; } = new List<Lightparam>();
}
