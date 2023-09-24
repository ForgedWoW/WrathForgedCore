// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers
{
    public class EnumSerialization : IForgedTypeSerialization
    {
        public HashSet<Type> SupportedTypes { get; } = new HashSet<Type>()
        {
        };

        public HashSet<ForgedTypeCode> SupportedForgedTypeCodes { get; } = new HashSet<ForgedTypeCode>()
        {
            ForgedTypeCode.Enum
        };

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

            return typeToUse switch
            {
                ForgedTypeCode.Byte => Convert.ChangeType(packetBuffer.Reader.ReadByte(), propertyMeta.ReflectedProperty.PropertyType),
                ForgedTypeCode.SByte => Convert.ChangeType(packetBuffer.Reader.ReadSByte(), propertyMeta.ReflectedProperty.PropertyType),
                ForgedTypeCode.Int16 => Convert.ChangeType(packetBuffer.Reader.ReadInt16(), propertyMeta.ReflectedProperty.PropertyType),
                ForgedTypeCode.UInt16 => Convert.ChangeType(packetBuffer.Reader.ReadUInt16(), propertyMeta.ReflectedProperty.PropertyType),
                ForgedTypeCode.Int32 => Convert.ChangeType(packetBuffer.Reader.ReadInt32(), propertyMeta.ReflectedProperty.PropertyType),
                ForgedTypeCode.UInt32 => Convert.ChangeType(packetBuffer.Reader.ReadUInt32(), propertyMeta.ReflectedProperty.PropertyType),
                ForgedTypeCode.Int64 => Convert.ChangeType(packetBuffer.Reader.ReadInt64(), propertyMeta.ReflectedProperty.PropertyType),
                ForgedTypeCode.UInt64 => Convert.ChangeType(packetBuffer.Reader.ReadUInt64(), propertyMeta.ReflectedProperty.PropertyType),
                _ => Convert.ChangeType(packetBuffer.Reader.ReadInt32(), propertyMeta.ReflectedProperty.PropertyType),
            };
        }

        public void Serialize(PrimitiveWriter writer, PropertyMeta propertyMeta, List<PropertyMeta> otherMeta, object obj)
        {
            var underlyingType = propertyMeta.ReflectedProperty.PropertyType.GetEnumUnderlyingType();
            var typeToUse = propertyMeta.SerializationMetadata.OverrideType;

            if (typeToUse == ForgedTypeCode.Empty)
            {
                typeToUse = underlyingType.GetForgedTypeCode();

                if (typeToUse == ForgedTypeCode.Empty)
                    typeToUse = ForgedTypeCode.Int32;
            }

            switch (typeToUse)
            {
                case ForgedTypeCode.Byte:
                    writer.Write((byte)obj);
                    break;

                case ForgedTypeCode.SByte:
                    writer.Write((sbyte)obj);
                    break;

                case ForgedTypeCode.Int16:
                    writer.Write((short)obj);
                    break;

                case ForgedTypeCode.UInt16:
                    writer.Write((ushort)obj);
                    break;

                case ForgedTypeCode.Int32:
                    writer.Write((int)obj);
                    break;

                case ForgedTypeCode.UInt32:
                    writer.Write((uint)obj);
                    break;

                case ForgedTypeCode.Int64:
                    writer.Write((long)obj);
                    break;

                case ForgedTypeCode.UInt64:
                    writer.Write((ulong)obj);
                    break;

                default:
                    writer.Write((int)obj);
                    break;
            }
        }
    }
}