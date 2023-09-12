using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Summonproperty
{
    public int Id { get; set; }

    public int Control { get; set; }

    public int Faction { get; set; }

    public int Title { get; set; }

    public int Slot { get; set; }

    public int Flags { get; set; }
}
