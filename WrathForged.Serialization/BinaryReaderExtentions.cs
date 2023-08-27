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
    public static class BinaryReaderExtentions
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

        private static object ReadValue(BinaryReader reader, Type actualType, TypeCode overrideType)
        {
            var typeToUse = overrideType != TypeCode.Empty ? overrideType : Type.GetTypeCode(actualType);

            switch (typeToUse)
            {
                case TypeCode.Boolean:
                    return reader.ReadBoolean();

                case TypeCode.Byte:
                    return reader.ReadByte();
                // ... handle other cases similarly ...
                default:
                    throw new NotSupportedException($"TypeCode {typeToUse} not supported.");
            }
        }

        private static MethodInfo ReadMethodForType(Type type)
        {
            var method = typeof(BinaryReaderExtensions).GetMethod("Read", BindingFlags.Public | BindingFlags.Static);
            return method.MakeGenericMethod(type);
        }
    }
}