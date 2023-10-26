// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using DotRecast.Core.Numerics;
using WrathForged.Common.Networking;
using WrathForged.Models;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers;

public class RcVec3fSerialization : IForgedTypeSerialization
{
    public HashSet<Type> SupportedTypes { get; } = [typeof(RcVec3f)];
    public HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; } = [];

    public object? Deserialize(PacketBuffer packetBuffer, PropertyMeta propertyMeta, Dictionary<uint, int> collectionSizes) => packetBuffer.Reader.ReadRcVec3f();

    public void Serialize(PrimitiveWriter writer, PropertyMeta propertyMeta, List<PropertyMeta> otherMeta, object obj, object? val)
    {
        if (val != null)
            writer.Write((RcVec3f)val);
    }
}