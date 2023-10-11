// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Networking;
using WrathForged.Models;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers;

public class EnumSerialization : IForgedTypeSerialization
{
    public HashSet<Type> SupportedTypes { get; } = [];

    public HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; } =
    [
        ForgedTypeCode.Enum
    ];

    public object? Deserialize(PacketBuffer packetBuffer, PropertyMeta propertyMeta, Dictionary<uint, int> collectionSizes)
    {
        var underlyingType = propertyMeta.ReflectedProperty.PropertyType.GetEnumUnderlyingType();
        var typeToUse = propertyMeta.SerializationMetadata.OverrideType;

        if (typeToUse == ForgedTypeCode.Empty)
        {
            typeToUse = underlyingType.GetForgedTypeCode();

            if (typeToUse == ForgedTypeCode.Empty)
                typeToUse = ForgedTypeCode.Int32;
        }

        object value = typeToUse switch
        {
            ForgedTypeCode.Byte => packetBuffer.Reader.ReadByte(),
            ForgedTypeCode.SByte => packetBuffer.Reader.ReadSByte(),
            ForgedTypeCode.Int16 => packetBuffer.Reader.ReadInt16(),
            ForgedTypeCode.UInt16 => packetBuffer.Reader.ReadUInt16(),
            ForgedTypeCode.Int32 => packetBuffer.Reader.ReadInt32(),
            ForgedTypeCode.UInt32 => packetBuffer.Reader.ReadUInt32(),
            ForgedTypeCode.Int64 => packetBuffer.Reader.ReadInt64(),
            ForgedTypeCode.UInt64 => packetBuffer.Reader.ReadUInt64(),
            _ => packetBuffer.Reader.ReadInt32(),
        };

        if (propertyMeta.ReflectedProperty.PropertyType.IsEnum)
        {
            return Enum.ToObject(propertyMeta.ReflectedProperty.PropertyType, value);
        }
        else
        {
            return Convert.ChangeType(value, propertyMeta.ReflectedProperty.PropertyType);
        }
    }

    public void Serialize(PrimitiveWriter writer, PropertyMeta propertyMeta, List<PropertyMeta> otherMeta, object obj, object? val)
    {
        var underlyingType = propertyMeta.ReflectedProperty.PropertyType.GetEnumUnderlyingType();
        var typeToUse = propertyMeta.SerializationMetadata.OverrideType;

        if (typeToUse == ForgedTypeCode.Empty)
        {
            typeToUse = underlyingType.GetForgedTypeCode();

            if (typeToUse == ForgedTypeCode.Empty)
                typeToUse = ForgedTypeCode.Int32;
        }

        val ??= Activator.CreateInstance(propertyMeta.ReflectedProperty.PropertyType);

        if (val == null)
            return;

        switch (typeToUse)
        {
            case ForgedTypeCode.Byte:
                writer.Write((byte)val);
                break;

            case ForgedTypeCode.SByte:
                writer.Write((sbyte)val);
                break;

            case ForgedTypeCode.Int16:
                writer.Write((short)val);
                break;

            case ForgedTypeCode.UInt16:
                writer.Write((ushort)val);
                break;

            case ForgedTypeCode.Int32:
                writer.Write((int)val);
                break;

            case ForgedTypeCode.UInt32:
                writer.Write((uint)val);
                break;

            case ForgedTypeCode.Int64:
                writer.Write((long)val);
                break;

            case ForgedTypeCode.UInt64:
                writer.Write((ulong)val);
                break;

            default:
                writer.Write((int)val);
                break;
        }
    }
}