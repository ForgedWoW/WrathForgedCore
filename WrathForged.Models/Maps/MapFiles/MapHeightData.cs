// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Maps.Enum;

namespace WrathForged.Models.Maps.MapFiles;

[ForgedSerializable]
public class MapHeightData
{
    [SerializableProperty(0)]
    public uint FourCC { get; set; }

    [SerializableProperty(1)]
    public MapHeightFlags Flags { get; set; }

    [SerializableProperty(2)]
    public float GridMinHeight { get; set; }

    [SerializableProperty(3)]
    public float GridMaxHeight { get; set; }
}
