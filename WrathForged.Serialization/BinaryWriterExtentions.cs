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
    public static class BinaryWriterExtentions
    {
        public static void Write<T>(this BinaryWriter writer, T obj)
        {
            // Ensure the object is decorated with ForgeSerializableAttribute
            if (!Attribute.IsDefined(typeof(T), typeof(ForgeSerializableAttribute)))
                throw new InvalidOperationException($"{typeof(T).Name} is not marked with ForgeSerializableAttribute.");

            // Reflect and get properties with SerializablePropertyAttribute in order
            var properties = typeof(T).GetProperties()
                .Where(prop => Attribute.IsDefined(prop, typeof(SerializablePropertyAttribute)))
                .OrderBy(prop => ((SerializablePropertyAttribute)prop.GetCustomAttribute(typeof(SerializablePropertyAttribute))).Index)
                .ToList();

            foreach (var prop in properties)
            {
                var attribute = (SerializablePropertyAttribute)prop.GetCustomAttribute(typeof(SerializablePropertyAttribute));
                var value = prop.GetValue(obj);

                if (value is Array arrayValue)
                {
                    writer.Write(arrayValue.Length);  // Write the array length
                    var elementType = prop.PropertyType.GetElementType();
                    foreach (var item in arrayValue)
                    {
                        WriteValue(writer, item, elementType, attribute.OverrideType);  // Write each array item
                    }
                }
                else if (value is IList listValue && value.GetType().IsGenericType)
                {
                    writer.Write(listValue.Count);  // Write the list count
                    var elementType = prop.PropertyType.GetGenericArguments()[0];
                    foreach (var item in listValue)
                    {
                        WriteValue(writer, item, elementType, attribute.OverrideType);  // Write each list item
                    }
                }
                else if (Attribute.IsDefined(prop.PropertyType, typeof(ForgeSerializableAttribute)))
                {
                    Write(writer, value);  // Recursively serialize this object
                }
                else
                {
                    WriteValue(writer, value, prop.PropertyType, attribute.OverrideType);  // Regular single value write
                }
            }
        }

        // Enhanced helper method to encapsulate the value writing logic:
        private static void WriteValue(BinaryWriter writer, object value, Type actualType, TypeCode overrideType)
        {
            // If an override type is provided, use it. Otherwise, derive from the actual type.
            var typeToUse = overrideType != TypeCode.Empty ? overrideType : Type.GetTypeCode(actualType);

            switch (typeToUse)
            {
                case TypeCode.Boolean:
                    writer.Write(Convert.ToBoolean(value));
                    break;

                case TypeCode.Byte:
                    writer.Write(Convert.ToByte(value));
                    break;

                case TypeCode.Char:
                    writer.Write(Convert.ToChar(value));
                    break;

                case TypeCode.Decimal:
                    writer.Write(Convert.ToDecimal(value));
                    break;

                case TypeCode.Double:
                    writer.Write(Convert.ToDouble(value));
                    break;

                case TypeCode.Int16:
                    writer.Write(Convert.ToInt16(value));
                    break;

                case TypeCode.Int32:
                    writer.Write(Convert.ToInt32(value));
                    break;

                case TypeCode.Int64:
                    writer.Write(Convert.ToInt64(value));
                    break;

                case TypeCode.SByte:
                    writer.Write(Convert.ToSByte(value));
                    break;

                case TypeCode.Single:
                    writer.Write(Convert.ToSingle(value));
                    break;

                case TypeCode.String:
                    writer.Write(value as string);
                    break;

                case TypeCode.UInt16:
                    writer.Write(Convert.ToUInt16(value));
                    break;

                case TypeCode.UInt32:
                    writer.Write(Convert.ToUInt32(value));
                    break;

                case TypeCode.UInt64:
                    writer.Write(Convert.ToUInt64(value));
                    break;

                default:
                    throw new NotSupportedException($"TypeCode {typeToUse} not supported.");
            }
        }
    }
}