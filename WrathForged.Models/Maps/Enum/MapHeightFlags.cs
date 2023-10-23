// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Maps.Enum;
public enum MapHeightFlags : uint
{
    None,
    NoHeight = 0x0001,
    AsShort = 0x0002,
    AsByte = 0x0004,
    HasFlightBounds = 0x0008,
}
