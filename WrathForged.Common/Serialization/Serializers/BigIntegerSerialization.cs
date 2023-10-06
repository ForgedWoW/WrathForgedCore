// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Common.Networking;
using WrathForged.Models;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers;

public class BigIntegerSerialization : IForgedTypeSerialization
{
    public HashSet<Type> SupportedTypes { get; } = new HashSet<Type>()
    {
        typeof(BigInteger)
    };

    public HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; } = new HashSet<ForgedTypeCode>();

    public object? Deserialize(PacketBuffer packetBuffer, PropertyMeta propertyMeta, Dictionary<uint, int> collectionSizes)
    {
        var size = propertyMeta.SerializationMetadata.FixedCollectionSize;

        if (propertyMeta.SerializationMetadata.Flags.HasFlag(SerializationFlags.BigIntegerWithLength) && size == 0)
            size = packetBuffer.GetCollectionSize(propertyMeta, collectionSizes);

        return packetBuffer.Reader.ReadBytes(size).ToPositiveBigInteger();
    }

    public void Serialize(PrimitiveWriter writer, PropertyMeta propertyMeta, List<PropertyMeta> otherMeta, object obj, object? val)
    {
        if (propertyMeta.SerializationMetadata.Flags.HasFlag(SerializationFlags.BigIntegerWithLength) && propertyMeta.SerializationMetadata.FixedCollectionSize == 0)
            writer.SerializeCollectionSize(propertyMeta, otherMeta, obj);

        if (val != null)
            writer.Write(((BigInteger)val).ToProperByteArray());
    }
}