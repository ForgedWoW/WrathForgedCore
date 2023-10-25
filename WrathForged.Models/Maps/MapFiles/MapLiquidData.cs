// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.ConditionalSerializers;
using WrathForged.Models.Maps.Enum;

namespace WrathForged.Models.Maps.MapFiles;

[ForgedSerializable]
public class MapLiquidData
{
    [SerializableProperty(0)]
    public uint FourCC { get; set; }

    [SerializableProperty(1)]
    public MapLiquidFlags Flags { get; set; }

    [SerializableProperty(2)]
    public byte GlobalFlags { get; set; }

    [SerializableProperty(3)]
    public ushort LiquidType { get; set; }

    [SerializableProperty(4)]
    public byte OffsetX { get; set; }

    [SerializableProperty(5)]
    public byte OffsetY { get; set; }

    [SerializableProperty(6)]
    public byte Width { get; set; }

    [SerializableProperty(7)]
    public byte Height { get; set; }

    [SerializableProperty(8)]
    public float LiquidLevel { get; set; }

    [SerializableProperty(9, FixedCollectionSize = 16 * 16)]
    [SerializerConditionDoseNotHaveFlag<MapLiquidFlags>(1, MapLiquidFlags.NoType)]
    public ushort[]? LiquidEntry { get; set; }

    [SerializableProperty(10, FixedCollectionSize = 16 * 16)]
    [SerializerConditionDoseNotHaveFlag<MapLiquidFlags>(1, MapLiquidFlags.NoType)]
    public byte[]? LiquidFlags { get; set; }

    [SerializableProperty(11)]
    [SerializerConditionHasFlag<MapLiquidFlags>(1, MapLiquidFlags.NoHeight)]
    [CalculatedCollectionSize(6, CalculatedCollectionSizeAttribute.CalculationType.Multiply, CalculatedCollectionSizeAttribute.CalculateBy.Property, 7)]
    public float[]? LiquidMap { get; set; }
}
