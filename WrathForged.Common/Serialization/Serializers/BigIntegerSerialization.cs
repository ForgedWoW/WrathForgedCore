// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Common.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers
{
    public class BigIntegerSerialization : IForgedTypeSerialization
    {
        public HashSet<Type> SupportedTypes { get; } = new HashSet<Type>()
        {
            typeof(BigInteger)
        };

        public HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; } = new HashSet<ForgedTypeCode>();

        public object? Deserialize(PacketBuffer packetBuffer, PropertyMeta propertyMeta, Dictionary<uint, uint> collectionSizes) => new BigInteger(packetBuffer.Reader.ReadBytes(propertyMeta.SerializationMetadata.FixedCollectionSize));

        public void Serialize(PrimitiveWriter writer, PropertyMeta propertyMeta, List<PropertyMeta> otherMeta, object obj)
        {
            var val = propertyMeta.ReflectedProperty.GetValue(obj);

            if (val != null)
                writer.Write(((BigInteger)val).ToByteArray());
        }
    }
}