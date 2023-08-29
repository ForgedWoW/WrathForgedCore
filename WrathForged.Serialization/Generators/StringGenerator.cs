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

        public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attr, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol containerSymbol)
        {
            var codeBuilder = new StringBuilder();

            // Read the string length (assuming it's prefixed as an int32)
            codeBuilder.AppendLine("var strLength = reader.ReadInt32();");
            // Read the bytes
            codeBuilder.AppendLine("var strBytes = reader.ReadBytes(strLength);");

            // Convert the bytes back to a string based on the typeCode
            switch (typeCode)
            {
                case ForgedTypeCode.CString:
                    codeBuilder.AppendLine("var str = strBytes.FromCString();");
                    break;

                case ForgedTypeCode.ASCIIString:
                    codeBuilder.AppendLine("var str = Encoding.ASCII.GetString(strBytes);");
                    break;

                default:
                    codeBuilder.AppendLine("var str = Encoding.UTF8.GetString(strBytes);"); // Default to UTF-8, adjust if needed
                    break;
            }

            codeBuilder.AppendLine("return str;");

            return codeBuilder.ToString();
        }
    }
}