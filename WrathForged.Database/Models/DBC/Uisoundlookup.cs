using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Uisoundlookup
{
    public int Id { get; set; }

    public int? SoundId { get; set; }

    public string? Name { get; set; }

    public virtual Soundentry? Sound { get; set; }
}
