// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using WrathForged.Common.Networking;
using WrathForged.Models;
using WrathForged.Models.GameMath;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers;

public class AxisAlignedBoxSerialization : IForgedTypeSerialization
{
    public HashSet<Type> SupportedTypes { get; } = [typeof(AxisAlignedBox)];
    public HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; } = [];

    public object? Deserialize(PacketBuffer packetBuffer, PropertyMeta propertyMeta, Dictionary<uint, int> collectionSizes) => packetBuffer.Reader.ReadAxisAlignedBox();

    public void Serialize(PrimitiveWriter writer, PropertyMeta propertyMeta, List<PropertyMeta> otherMeta, object obj, object? val)
    {
        if (val != null)
            writer.Write((AxisAlignedBox)val);
    }
}