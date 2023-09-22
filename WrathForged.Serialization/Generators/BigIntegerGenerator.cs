// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Microsoft.CodeAnalysis;
using WrathForged.Serialization.Models;

namespace WrathForged.Serialization.Generators
{
    public class BigIntegerGenerator : IForgedTypeGenerator
    {
        private readonly SerializationGenerator _serializationGenerator;

        public BigIntegerGenerator(SerializationGenerator serializationGenerator) => _serializationGenerator = serializationGenerator;

        public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName) => $"writer.Write({variableName}.ToByteArray());";

        public string GenerateTypeCodeSerializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName) => $"{variableName} = new BigInteger(reader.ReadBytes({attribute.GetNamedArg<uint>("FixedCollectionSize", 0)}));";
    }
}