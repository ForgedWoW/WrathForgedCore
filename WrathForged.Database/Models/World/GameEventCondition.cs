// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class GameEventCondition
{
    /// <summary>
    /// Entry of the game event
    /// </summary>
    public byte EventEntry { get; set; }

    public uint ConditionId { get; set; }

    public float? ReqNum { get; set; }

    public ushort MaxWorldStateField { get; set; }

    public ushort DoneWorldStateField { get; set; }

    public string Description { get; set; } = null!;
}
