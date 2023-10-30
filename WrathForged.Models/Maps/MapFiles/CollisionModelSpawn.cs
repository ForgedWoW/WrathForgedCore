// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Models.ConditionalSerializers;
using WrathForged.Models.GameMath;
using WrathForged.Models.Maps.Enum;

namespace WrathForged.Models.Maps.MapFiles;

[ForgedSerializable]
public class CollisionModelSpawn
{
    [SerializableProperty(0)]
    public CollisionModelSpawnFlags Flags { get; set; }

    [SerializableProperty(1)]
    public ushort AdtId { get; set; }

    [SerializableProperty(2)]
    public uint Id { get; set; }

    [SerializableProperty(3)]
    public Vector3 Position { get; set; }

    [SerializableProperty(4)]
    public Vector3 Rotation { get; set; }

    [SerializableProperty(5)]
    public float Scale { get; set; }

    [SerializableProperty(6)]
    [SerializerConditionHasFlag<CollisionModelSpawnFlags>(0, CollisionModelSpawnFlags.HasBound)]
    public AxisAlignedBox Bounds { get; set; }

    [SerializableProperty(7)]
    public string Name { get; set; } = string.Empty;
}
