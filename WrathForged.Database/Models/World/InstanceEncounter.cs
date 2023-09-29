// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

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
