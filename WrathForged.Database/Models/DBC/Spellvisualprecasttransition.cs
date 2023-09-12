using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellvisualprecasttransition
{
    public int Id { get; set; }

    public string? LoadAnimation { get; set; }

    public string? HoldAnimation { get; set; }
}
