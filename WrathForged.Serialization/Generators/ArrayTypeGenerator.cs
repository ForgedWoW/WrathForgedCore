// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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

            arraySerialization.AppendLine($"if ({variableName} == null || {variableName}.Length == 0)");
            arraySerialization.AppendLine("{");
            arraySerialization.AppendLine($"writer.Write(0);");
            arraySerialization.AppendLine("}");
            arraySerialization.AppendLine("else");
            arraySerialization.AppendLine("{");
            // Add the code to write the array length
            arraySerialization.AppendLine($"writer.Write({variableName}.Length);");

            // Loop to serialize each array element
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