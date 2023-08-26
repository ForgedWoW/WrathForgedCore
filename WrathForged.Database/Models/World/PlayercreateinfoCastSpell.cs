using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class PlayercreateinfoCastSpell
{
    public uint RaceMask { get; set; }

    public uint ClassMask { get; set; }

    public uint Spell { get; set; }

    public string? Note { get; set; }
}
