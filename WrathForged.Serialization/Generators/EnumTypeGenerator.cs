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

            if (underlyingType == null)
                return string.Empty;

            switch (underlyingType.SpecialType)
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
                    return string.Empty;
            }
        }
    }
}