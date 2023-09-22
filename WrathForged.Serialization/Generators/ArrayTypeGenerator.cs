// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Text;
using Microsoft.CodeAnalysis;
using WrathForged.Serialization.Models;

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
            var size = _serializationGenerator.GenerateCollectionSizeCode(attribute, variableName, collectionType);

            if (!string.IsNullOrEmpty(size))
                arraySerialization.AppendLine(size);

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

        public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attr, ForgedTypeCode forgedTypeCode, Compilation compilation, INamedTypeSymbol containerSymbol, string variableName)
        {
            if (!(typeSymbol is IArrayTypeSymbol arrayType))
            {
                throw new InvalidOperationException("Expected an array type.");
            }

            var codeBuilder = new StringBuilder();

            // Determine the type of the array elements
            var elementType = arrayType.ElementType.Name;

            // Generate code to create a new array instance
            codeBuilder.AppendLine($"var {variableName}Array = new {elementType}[collectionSize];");

            // Loop through the array and generate code to deserialize each element
            codeBuilder.AppendLine("for (int i = 0; i < collectionSize; i++)");
            codeBuilder.AppendLine("{");
            codeBuilder.AppendLine($"    {variableName}Array[i] = reader.Read{elementType}();"); // This assumes a direct mapping between elementType and reader methods. Adjust if needed.
            codeBuilder.AppendLine("}");

            codeBuilder.AppendLine($"{variableName} = {variableName}Array;");

            return codeBuilder.ToString();
        }
    }
}