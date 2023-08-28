// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
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
            // Ensure the type is indeed a list
            if (!(typeSymbol is INamedTypeSymbol namedTypeSymbol && namedTypeSymbol.IsGenericType &&
                  namedTypeSymbol.ConstructedFrom.ToDisplayString().StartsWith("System.Collections.Generic.List<")))
            {
                return string.Empty;
            }

            var listSerialization = new StringBuilder();

            listSerialization.AppendLine($"if ({variableName} == null");
            listSerialization.AppendLine("{");
            listSerialization.AppendLine($"writer.Write(0);");
            listSerialization.AppendLine("}");
            listSerialization.AppendLine("else");
            listSerialization.AppendLine("{");
            // Write the list count first
            listSerialization.AppendLine($"writer.Write({variableName}.Count);");

            // Serialize each list item
            listSerialization.AppendLine($"foreach (var item in {variableName})");
            listSerialization.AppendLine("{");

            var elementType = namedTypeSymbol.TypeArguments[0];
            var elementSerializationCode = _serializationGenerator.GenerateTypeSerializationCode(compilation, symbol, elementType, attribute, "item");

            if (!string.IsNullOrEmpty(elementSerializationCode))
            {
                listSerialization.Append(elementSerializationCode);
            }

            listSerialization.AppendLine("}");
            listSerialization.AppendLine("}");

            return listSerialization.ToString();
        }
    }
}