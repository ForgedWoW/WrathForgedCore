// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Models.ConditionalSerializers;

namespace WrathForged.Models.Maps.MapFiles;

[ForgedSerializable]
public class WmoLiquidData
{
    [SerializableProperty(0)]
    public uint TilesX { get; set; }

    [SerializableProperty(1)]
    public uint TilesY { get; set; }

    [SerializableProperty(2)]
    public Vector3 Corner { get; set; }

    [SerializableProperty(3)]
    public uint Type { get; set; }

    [SerializableProperty(4)]
    [SerializerConditionValue(0, SerializerConditionValue.ConditionalSerializationType.NotEqual, 0)]
    [SerializerConditionValue(1, SerializerConditionValue.ConditionalSerializationType.NotEqual, 0)]
    [CalculatedCollectionSize(0, CalculatedCollectionSizeAttribute.CalculationType.Multiply, CalculatedCollectionSizeAttribute.CalculateBy.Property, 1, true)]
    public float[] Heights { get; set; } = [];

    [SerializableProperty(5)]
    [SerializerConditionValue(0, SerializerConditionValue.ConditionalSerializationType.NotEqual, 0)]
    [SerializerConditionValue(1, SerializerConditionValue.ConditionalSerializationType.NotEqual, 0)]
    [CalculatedCollectionSize(0, CalculatedCollectionSizeAttribute.CalculationType.Multiply, CalculatedCollectionSizeAttribute.CalculateBy.Property, 1)]
    public byte[] Flags { get; set; } = [];

    [SerializableProperty(6)]
    [SerializerConditionValue(0, SerializerConditionValue.ConditionalSerializationType.Equal, 0)]
    [SerializerConditionValue(1, SerializerConditionValue.ConditionalSerializationType.Equal, 0)]
    public float Height { get; set; }
}
