// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Maps.MapFiles;

[ForgedSerializable]
public class WorldCollisionModel
{
    [SerializableProperty(0, FixedCollectionSize = 8, OverrideType = Serialization.Models.ForgedTypeCode.CharArray)]
    public string Magic { get; set; } = string.Empty;

    [SerializableProperty(3, FixedCollectionSize = 4, OverrideType = Serialization.Models.ForgedTypeCode.CharArray)]
    public string WModHeader { get; set; } = string.Empty;

    [SerializableProperty(1)]
    public uint ChunkSize { get; set; }

    [SerializableProperty(2)]
    public uint RootWmoid { get; set; }

    [SerializableProperty(3, FixedCollectionSize = 4, OverrideType = Serialization.Models.ForgedTypeCode.CharArray)]
    public string GroupModelsHeader { get; set; } = string.Empty;

    [SerializableProperty(4, CollectionSizeLengthType = TypeCode.UInt32)]
    public List<GroupCollisionModel> GroupModels { get; set; } = [];

    [SerializableProperty(5, FixedCollectionSize = 4, OverrideType = Serialization.Models.ForgedTypeCode.CharArray)]
    public string BIHHeader { get; set; } = string.Empty;

    [SerializableProperty(6)]
    public BoundingIntervalHierarchy GroupTree { get; set; } = new();
}
