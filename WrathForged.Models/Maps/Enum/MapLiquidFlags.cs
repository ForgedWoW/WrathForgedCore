// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Maps.Enum;

[Flags]
public enum MapLiquidFlags : byte
{
    None,
    NoType = 0x0001,
    NoHeight = 0x0002
}
