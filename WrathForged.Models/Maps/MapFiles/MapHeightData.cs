// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.ConditionalSerializers;
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

    [SerializableProperty(4, FixedCollectionSize = 129 * 129)]
    [SerializerConditionDoseNotHaveFlag<MapHeightFlags>(1, MapHeightFlags.NoHeight)]
    [SerializerConditionHasFlag<MapHeightFlags>(1, MapHeightFlags.AsShort)]
    public ushort[]? UshortV9 { get; set; }

    [SerializableProperty(5, FixedCollectionSize = 129 * 129)]
    [SerializerConditionDoseNotHaveFlag<MapHeightFlags>(1, MapHeightFlags.NoHeight)]
    [SerializerConditionHasFlag<MapHeightFlags>(1, MapHeightFlags.AsShort)]
    public ushort[]? UshortV8 { get; set; }

    [SerializableProperty(6, FixedCollectionSize = 129 * 129)]
    [SerializerConditionDoseNotHaveFlag<MapHeightFlags>(1, MapHeightFlags.NoHeight)]
    [SerializerConditionHasFlag<MapHeightFlags>(1, MapHeightFlags.AsByte)]
    public byte[]? ByteV9 { get; set; }

    [SerializableProperty(7, FixedCollectionSize = 129 * 129)]
    [SerializerConditionDoseNotHaveFlag<MapHeightFlags>(1, MapHeightFlags.NoHeight)]
    [SerializerConditionHasFlag<MapHeightFlags>(1, MapHeightFlags.AsByte)]
    public byte[]? ByteV8 { get; set; }

    [SerializableProperty(8, FixedCollectionSize = 129 * 129)]
    [SerializerConditionDoseNotHaveFlag<MapHeightFlags>(1, MapHeightFlags.NoHeight)]
    [SerializerConditionHasFlag<MapHeightFlags>(1, MapHeightFlags.AsShort)]
    [SerializerConditionHasFlag<MapHeightFlags>(1, MapHeightFlags.AsByte)]
    public float[]? FloatV9 { get; set; }

    [SerializableProperty(9, FixedCollectionSize = 129 * 129)]
    [SerializerConditionHasFlag<MapHeightFlags>(1, MapHeightFlags.NoHeight)]
    [SerializerConditionHasFlag<MapHeightFlags>(1, MapHeightFlags.AsShort)]
    [SerializerConditionHasFlag<MapHeightFlags>(1, MapHeightFlags.AsByte)]
    public float[]? FloatV8 { get; set; }

    [SerializableProperty(10)]
    [SerializerConditionHasFlag<MapHeightFlags>(1, MapHeightFlags.HasFlightBounds)]
    public ushort[]? MaxHeights { get; set; }

    [SerializableProperty(10)]
    [SerializerConditionHasFlag<MapHeightFlags>(1, MapHeightFlags.HasFlightBounds)]
    public ushort[]? MinHeights { get; set; }

    public float GridInitialHeightMultiplier { get; set; }
}
