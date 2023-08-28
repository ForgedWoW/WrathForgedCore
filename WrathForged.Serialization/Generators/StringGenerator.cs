// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Text;
using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization.Generators
{
    internal class StringGenerator : IForgedTypeGenerator
    {
        public string GenerateTypeCodeSerializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
        {
            var arraySerialization = new StringBuilder();
            arraySerialization.AppendLine($"if (!string.IsNullOrEmpty(instance.{variableName}));");
            arraySerialization.AppendLine("{");
            switch (typeCode)
            {
                case ForgedTypeCode.CString:
                    arraySerialization.AppendLine($"        writer.Write(instance.{variableName}.ToCString());");
                    break;

                case ForgedTypeCode.ASCIIString:
                    arraySerialization.AppendLine($"        writer.Write(Encoding.ASCII.GetBytes(instance.{variableName}));");
                    break;

                default:
                    arraySerialization.AppendLine($"        writer.Write(instance.{variableName});");
                    break;
            }

            arraySerialization.AppendLine("}");
            return arraySerialization.ToString();
        }
    }
}