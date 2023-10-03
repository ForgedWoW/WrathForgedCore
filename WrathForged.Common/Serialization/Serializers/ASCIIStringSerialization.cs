// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Text;
using WrathForged.Common.Networking;
using WrathForged.Models;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers;

public class ASCIIStringSerialization : IForgedTypeSerialization
{
    public HashSet<Type> SupportedTypes { get; } = new HashSet<Type>();

    public HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; } = new HashSet<ForgedTypeCode>()
    {
        ForgedTypeCode.ASCIIString
    };

    public object? Deserialize(PacketBuffer packetBuffer, PropertyMeta propertyMeta, Dictionary<uint, int> collectionSizes)
    {
        var length = packetBuffer.GetCollectionSize(propertyMeta, collectionSizes);
        var text = Encoding.ASCII.GetString(packetBuffer.Reader.ReadBytes(length)).TrimEnd('\0');

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

        var bytes = Encoding.ASCII.GetBytes(text);
        writer.Write(bytes);
    }
}