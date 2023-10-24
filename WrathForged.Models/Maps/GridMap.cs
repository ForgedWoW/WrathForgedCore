// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Maps.MapFiles;

namespace WrathForged.Models.Maps;
public class GridMap
{
    public required MapFileHeader FileHeader { get; set; }
    public MapAreaData? AreaData { get; set; }
}
