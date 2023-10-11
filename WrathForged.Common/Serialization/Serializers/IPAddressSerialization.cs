// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using WrathForged.Common.Networking;
using WrathForged.Models;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers;

public class IPAddressSerialization : IForgedTypeSerialization
{
    public HashSet<Type> SupportedTypes { get; } = [typeof(IPAddress)];
    public HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; } = [];

    public object? Deserialize(PacketBuffer packetBuffer, PropertyMeta propertyMeta, Dictionary<uint, int> collectionSizes)
    {
        return new IPAddress(packetBuffer.Reader.ReadBytes(4));
    }

    public void Serialize(PrimitiveWriter writer, PropertyMeta propertyMeta, List<PropertyMeta> otherMeta, object obj, object? val)
    {
        if (val != null)
        {
            writer.Write(((IPAddress)val).GetAddressBytes());
        }
    }
}