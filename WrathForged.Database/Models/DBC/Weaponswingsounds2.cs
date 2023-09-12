using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Weaponswingsounds2
{
    public int Id { get; set; }

    public int SwingType { get; set; }

    public int Crit { get; set; }

    public int? SoundId { get; set; }

    public virtual Soundentry? Sound { get; set; }
}
