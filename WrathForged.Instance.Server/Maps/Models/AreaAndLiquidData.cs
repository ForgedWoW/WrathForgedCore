// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Instance.Server.Maps.Collision.Models;

namespace WrathForged.Instance.Server.Maps.Models;
public class AreaAndLiquidData
{
    public float FloorZ { get; set; } = MapConst.VMAP_INVALID_HEIGHT_VALUE;
    public AreaInfo? AreaInfo { get; set; }
    public LiquidInfoModel? LiquidInfo { get; set; }

    public struct LiquidInfoModel(uint type, float level)
    {
        public float Level { get; set; } = level;
        public uint LiquidType { get; set; } = type;
    }
}
