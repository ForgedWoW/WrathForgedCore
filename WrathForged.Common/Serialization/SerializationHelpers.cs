// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization
{
    public static class SerializationHelpers
    {
        public static uint GetCollectionSize(this PacketBuffer packetBuffer, PropertyMeta meta, Dictionary<uint, uint> collectionSizes)
        {
            var size = meta.SerializationMetadata.FixedCollectionSize;

            if (size == 0 && meta.SerializationMetadata.CollectionSizeIndex != 0)
            {
                size = collectionSizes[meta.SerializationMetadata.CollectionSizeIndex];
            }
            else if (size == 0)
            {
                if (meta.SerializationMetadata.CollectionSizeLengthType != TypeCode.Empty)
                {
                    switch (meta.SerializationMetadata.CollectionSizeLengthType)
                    {
                        case TypeCode.Byte:
                            size = packetBuffer.Reader.ReadByte();
                            break;

                        case TypeCode.UInt16:
                            size = packetBuffer.Reader.ReadUInt16();
                            break;

                        case TypeCode.UInt32:
                            size = packetBuffer.Reader.ReadUInt32();
                            break;

                        case TypeCode.Int16:
                            size = (uint)packetBuffer.Reader.ReadInt16();
                            break;

                        case TypeCode.Int32:
                            size = (uint)packetBuffer.Reader.ReadInt32();
                            break;

                        case TypeCode.Int64:
                            size = (uint)packetBuffer.Reader.ReadInt64();
                            break;
                    }
                }
                else
                {
                    size = packetBuffer.Reader.ReadUInt32();
                }
            }

            collectionSizes[meta.SerializationMetadata.Index] = size;

            return size;
        }

        public static ForgedTypeCode GetForgedTypeCode(this Type t)
        {
            return Type.GetTypeCode(t) switch
            {
                TypeCode.Byte => ForgedTypeCode.Byte,
                TypeCode.SByte => ForgedTypeCode.SByte,
                TypeCode.Int16 => ForgedTypeCode.Int16,
                TypeCode.UInt16 => ForgedTypeCode.UInt16,
                TypeCode.Int32 => ForgedTypeCode.Int32,
                TypeCode.UInt32 => ForgedTypeCode.UInt32,
                TypeCode.Int64 => ForgedTypeCode.Int64,
                TypeCode.UInt64 => ForgedTypeCode.UInt64,
                TypeCode.Single => ForgedTypeCode.Single,
                TypeCode.Double => ForgedTypeCode.Double,
                TypeCode.String => ForgedTypeCode.String,
                TypeCode.Boolean => ForgedTypeCode.Boolean,
                TypeCode.Char => ForgedTypeCode.Char,
                TypeCode.DateTime => ForgedTypeCode.DateTime,
                TypeCode.Decimal => ForgedTypeCode.Decimal,
                TypeCode.Empty => ForgedTypeCode.Empty,
                TypeCode.Object => ForgedTypeCode.Object,
                TypeCode.DBNull => ForgedTypeCode.DBNull,
                _ => ForgedTypeCode.Empty,
            };
        }
    }
}