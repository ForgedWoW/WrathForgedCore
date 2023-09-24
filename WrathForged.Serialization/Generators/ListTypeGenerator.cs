// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Text;
using Microsoft.CodeAnalysis;
using WrathForged.Serialization.Models;

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

            var collectionType = SerializationGenerator.DetermineCollectionType(typeSymbol);

            // Check if the size was already written using CollectionSizeIndex
            var size = SerializationGenerator.GenerateCollectionSizeCode(attribute, variableName, collectionType);

            if (!string.IsNullOrEmpty(size))
                listSerialization.AppendLine(size);

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

        public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attr, ForgedTypeCode forgedTypeCode, Compilation compilation, INamedTypeSymbol containerSymbol, string variableName)
        {
            if (!(typeSymbol is INamedTypeSymbol namedType) || !namedType.IsGenericType || namedType.TypeArguments.Length != 1)
            {
                throw new InvalidOperationException("Expected a generic list type.");
            }

            var codeBuilder = new StringBuilder();

            // Determine the type of the list elements
            var elementType = namedType.TypeArguments[0].Name;

            // Generate code to create a new list instance
            codeBuilder.AppendLine($"var {variableName}List = new List<{elementType}>();");

            // Loop through the list and generate code to deserialize each element
            codeBuilder.AppendLine("for (int i = 0; i < collectionSize; i++)");
            codeBuilder.AppendLine("{");
            codeBuilder.AppendLine($"    {variableName}List.Add(reader.Read{elementType}());");
            codeBuilder.AppendLine("}");

            codeBuilder.AppendLine($"{variableName} = {variableName}List;");

            return codeBuilder.ToString();
        }
    }
}