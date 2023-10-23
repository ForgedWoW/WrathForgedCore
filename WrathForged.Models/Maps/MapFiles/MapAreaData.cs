// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.ConditionalSerializers;
using WrathForged.Models.Maps.Enum;

namespace WrathForged.Models.Maps.MapFiles;

[ForgedSerializable]
public class MapAreaData
{
    [SerializableProperty(0)]
    public uint FourCC { get; set; }

    [SerializableProperty(1)]
    public MapAreaFlags Flags { get; set; }

    [SerializableProperty(2)]
    public ushort GridArea { get; set; }

    [SerializableProperty(1, FixedCollectionSize = 16 * 16)]
    [SerializerConditionDoseNotHaveFlag(1, typeof(MapAreaFlags), (int)MapAreaFlags.NoArea)]
    public ushort[] AreaMap { get; set; } = [];
}
