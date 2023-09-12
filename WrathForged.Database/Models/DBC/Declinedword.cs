using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Declinedword
{
    public int Id { get; set; }

    public string? Word { get; set; }

    public virtual ICollection<Declinedwordcase> Declinedwordcases { get; set; } = new List<Declinedwordcase>();
}
