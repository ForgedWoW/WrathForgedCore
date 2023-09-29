// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class CreatureTemplateMovement
{
    public uint CreatureId { get; set; }

    public byte? Ground { get; set; }

    public byte? Swim { get; set; }

    public byte? Flight { get; set; }

    public byte? Rooted { get; set; }

    public byte? Chase { get; set; }

    public byte? Random { get; set; }

    /// <summary>
    /// Time (in milliseconds) during which creature will not move after interaction with player
    /// </summary>
    public uint? InteractionPauseTimer { get; set; }
}
