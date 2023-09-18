// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization
{
    public static class GeneratorExt
    {
        public static T GetNamedArg<T>(this AttributeData attribute, string attributeName, T defaultVal)
        {
            if (attribute != null && attribute.HasNamedArg(attributeName))
            {
                var val = attribute.NamedArguments.First(arg => arg.Key == attributeName).Value.Value;
                return val != null ? (T)val : defaultVal;
            }

            return defaultVal;
        }

        public static bool HasNamedArg(this AttributeData attribute, string attributeName) => attribute.NamedArguments.Any(arg => arg.Key == attributeName);

        public static string AddCollectionSizeRead(this AttributeData attribute)
        {
            return attribute?.GetNamedArg("CollectionSizeLengthType", TypeCode.Empty) switch
            {
                TypeCode.UInt32 => "(int)reader.ReadUInt32()",
                TypeCode.Int16 => "(int)reader.ReadInt16()",
                TypeCode.Int32 => "reader.ReadInt32()",
                TypeCode.UInt16 => "(int)reader.ReadUInt16()",
                _ => "(int)reader.ReadByte()",
            };
        }

        public static string GetTypeNameFromTypeCode(this AttributeData attribute)
        {
            return attribute?.GetNamedArg("CollectionSizeLengthType", TypeCode.Empty) switch
            {
                TypeCode.Boolean => "bool",
                TypeCode.Byte => "byte",
                TypeCode.Char => "char",
                TypeCode.DateTime => "DateTime",
                TypeCode.Decimal => "decimal",
                TypeCode.Double => "double",
                TypeCode.Int16 => "short",
                TypeCode.Int32 => "int",
                TypeCode.Int64 => "long",
                TypeCode.SByte => "sbyte",
                TypeCode.Single => "float",
                TypeCode.String => "string",
                TypeCode.UInt16 => "ushort",
                TypeCode.UInt32 => "uint",
                TypeCode.UInt64 => "ulong",
                _ => "int",
            };
        }
    }
}