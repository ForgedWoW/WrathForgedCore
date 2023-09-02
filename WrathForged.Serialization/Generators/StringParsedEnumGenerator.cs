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
            var reverseString = reverseSerialization ? ".Reverse().ToString()" : "";

            switch (typeCode)
            {
                case ForgedTypeCode.CString:
                    serialization.AppendLine($"writer.Write({variableName}.ToString(){reverseString}.ToCString());");
                    break;

                case ForgedTypeCode.ASCIIString:
                    serialization.AppendLine($"writer.Write(System.Text.Encoding.ASCII.GetBytes({variableName}.ToString(){reverseString}));");
                    break;

                default:
                    serialization.AppendLine($"writer.Write({variableName}.ToString(){reverseString});");
                    break;
            }

            return serialization.ToString();
        }

        public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
        {
            var reverseSerialization = attribute.GetNamedArg("ReversedString", false);
            var reverseString = reverseSerialization ? ".Reverse().ToString()" : "";

            switch (typeCode)
            {
                case ForgedTypeCode.CString:
                    return $"if (System.Enum.TryParse(typeof({typeSymbol.Name}), System.Text.Encoding.ASCII.GetString(reader.ReadCString()).TrimEnd('\\0'){reverseString}, out var {variableName}Val)) {{ instance.{variableName} = ({typeSymbol.Name}){variableName}Val; }}";

                case ForgedTypeCode.ASCIIString:
                    if (attribute.HasNamedArg("FixedSize"))
                        return $"instance.{variableName} = System.Text.Encoding.ASCII.GetString(reader.ReadBytes({attribute.GetNamedArg("FixedSize", 0)})).TrimEnd('\\0'){reverseString};";

                    return $"instance.{variableName} = System.Text.Encoding.ASCII.GetString(reader.ReadChars()).TrimEnd('\\0'){reverseString};";

                default:
                    if (attribute.HasNamedArg("FixedSize"))
                        return $"if (System.Enum.TryParse(typeof({typeSymbol.Name}), new string(reader.ReadChars({attribute.GetNamedArg("FixedSize", 0)})).TrimEnd('\\0'){reverseString}, out var {variableName}Val)) {{ instance.{variableName} = ({typeSymbol.Name}){variableName}Val; }}";

                    return $"if (System.Enum.TryParse(typeof({typeSymbol.Name}), new string(reader.ReadChars({attribute.AddCollectionSizeRead()})).TrimEnd('\\0'){reverseString}, out var {variableName}Val)) {{ instance.{variableName} = ({typeSymbol.Name}){variableName}Val; }}";
            }
        }
    }
}