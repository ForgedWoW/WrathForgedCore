using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Loadingscreen
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? FileName { get; set; }

    public int HasWideScreen { get; set; }

    public virtual ICollection<Map> Maps { get; set; } = new List<Map>();
}
