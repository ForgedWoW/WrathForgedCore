// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization
{
    public static class GeneratorExt
    {
        public static T GetNamedArg<T>(this AttributeData attribute, string attributeName, T defaultVal)
        {
            if (attribute.HasNamedArg(attributeName))
                return (T)attribute.NamedArguments.First(arg => arg.Key == attributeName).Value.Value;

            return defaultVal;
        }

        public static bool HasNamedArg(this AttributeData attribute, string attributeName)
        {
            return attribute.NamedArguments.Any(arg => arg.Key == attributeName);
        }

        public static string AddCollectionSizeRead(this AttributeData attribute)
        {
            switch (attribute.GetNamedArg("CollectionSizeLengthType", TypeCode.Empty))
            {
                case TypeCode.UInt32:
                    return "(int)reader.ReadUInt32()";

                case TypeCode.Int16:
                    return "(int)reader.ReadInt16()";

                case TypeCode.Int32:
                    return "reader.ReadInt32()";

                case TypeCode.UInt16:
                    return "(int)reader.ReadUInt16()";

                case TypeCode.Byte:
                default:
                    return "(int)reader.ReadByte()";
            }
        }
    }
}