// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections.Concurrent;
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Maps;

[ForgedSerializable]
public class VMapTreeData
{
    [SerializableProperty(0, OverrideType = ForgedTypeCode.CharArray, FixedCollectionSize = 8)]
    public string Magic { get; set; } = string.Empty;

    [SerializableProperty(1, OverrideType = ForgedTypeCode.CharArray, FixedCollectionSize = 4)]
    public string Node { get; set; } = string.Empty;

    [SerializableProperty(2)]
    public BoundingIntervalHierarchy BIH { get; set; } = new();

    [SerializableProperty(3, OverrideType = ForgedTypeCode.CharArray, FixedCollectionSize = 4)]
    public string SIDX { get; set; } = string.Empty;

    [SerializableProperty(4, CollectionSizeLengthType = TypeCode.UInt32, Flags = SerializationFlags.DictionaryValueIsIndex)]
    public ConcurrentDictionary<uint, uint> SpawnIndices { get; set; } = new();
}
