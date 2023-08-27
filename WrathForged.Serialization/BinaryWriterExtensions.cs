// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections;
using System.Reflection;
using System.Text;

namespace WrathForged.Serialization
{
    public static class BinaryWriterExtensions
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
        private static void WriteValue(BinaryWriter writer, object value, Type actualType, ForgedTypeCode overrideType)
        {
            // If an override type is provided, use it. Otherwise, derive from the actual type.
            var typeToUse = overrideType != ForgedTypeCode.Empty ? overrideType : (ForgedTypeCode)Type.GetTypeCode(actualType);

            switch (typeToUse)
            {
                case ForgedTypeCode.Boolean:
                    writer.Write(Convert.ToBoolean(value));
                    break;

                case ForgedTypeCode.Byte:
                    writer.Write(Convert.ToByte(value));
                    break;

                case ForgedTypeCode.Char:
                    writer.Write(Convert.ToChar(value));
                    break;

                case ForgedTypeCode.Decimal:
                    writer.Write(Convert.ToDecimal(value));
                    break;

                case ForgedTypeCode.Double:
                    writer.Write(Convert.ToDouble(value));
                    break;

                case ForgedTypeCode.Int16:
                    writer.Write(Convert.ToInt16(value));
                    break;

                case ForgedTypeCode.Int32:
                    writer.Write(Convert.ToInt32(value));
                    break;

                case ForgedTypeCode.Int64:
                    writer.Write(Convert.ToInt64(value));
                    break;

                case ForgedTypeCode.SByte:
                    writer.Write(Convert.ToSByte(value));
                    break;

                case ForgedTypeCode.Single:
                    writer.Write(Convert.ToSingle(value));
                    break;

                case ForgedTypeCode.String:
                    writer.Write(value as string);
                    break;

                case ForgedTypeCode.UInt16:
                    writer.Write(Convert.ToUInt16(value));
                    break;

                case ForgedTypeCode.UInt32:
                    writer.Write(Convert.ToUInt32(value));
                    break;

                case ForgedTypeCode.UInt64:
                    writer.Write(Convert.ToUInt64(value));
                    break;

                case ForgedTypeCode.CString:
                    writer.Write((value as string).ToCString());
                    break;

                case ForgedTypeCode.ASCIIString:
                    writer.Write(Encoding.ASCII.GetBytes(value as string));
                    break;

                default:
                    throw new NotSupportedException($"TypeCode {typeToUse} not supported.");
            }
        }

        private static byte[] ToCString(this string str)
        {
            byte[] utf8StringBytes = Encoding.UTF8.GetBytes(str);
            byte[] data = new byte[utf8StringBytes.Length + 1];
            Array.Copy(utf8StringBytes, data, utf8StringBytes.Length);
            data[data.Length - 1] = 0;
            return data;
        }
    }
}