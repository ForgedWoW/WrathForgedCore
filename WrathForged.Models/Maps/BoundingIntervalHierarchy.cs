// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.GameMath;

namespace WrathForged.Models.Maps;

[ForgedSerializable]
public class BoundingIntervalHierarchy
{
    [SerializableProperty(0)]
    public AxisAlignedBox Bounds { get; set; }

    [SerializableProperty(1, CollectionSizeLengthType = TypeCode.UInt32, OverrideType = Serialization.Models.ForgedTypeCode.UInt32)]
    public int[] Objects { get; set; } = [];

    [SerializableProperty(2, CollectionSizeLengthType = TypeCode.UInt32)]
    public uint[] Tree { get; set; } = [3u << 30, 0, 0];
}
