// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Instance.Server.Maps.Models;

public class LiquidLevelInfo()
{
    public float Level { get; set; }
    public float Floor { get; set; }
    public uint Type { get; set; }
    public uint MogpFlags { get; set; }
}
