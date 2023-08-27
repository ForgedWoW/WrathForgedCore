// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WrathForged.Serialization
{
    public static class BinaryReaderExtensions
    {
        public static T Read<T>(this BinaryReader reader, T obj)
        {
            return obj;
        }

        public static T Read<T>(this BinaryReader reader) where T : new()
        {
            var obj = new T();

            if (!Attribute.IsDefined(typeof(T), typeof(ForgeSerializableAttribute)))
                throw new InvalidOperationException($"{typeof(T).Name} is not marked with ForgeSerializableAttribute.");

            var properties = typeof(T).GetProperties()
                .Where(prop => Attribute.IsDefined(prop, typeof(SerializablePropertyAttribute)))
                .OrderBy(prop => ((SerializablePropertyAttribute)prop.GetCustomAttribute(typeof(SerializablePropertyAttribute))).Index)
                .ToList();

            foreach (var prop in properties)
            {
                var attribute = (SerializablePropertyAttribute)prop.GetCustomAttribute(typeof(SerializablePropertyAttribute));

                if (prop.PropertyType.IsArray)
                {
                    var length = reader.ReadInt32(); // Read array length
                    var array = Array.CreateInstance(prop.PropertyType.GetElementType(), length);

                    for (int i = 0; i < length; i++)
                    {
                        array.SetValue(ReadValue(reader, prop.PropertyType.GetElementType(), attribute.OverrideType), i);
                    }

                    prop.SetValue(obj, array);
                }
                else if (typeof(IList).IsAssignableFrom(prop.PropertyType) && prop.PropertyType.IsGenericType)
                {
                    var count = reader.ReadInt32(); // Read list count
                    var listType = prop.PropertyType.GetGenericArguments()[0];
                    var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(listType));

                    for (int i = 0; i < count; i++)
                    {
                        list.Add(ReadValue(reader, listType, attribute.OverrideType));
                    }

                    prop.SetValue(obj, list);
                }
                else if (Attribute.IsDefined(prop.PropertyType, typeof(ForgeSerializableAttribute)))
                {
                    var value = ReadMethodForType(prop.PropertyType).Invoke(reader, null);
                    prop.SetValue(obj, value);
                }
                else
                {
                    prop.SetValue(obj, ReadValue(reader, prop.PropertyType, attribute.OverrideType));
                }
            }

            return obj;
        }

        private static object ReadValue(BinaryReader reader, Type actualType, ForgedTypeCode overrideType)
        {
            var typeToUse = overrideType != ForgedTypeCode.Empty ? overrideType : (ForgedTypeCode)Type.GetTypeCode(actualType);

            switch (typeToUse)
            {
                case ForgedTypeCode.Boolean:
                    return reader.ReadBoolean();

                case ForgedTypeCode.Byte:
                    if (actualType.IsEnum)
                        return Enum.ToObject(actualType, reader.ReadByte());
                    else
                        return reader.ReadByte();

                case ForgedTypeCode.SByte:
                    return reader.ReadSByte();

                case ForgedTypeCode.Char:
                    return reader.ReadChar();

                case ForgedTypeCode.Int16:
                    if (actualType.IsEnum)
                        return Enum.ToObject(actualType, reader.ReadInt16());
                    else
                        return reader.ReadInt16();

                case ForgedTypeCode.UInt16:
                    return reader.ReadUInt16();

                case ForgedTypeCode.Int32:
                    if (actualType.IsEnum)
                        return Enum.ToObject(actualType, reader.ReadInt32());
                    else
                        return reader.ReadInt32();

                case ForgedTypeCode.UInt32:
                    return reader.ReadUInt32();

                case ForgedTypeCode.Int64:
                    if (actualType.IsEnum)
                        return Enum.ToObject(actualType, reader.ReadInt64());
                    else
                        return reader.ReadInt64();

                case ForgedTypeCode.UInt64:
                    return reader.ReadUInt64();

                case ForgedTypeCode.Single:
                    return reader.ReadSingle();

                case ForgedTypeCode.Double:
                    return reader.ReadDouble();

                case ForgedTypeCode.Decimal:
                    return reader.ReadDecimal();

                case ForgedTypeCode.String:
                    return reader.ReadString();

                default:
                    throw new NotSupportedException($"ForgedTypeCode {typeToUse} not supported.");
            }
        }

        private static MethodInfo ReadMethodForType(Type type)
        {
            var method = typeof(BinaryReaderExtensions).GetMethod("Read", BindingFlags.Public | BindingFlags.Static);
            return method.MakeGenericMethod(type);
        }
    }
}