using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class PlayerTotemModel
{
    public byte TotemSlot { get; set; }

    public byte RaceId { get; set; }

    public uint DisplayId { get; set; }
}
