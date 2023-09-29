// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

public partial class BattlegroundDeserter
{
    /// <summary>
    /// characters.guid
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// type of the desertion
    /// </summary>
    public byte Type { get; set; }

    /// <summary>
    /// datetime of the desertion
    /// </summary>
    public DateTime Datetime { get; set; }
}
