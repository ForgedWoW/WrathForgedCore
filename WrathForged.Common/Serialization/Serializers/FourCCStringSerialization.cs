﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Networking;
using WrathForged.Models;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers;

public class FourCCStringSerialization : IForgedTypeSerialization
{
    public HashSet<Type> SupportedTypes { get; } = new HashSet<Type>();
    public HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; } = new HashSet<ForgedTypeCode>() { ForgedTypeCode.FourCCString };

    public object? Deserialize(PacketBuffer packetBuffer, PropertyMeta propertyMeta, Dictionary<uint, int> collectionSizes)
    {
        _ = packetBuffer.GetCollectionSize(propertyMeta, collectionSizes);
        var text = packetBuffer.Reader.ReadFourCC();

        if (propertyMeta.SerializationMetadata.Flags.HasFlag(SerializationFlags.ReversedString))
        {
            var charArray = text.ToCharArray();
            Array.Reverse(charArray);
            text = new string(charArray);
        }

        return text;
    }

    public void Serialize(PrimitiveWriter writer, PropertyMeta propertyMeta, List<PropertyMeta> otherMeta, object obj, object? val)
    {
        var text = val as string ?? string.Empty;
        writer.SerializeCollectionSize(propertyMeta, otherMeta, obj);

        if (propertyMeta.SerializationMetadata.Flags.HasFlag(SerializationFlags.ReversedString))
        {
            var charArray = text.ToCharArray();
            Array.Reverse(charArray);
            text = new string(charArray);
        }

        writer.WriteCString(text);
    }
}