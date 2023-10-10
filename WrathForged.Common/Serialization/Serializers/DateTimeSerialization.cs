// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Networking;
using WrathForged.Models;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers;

public class DateTimeSerialization : IForgedTypeSerialization
{
    public HashSet<Type> SupportedTypes { get; } = new HashSet<Type>() { typeof(DateTime) };
    public HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; } = new HashSet<ForgedTypeCode>();

    public object? Deserialize(PacketBuffer packetBuffer, PropertyMeta propertyMeta, Dictionary<uint, int> collectionSizes)
    {
        return packetBuffer.Reader.ReadUInt32().GetGameTimeToDateTime();
    }

    public void Serialize(PrimitiveWriter writer, PropertyMeta propertyMeta, List<PropertyMeta> otherMeta, object obj, object? val)
    {
        if (val != null)
            writer.WriteDateTime((DateTime)val);
    }
}