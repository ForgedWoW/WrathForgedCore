// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization.Generators
{
    public class ArrayTypeGenerator : IForgedTypeGenerator
    {
        private readonly SerializationGenerator _serializationGenerator;

        public ArrayTypeGenerator(SerializationGenerator serializationGenerator)
        {
            _serializationGenerator = serializationGenerator;
        }

        public string GenerateTypeCodeSerializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
        {
            var arraySerialization = new StringBuilder();

            var collectionType = _serializationGenerator.DetermineCollectionType(typeSymbol);

            // Check if the size was already written using CollectionSizeIndex
            var collectionSizeIndex = (uint?)attribute.NamedArguments.FirstOrDefault(na => na.Key == "CollectionSizeIndex").Value.Value;

            if (!collectionSizeIndex.HasValue)
            {
                arraySerialization.AppendLine(_serializationGenerator.GenerateCollectionSizeCode(attribute, variableName, collectionType));
            }

            arraySerialization.AppendLine($"if ({variableName} != null)");
            arraySerialization.AppendLine("{");
            arraySerialization.AppendLine($"foreach (var item in {variableName})");
            arraySerialization.AppendLine("{");

            // Serialize each array item using pattern matching
            if (typeSymbol is IArrayTypeSymbol elementType)
            {
                var elementSerializationCode = _serializationGenerator.GenerateTypeSerializationCode(compilation, symbol, elementType.ElementType, attribute, "item");
                if (!string.IsNullOrEmpty(elementSerializationCode))
                    arraySerialization.Append(elementSerializationCode);
            }

            arraySerialization.AppendLine("}");
            arraySerialization.AppendLine("}");

            return arraySerialization.ToString();
        }
    }
}