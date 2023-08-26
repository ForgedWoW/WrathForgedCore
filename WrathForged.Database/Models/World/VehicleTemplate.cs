using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class VehicleTemplate
{
    public uint CreatureId { get; set; }

    public int DespawnDelayMs { get; set; }
}
