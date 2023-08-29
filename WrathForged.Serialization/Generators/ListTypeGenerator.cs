// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization.Generators
{
    public class ListTypeGenerator : IForgedTypeGenerator
    {
        private readonly SerializationGenerator _serializationGenerator;

        public ListTypeGenerator(SerializationGenerator serializationGenerator)
        {
            _serializationGenerator = serializationGenerator;
        }

        public string GenerateTypeCodeSerializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
        {
            var listSerialization = new StringBuilder();

            var collectionType = _serializationGenerator.DetermineCollectionType(typeSymbol);

            // Check if the size was already written using CollectionSizeIndex
            var collectionSizeIndex = (uint?)attribute.NamedArguments.FirstOrDefault(na => na.Key == "CollectionSizeIndex").Value.Value;

            if (!collectionSizeIndex.HasValue)
            {
                listSerialization.AppendLine(_serializationGenerator.GenerateCollectionSizeCode(attribute, variableName, collectionType));
            }

            listSerialization.AppendLine($"if ({variableName} != null)");
            listSerialization.AppendLine("{");
            listSerialization.AppendLine($"foreach (var item in {variableName})");
            listSerialization.AppendLine("{");

            // Serialize each list item using pattern matching
            if (typeSymbol is INamedTypeSymbol namedTypeSymbol && namedTypeSymbol.IsGenericType && namedTypeSymbol.TypeArguments.Length == 1)
            {
                var itemType = namedTypeSymbol.TypeArguments[0];
                var elementSerializationCode = _serializationGenerator.GenerateTypeSerializationCode(compilation, symbol, itemType, attribute, "item");
                if (!string.IsNullOrEmpty(elementSerializationCode))
                    listSerialization.Append(elementSerializationCode);
            }

            listSerialization.AppendLine("}");
            listSerialization.AppendLine("}");

            return listSerialization.ToString();
        }

        public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attr, ForgedTypeCode forgedTypeCode, Compilation compilation, INamedTypeSymbol containerSymbol)
        {
            if (!(typeSymbol is INamedTypeSymbol namedType) || !namedType.IsGenericType || namedType.TypeArguments.Length != 1)
            {
                throw new InvalidOperationException("Expected a generic list type.");
            }

            var codeBuilder = new StringBuilder();

            // Determine the type of the list elements
            var elementType = namedType.TypeArguments[0].Name;

            // Generate code to create a new list instance
            codeBuilder.AppendLine($"var list = new List<{elementType}>();");

            // Loop through the list and generate code to deserialize each element
            codeBuilder.AppendLine("for (int i = 0; i < collectionSize; i++)");
            codeBuilder.AppendLine("{");
            codeBuilder.AppendLine($"    var element = reader.Read{elementType}();"); // This assumes a direct mapping between elementType and reader methods. Adjust if needed.
            codeBuilder.AppendLine("    list.Add(element);");
            codeBuilder.AppendLine("}");

            codeBuilder.AppendLine("return list;");

            return codeBuilder.ToString();
        }
    }
}