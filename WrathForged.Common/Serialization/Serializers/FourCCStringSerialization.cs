// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Networking;
using WrathForged.Models;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers;

public class FourCCStringSerialization : IForgedTypeSerialization
{
    public HashSet<Type> SupportedTypes { get; } = [];
    public HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; } = [ForgedTypeCode.FourCCString];

    public object? Deserialize(PacketBuffer packetBuffer, PropertyMeta propertyMeta, Dictionary<uint, int> collectionSizes)
    {
        var text = packetBuffer.Reader.ReadFourCC().TrimEnd('\0');

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
        writer.SerializeCollectionSize(propertyMeta, otherMeta, obj, 4);

        if (propertyMeta.SerializationMetadata.Flags.HasFlag(SerializationFlags.ReversedString))
        {
            var charArray = text.ToCharArray();
            Array.Reverse(charArray);
            text = new string(charArray);
        }

        writer.WriteCString(text);
    }
}