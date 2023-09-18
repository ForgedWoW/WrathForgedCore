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
            var typeToUse = typeCode switch
            {
                ForgedTypeCode.SByte => SpecialType.System_SByte,
                ForgedTypeCode.Byte => SpecialType.System_Byte,
                ForgedTypeCode.Int16 => SpecialType.System_Int16,
                ForgedTypeCode.UInt16 => SpecialType.System_UInt16,
                ForgedTypeCode.Int32 => SpecialType.System_Int32,
                ForgedTypeCode.UInt32 => SpecialType.System_UInt32,
                ForgedTypeCode.Int64 => SpecialType.System_Int64,
                ForgedTypeCode.UInt64 => SpecialType.System_UInt64,
                _ => SpecialType.System_Int32,// defaulting to int
            };
            return typeToUse switch
            {
                SpecialType.System_Byte => $"writer.Write((byte){variableName});",
                SpecialType.System_SByte => $"writer.Write((sbyte){variableName});",
                SpecialType.System_Int16 => $"writer.Write((short){variableName});",
                SpecialType.System_UInt16 => $"writer.Write((ushort){variableName});",
                SpecialType.System_Int32 => $"writer.Write((int){variableName});",
                SpecialType.System_UInt32 => $"writer.Write((uint){variableName});",
                SpecialType.System_Int64 => $"writer.Write((long){variableName});",
                SpecialType.System_UInt64 => $"writer.Write((ulong){variableName});",
                _ => $"writer.Write((int){variableName});",
            };
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