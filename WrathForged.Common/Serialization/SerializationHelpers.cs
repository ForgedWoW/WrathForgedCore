// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections;
using WrathForged.Common.Networking;
using WrathForged.Models;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization;

public static class SerializationHelpers
{
    public static int GetCollectionSize(this PacketBuffer packetBuffer, PropertyMeta meta, Dictionary<uint, int> collectionSizes)
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
                        size = (int)packetBuffer.Reader.ReadUInt32();
                        break;

                    case TypeCode.Int16:
                        size = packetBuffer.Reader.ReadInt16();
                        break;

                    case TypeCode.Int32:
                        size = packetBuffer.Reader.ReadInt32();
                        break;

                    case TypeCode.Int64:
                        size = (int)packetBuffer.Reader.ReadInt64();
                        break;
                }
            }
            else
            {
                size = (int)packetBuffer.Reader.ReadUInt32();
            }
        }

        collectionSizes[meta.SerializationMetadata.Index] = size;

        return size;
    }

    public static void SerializeCollectionSize(this PrimitiveWriter writer, PropertyMeta prop, List<PropertyMeta> otherMeta, object obj)
    {
        uint size = 0;
        // Fixed size, so no need to write the size.
        if (prop.SerializationMetadata.FixedCollectionSize != 0)
            return;

        if (prop.SerializationMetadata.CollectionSizeIndex != 0)
        {
            // Get the size from the collection size index
            var sizeMeta = otherMeta[(int)prop.SerializationMetadata.CollectionSizeIndex];
            var val = sizeMeta.ReflectedProperty.GetValue(obj);

            if (val != null)
                size = (uint)val;
        }
        else
        {
            // Retrieve the actual collection object using reflection
            var collection = prop.ReflectedProperty.GetValue(obj);

            // Check for null collection
            if (collection == null)
            {
                size = 0;
            }
            else
            {
                // Get collection count based on its type (List, Array, HashSet)
                var propertyType = prop.ReflectedProperty.PropertyType;

                if (propertyType.IsArray)
                {
                    size = (uint)((Array)collection).Length;
                }
                else if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    size = (uint)((IList)collection).Count;
                }
                else if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(HashSet<>))
                {
                    size = (uint)((ICollection)collection).Count;
                }
            }
        }

        // Write the size based on the TypeCode
        if (prop.SerializationMetadata.CollectionSizeLengthType != TypeCode.Empty)
        {
            switch (prop.SerializationMetadata.CollectionSizeLengthType)
            {
                case TypeCode.Byte:
                    writer.WriteByte((byte)size);
                    break;

                case TypeCode.UInt16:
                    writer.WriteUShort((ushort)size);
                    break;

                case TypeCode.UInt32:
                    writer.WriteUInt(size);
                    break;

                case TypeCode.Int16:
                    writer.WriteShort((short)size);
                    break;

                case TypeCode.Int32:
                    writer.WriteInt((int)size);
                    break;

                case TypeCode.Int64:
                    writer.WriteLongBE(size);
                    break;

                default:
                    throw new NotSupportedException("Unsupported TypeCode for collection size.");
            }
        }
        else
        {
            // Default to UInt32 if TypeCode is Empty
            writer.WriteUInt(size);
        }
    }

    public static ForgedTypeCode GetForgedTypeCode(this Type t)
    {
        return Type.GetTypeCode(t) switch
        {
            TypeCode.Byte     => ForgedTypeCode.Byte,
            TypeCode.SByte    => ForgedTypeCode.SByte,
            TypeCode.Int16    => ForgedTypeCode.Int16,
            TypeCode.UInt16   => ForgedTypeCode.UInt16,
            TypeCode.Int32    => ForgedTypeCode.Int32,
            TypeCode.UInt32   => ForgedTypeCode.UInt32,
            TypeCode.Int64    => ForgedTypeCode.Int64,
            TypeCode.UInt64   => ForgedTypeCode.UInt64,
            TypeCode.Single   => ForgedTypeCode.Single,
            TypeCode.Double   => ForgedTypeCode.Double,
            TypeCode.String   => ForgedTypeCode.String,
            TypeCode.Boolean  => ForgedTypeCode.Boolean,
            TypeCode.Char     => ForgedTypeCode.Char,
            TypeCode.DateTime => ForgedTypeCode.DateTime,
            TypeCode.Decimal  => ForgedTypeCode.Decimal,
            TypeCode.Empty    => ForgedTypeCode.Empty,
            TypeCode.Object   => ForgedTypeCode.Object,
            TypeCode.DBNull   => ForgedTypeCode.DBNull,
            _                 => ForgedTypeCode.Empty,
        };
    }
}