using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Attackanimtype
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Attackanimkit> Attackanimkits { get; set; } = new List<Attackanimkit>();
}
