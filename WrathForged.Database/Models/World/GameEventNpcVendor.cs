// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class GameEventNpcVendor
{
    /// <summary>
    /// Entry of the game event.
    /// </summary>
    public sbyte EventEntry { get; set; }

    public uint Guid { get; set; }

    public short Slot { get; set; }

    public uint Item { get; set; }

    public uint Maxcount { get; set; }

    public uint Incrtime { get; set; }

    public uint ExtendedCost { get; set; }
}
