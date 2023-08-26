using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class SpellGroupStackRule
{
    public uint GroupId { get; set; }

    public sbyte StackRule { get; set; }
}
