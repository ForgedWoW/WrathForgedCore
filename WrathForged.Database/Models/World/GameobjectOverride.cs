using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class GameobjectOverride
{
    public uint SpawnId { get; set; }

    public ushort Faction { get; set; }

    public uint Flags { get; set; }
}
