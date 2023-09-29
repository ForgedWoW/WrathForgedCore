// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class BattlemasterEntry
{
    /// <summary>
    /// Entry of a creature
    /// </summary>
    public uint Entry { get; set; }

    /// <summary>
    /// Battleground template id
    /// </summary>
    public uint BgTemplate { get; set; }
}
