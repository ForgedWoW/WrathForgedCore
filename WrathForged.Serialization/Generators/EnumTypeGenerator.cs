// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization.Generators
{
    internal class EnumTypeGenerator : IForgedTypeGenerator
    {
        public string GenerateTypeCodeSerializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
        {
            if (typeSymbol.TypeKind != TypeKind.Enum)
                return string.Empty;

            var underlyingType = (typeSymbol as INamedTypeSymbol)?.EnumUnderlyingType;

            // Check if OverrideType attribute exists
            var overrideCode = attribute.GetNamedArg("OverrideType", ForgedTypeCode.Empty);
            if (overrideCode != ForgedTypeCode.Empty)
                typeCode = overrideCode;  // override the typeCode with the one from attribute
            _ = underlyingType?.SpecialType ?? default;

            // Modify the typeToUse based on the overridden type, if necessary
            SpecialType typeToUse;
            switch (typeCode)
            {
                case ForgedTypeCode.SByte:
                    typeToUse = SpecialType.System_SByte;
                    break;
                case ForgedTypeCode.Byte:
                    typeToUse = SpecialType.System_Byte;
                    break;
                case ForgedTypeCode.Int16:
                    typeToUse = SpecialType.System_Int16;
                    break;
                case ForgedTypeCode.UInt16:
                    typeToUse = SpecialType.System_UInt16;
                    break;
                case ForgedTypeCode.Int32:
                    typeToUse = SpecialType.System_Int32;
                    break;
                case ForgedTypeCode.UInt32:
                    typeToUse = SpecialType.System_UInt32;
                    break;
                case ForgedTypeCode.Int64:
                    typeToUse = SpecialType.System_Int64;
                    break;
                case ForgedTypeCode.UInt64:
                    typeToUse = SpecialType.System_UInt64;
                    break;
                default:
                    typeToUse = SpecialType.System_Int32; // defaulting to int
                    break;
            }

            switch (typeToUse)
            {
                case SpecialType.System_Byte:
                    return $"writer.Write((byte){variableName});";
                case SpecialType.System_SByte:
                    return $"writer.Write((sbyte){variableName});";
                case SpecialType.System_Int16:
                    return $"writer.Write((short){variableName});";
                case SpecialType.System_UInt16:
                    return $"writer.Write((ushort){variableName});";
                case SpecialType.System_Int32:
                    return $"writer.Write((int){variableName});";
                case SpecialType.System_UInt32:
                    return $"writer.Write((uint){variableName});";
                case SpecialType.System_Int64:
                    return $"writer.Write((long){variableName});";
                case SpecialType.System_UInt64:
                    return $"writer.Write((ulong){variableName});";
                default:
                    return $"writer.Write((int){variableName});";
            }
        }

        public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attr, ForgedTypeCode forgedTypeCode, Compilation compilation, INamedTypeSymbol containerSymbol, string variableName)
        {
            // Determine the underlying type of the enum
            var underlyingType = (typeSymbol as INamedTypeSymbol)?.EnumUnderlyingType?.Name;

            // Generate code to read the underlying type from the stream and cast it to the enum type
            return $"{variableName} = ({typeSymbol.Name})reader.Read{underlyingType}();";
        }
    }
}