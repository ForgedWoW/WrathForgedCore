using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Stationery
{
    public int Id { get; set; }

    public int? ItemId { get; set; }

    public string? Texture { get; set; }

    public int Flags { get; set; }

    public virtual Item? Item { get; set; }
}
