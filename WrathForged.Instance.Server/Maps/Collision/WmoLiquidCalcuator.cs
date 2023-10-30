// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Models.Maps.MapFiles;

namespace WrathForged.Instance.Server.Maps.Collision;
public class WmoLiquidCalculator
{
    private const float LIQUID_TILE_SIZE = 533.333f / 128.0f;

    public WmoLiquidData WmoLiquidData { get; set; } = new WmoLiquidData();

    public WmoLiquidCalculator() { }
    public WmoLiquidCalculator(WmoLiquidData wmoLiquidData) => WmoLiquidData = wmoLiquidData;

    public WmoLiquidCalculator(uint width, uint height, Vector3 corner, uint type)
    {
        WmoLiquidData.TilesX = width;
        WmoLiquidData.TilesY = height;
        WmoLiquidData.Corner = corner;
        WmoLiquidData.Type = type;

        if (width != 0 && height != 0)
        {
            WmoLiquidData.Heights = new float[(width + 1) * (height + 1)];
            WmoLiquidData.Flags = new byte[width * height];
        }
    }

    public WmoLiquidCalculator(WmoLiquidCalculator other)
    {
        if (this == other)
            return;

        WmoLiquidData.TilesX = other.WmoLiquidData.TilesX;
        WmoLiquidData.TilesY = other.WmoLiquidData.TilesY;
        WmoLiquidData.Corner = other.WmoLiquidData.Corner;
        WmoLiquidData.Type = other.WmoLiquidData.Type;

        if (other.WmoLiquidData.Heights != null)
        {
            WmoLiquidData.Heights = new float[(WmoLiquidData.TilesX + 1) * (WmoLiquidData.TilesY + 1)];
            Buffer.BlockCopy(other.WmoLiquidData.Heights, 0, WmoLiquidData.Heights, 0, (int)((WmoLiquidData.TilesX + 1) * (WmoLiquidData.TilesY + 1)));
        }

        if (other.WmoLiquidData.Flags != null)
        {
            WmoLiquidData.Flags = new byte[WmoLiquidData.TilesX * WmoLiquidData.TilesY];
            Buffer.BlockCopy(other.WmoLiquidData.Flags, 0, WmoLiquidData.Flags, 0, (int)(WmoLiquidData.TilesX * WmoLiquidData.TilesY));
        }
    }

    public bool GetLiquidHeight(Vector3 pos, out float liqHeight)
    {
        // simple case
        if (WmoLiquidData.Flags == null)
        {
            liqHeight = WmoLiquidData.Heights[0];

            return true;
        }

        liqHeight = 0f;
        var txF = (pos.X - WmoLiquidData.Corner.X) / LIQUID_TILE_SIZE;
        var tx = (uint)txF;

        if (txF < 0.0f || tx >= WmoLiquidData.TilesX)
            return false;

        var tyF = (pos.Y - WmoLiquidData.Corner.Y) / LIQUID_TILE_SIZE;
        var ty = (uint)tyF;

        if (tyF < 0.0f || ty >= WmoLiquidData.TilesY)
            return false;

        // check if tile shall be used for liquid level
        // checking for 0x08 *might* be enough, but disabled tiles always are 0x?F:
        if ((WmoLiquidData.Flags[tx + (ty * WmoLiquidData.TilesX)] & 0x0F) == 0x0F)
            return false;

        // (dx, dy) coordinates inside tile, in [0, 1]^2
        var dx = txF - tx;
        var dy = tyF - ty;

        var rowOffset = WmoLiquidData.TilesX + 1;

        if (dx > dy) // case (a)
        {
            var sx = WmoLiquidData.Heights[tx + 1 + (ty * rowOffset)] - WmoLiquidData.Heights[tx + (ty * rowOffset)];
            var sy = WmoLiquidData.Heights[tx + 1 + ((ty + 1) * rowOffset)] - WmoLiquidData.Heights[tx + 1 + (ty * rowOffset)];
            liqHeight = WmoLiquidData.Heights[tx + (ty * rowOffset)] + (dx * sx) + (dy * sy);
        }
        else // case (b)
        {
            var sx = WmoLiquidData.Heights[tx + 1 + ((ty + 1) * rowOffset)] - WmoLiquidData.Heights[tx + ((ty + 1) * rowOffset)];
            var sy = WmoLiquidData.Heights[tx + ((ty + 1) * rowOffset)] - WmoLiquidData.Heights[tx + (ty * rowOffset)];
            liqHeight = WmoLiquidData.Heights[tx + (ty * rowOffset)] + (dx * sx) + (dy * sy);
        }

        return true;
    }

    public uint GetLiquidType() => WmoLiquidData.Type;
}
