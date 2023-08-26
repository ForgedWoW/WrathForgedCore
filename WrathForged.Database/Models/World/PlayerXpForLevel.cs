using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class PlayerXpForLevel
{
    public byte Level { get; set; }

    public uint Experience { get; set; }
}
