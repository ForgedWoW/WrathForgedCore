using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class InstanceEncounter
{
    /// <summary>
    /// Unique entry from DungeonEncounter.dbc
    /// </summary>
    public uint Entry { get; set; }

    public byte CreditType { get; set; }

    public uint CreditEntry { get; set; }

    /// <summary>
    /// If not 0, LfgDungeon.dbc entry for the instance it is last encounter in
    /// </summary>
    public ushort LastEncounterDungeon { get; set; }

    public string Comment { get; set; } = null!;
}
