// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Models.GameMath;

namespace WrathForged.Models.Maps.MapFiles;

[ForgedSerializable]
public class GroupCollisionModel
{
    [SerializableProperty(0)]
    public AxisAlignedBox Bounds { get; set; }

    [SerializableProperty(1)]
    public uint MogpFlags { get; set; }

    [SerializableProperty(2)]
    public uint WmoID { get; set; }

    [SerializableProperty(3, FixedCollectionSize = 4, OverrideType = Serialization.Models.ForgedTypeCode.CharArray)]
    public string VerticesHeader { get; set; } = string.Empty;

    [SerializableProperty(4)]
    public uint Unk1 { get; set; }

    [SerializableProperty(5)]
    public List<Vector3> Vertices { get; set; } = [];

    [SerializableProperty(6, FixedCollectionSize = 4, OverrideType = Serialization.Models.ForgedTypeCode.CharArray)]
    public string TrianglesHeader { get; set; } = string.Empty;

    [SerializableProperty(7)]
    public uint Unk2 { get; set; }

    [SerializableProperty(8)]
    public List<MeshTriangle> Triangles { get; set; } = [];

    [SerializableProperty(9, FixedCollectionSize = 4, OverrideType = Serialization.Models.ForgedTypeCode.CharArray)]
    public string MeshTreeHeader { get; set; } = string.Empty;

    [SerializableProperty(10)]
    public BoundingIntervalHierarchy MeshTree { get; set; } = new();

    [SerializableProperty(11, FixedCollectionSize = 4, OverrideType = Serialization.Models.ForgedTypeCode.CharArray)]
    public string LiquidHeader { get; set; } = string.Empty;

    [SerializableProperty(12)]
    public WmoLiquidData Liquid { get; set; } = new();

}
