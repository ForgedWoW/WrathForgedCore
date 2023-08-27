// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections;
using System.Reflection;

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
            T obj = new();

            if (!Attribute.IsDefined(typeof(T), typeof(ForgeSerializableAttribute)))
                throw new InvalidOperationException($"{typeof(T).Name} is not marked with ForgeSerializableAttribute.");

            List<PropertyInfo> properties = typeof(T).GetProperties()
                .Where(prop => Attribute.IsDefined(prop, typeof(SerializablePropertyAttribute)))
                .OrderBy(prop => ((SerializablePropertyAttribute)prop.GetCustomAttribute(typeof(SerializablePropertyAttribute))).Index)
                .ToList();

            foreach (PropertyInfo? prop in properties)
            {
                SerializablePropertyAttribute? attribute = (SerializablePropertyAttribute)prop.GetCustomAttribute(typeof(SerializablePropertyAttribute));

                if (prop.PropertyType.IsArray)
                {
                    int length = reader.ReadInt32(); // Read array length
                    Array array = Array.CreateInstance(prop.PropertyType.GetElementType(), length);

                    for (int i = 0; i < length; i++)
                    {
                        array.SetValue(ReadValue(reader, prop.PropertyType.GetElementType(), attribute.OverrideType), i);
                    }

                    prop.SetValue(obj, array);
                }
                else if (typeof(IList).IsAssignableFrom(prop.PropertyType) && prop.PropertyType.IsGenericType)
                {
                    int count = reader.ReadInt32(); // Read list count
                    Type listType = prop.PropertyType.GetGenericArguments()[0];
                    IList? list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(listType));

                    for (int i = 0; i < count; i++)
                    {
                        list.Add(ReadValue(reader, listType, attribute.OverrideType));
                    }

                    prop.SetValue(obj, list);
                }
                else if (Attribute.IsDefined(prop.PropertyType, typeof(ForgeSerializableAttribute)))
                {
                    object? value = ReadMethodForType(prop.PropertyType).Invoke(reader, null);
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
            ForgedTypeCode typeToUse = overrideType != ForgedTypeCode.Empty ? overrideType : (ForgedTypeCode)Type.GetTypeCode(actualType);

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
            MethodInfo? method = typeof(BinaryReaderExtensions).GetMethod("Read", BindingFlags.Public | BindingFlags.Static);
            return method.MakeGenericMethod(type);
        }
    }
}