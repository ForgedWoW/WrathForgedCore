// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Networking;
using WrathForged.Serialization;

namespace WrathForged.Common.Serialization.Serializers
{
    public interface IForgedTypeSerialization
    {
        HashSet<Type> SupportedTypes { get; }

        HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; }

        object? Deserialize(PacketBuffer packetBuffer, SerializablePropertyAttribute serializableProperty);
    }
}