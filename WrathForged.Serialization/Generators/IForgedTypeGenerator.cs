// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.CodeAnalysis;
using WrathForged.Serialization.Models;

namespace WrathForged.Serialization.Generators
{
    internal interface IForgedTypeGenerator
    {
        string GenerateTypeCodeSerializeForType(
           ITypeSymbol typeSymbol,
           AttributeData attribute,
           ForgedTypeCode typeCode,
           Compilation compilation,
           INamedTypeSymbol symbol,
           string variableName);

        string GenerateTypeCodeDeserializeForType(
           ITypeSymbol typeSymbol,
           AttributeData attribute,
           ForgedTypeCode typeCode,
           Compilation compilation,
           INamedTypeSymbol symbol,
           string variableName);
    }
}