﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Text;
using WrathForged.Common.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers
{
    public class ASCIIStringSerialization : IForgedTypeSerialization
    {
        public HashSet<Type> SupportedTypes { get; } = new HashSet<Type>();

        public HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; } = new HashSet<ForgedTypeCode>()
        {
            ForgedTypeCode.ASCIIString
        };

        public object? Deserialize(PacketBuffer packetBuffer, PropertyMeta propertyMeta, Dictionary<uint, uint> collectionSizes)
        {
            var length = packetBuffer.GetCollectionSize(propertyMeta, collectionSizes);
            var text = Encoding.ASCII.GetString(packetBuffer.Reader.ReadBytes((int)length)).TrimEnd('\0');

            if (propertyMeta.SerializationMetadata.ReversedString)
            {
                var charArray = text.ToCharArray();
                Array.Reverse(charArray);
                text = new string(charArray);
            }

            return text;
        }

        public void Serialize(PrimitiveWriter writer, PropertyMeta propertyMeta, List<PropertyMeta> otherMeta, object obj)
        {
            var text = propertyMeta.ReflectedProperty.GetValue(obj) as string ?? string.Empty;
            writer.SerializeCollectionSize(propertyMeta, otherMeta, obj);

            if (propertyMeta.SerializationMetadata.ReversedString)
            {
                var charArray = text.ToCharArray();
                Array.Reverse(charArray);
                text = new string(charArray);
            }

            var bytes = Encoding.ASCII.GetBytes(text);
            writer.Write(bytes);
        }
    }
}