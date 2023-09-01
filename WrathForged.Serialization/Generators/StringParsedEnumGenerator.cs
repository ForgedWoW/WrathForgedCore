// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.Text;
using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization.Generators
{
    public class StringParsedEnumGenerator : IForgedTypeGenerator
    {
        public string GenerateTypeCodeSerializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
        {
            var serialization = new StringBuilder();

            if (attribute.HasNamedArg("FixedSize"))
            {
                var fixedSize = attribute.GetNamedArg("FixedSize", string.Empty);
                serialization.AppendLine($"var fixedSizeString = instance.{variableName}?.PadRight({fixedSize}, '\\0').Substring(0, {fixedSize}) ?? string.Empty;");
                variableName = "fixedSizeString";
            }

            var reverseSerialization = attribute.GetNamedArg("ReversedString", false);
            var reverseString = reverseSerialization ? ".Reverse()" : "";

            switch (typeCode)
            {
                case ForgedTypeCode.CString:
                    serialization.AppendLine($"if ({variableName} != null) {{ writer.Write({variableName}.ToString(){reverseString}.ToCString()); }} else {{ writer.Write(string.Empty.ToCString()); }}");
                    break;

                case ForgedTypeCode.ASCIIString:
                    serialization.AppendLine($"if ({variableName} != null) {{ writer.Write(System.Text.Encoding.ASCII.GetBytes({variableName}.ToString(){reverseString})); }} else {{ writer.Write(System.Text.Encoding.ASCII.GetBytes(string.Empty)); }}");
                    break;

                default:
                    serialization.AppendLine($"if ({variableName} != null) {{ writer.Write({variableName}.ToString(){reverseString}); }} else {{ writer.Write(string.Empty); }}");
                    break;
            }

            return serialization.ToString();
        }

        public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
        {
            var reverseSerialization = attribute.GetNamedArg("ReversedString", false);
            var reverseString = reverseSerialization ? ".Reverse()" : "";

            switch (typeCode)
            {
                case ForgedTypeCode.CString:
                    return $"if (System.Enum.TryParse(typeof({typeSymbol.Name}), System.Text.Encoding.ASCII.GetString(reader.ReadCString()).TrimEnd('\\0'){reverseString}, out var {variableName}Val)) {{ instance.{variableName} = {variableName}Val; }}";

                case ForgedTypeCode.ASCIIString:
                    if (attribute.HasNamedArg("FixedSize"))
                    {
                        var fixedSize = attribute.GetNamedArg("FixedSize", 0);
                        return $"if (System.Enum.TryParse(typeof({typeSymbol.Name}), System.Text.Encoding.ASCII.GetString(reader.ReadBytes({fixedSize})).TrimEnd('\\0'){reverseString}, out var {variableName}Val)) {{ instance.{variableName} = {variableName}Val; }}";
                    }
                    else
                    {
                        return $"if (System.Enum.TryParse(typeof({typeSymbol.Name}), System.Text.Encoding.ASCII.GetString(reader.ReadByte()).TrimEnd('\\0'){reverseString}, out var {variableName}Val)) {{ instance.{variableName} = {variableName}Val; }}";
                    }

                default:
                    return $"if (System.Enum.TryParse(typeof({typeSymbol.Name}), reader.ReadString().TrimEnd('\\0'){reverseString}, out var {variableName}Val)) {{ instance.{variableName} = {variableName}Val; }}";
            }
        }
    }
}