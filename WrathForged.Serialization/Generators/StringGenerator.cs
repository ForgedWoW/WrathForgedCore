// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.Text;
using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization.Generators
{
    public class StringGenerator : IForgedTypeGenerator
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
                    serialization.AppendLine($"if ({variableName} != null) {{ writer.Write({variableName}{reverseString}.ToCString()); }} else {{ writer.Write(string.Empty.ToCString()); }}");
                    break;

                case ForgedTypeCode.ASCIIString:
                    serialization.AppendLine($"if ({variableName} != null) {{ writer.Write(System.Text.Encoding.ASCII.GetBytes({variableName}{reverseString})); }} else {{ writer.Write(System.Text.Encoding.ASCII.GetBytes(string.Empty)); }}");
                    break;

                default:
                    serialization.AppendLine($"if ({variableName} != null) {{");
                    var sizeTypeName = attribute.GetTypeNameFromTypeCode();
                    serialization.AppendLine($"    writer.Write(({sizeTypeName}){variableName}{reverseString}.Length);"); // Cast the string length and then write it
                    serialization.AppendLine($"    writer.Write({variableName}{reverseString}.ToCharArray());");          // Write the string as a character array
                    serialization.AppendLine($"}} else {{");
                    serialization.AppendLine($"    writer.Write(({sizeTypeName})0);");  // Write 0 length for empty string
                    serialization.AppendLine($"    writer.Write(new char[0]);");  // Write an empty character array
                    serialization.AppendLine($"}}");
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
                    return $"instance.{variableName} = System.Text.Encoding.ASCII.GetString(reader.ReadCString()).TrimEnd('\\0'){reverseString};";

                case ForgedTypeCode.ASCIIString:
                    if (attribute.HasNamedArg("FixedSize"))
                        return $"instance.{variableName} = System.Text.Encoding.ASCII.GetString(reader.ReadBytes({attribute.GetNamedArg("FixedSize", 0)})).TrimEnd('\\0'){reverseString};";

                    return $"instance.{variableName} = System.Text.Encoding.ASCII.GetString(reader.ReadChars({attribute.AddCollectionSizeRead()})).TrimEnd('\\0'){reverseString};";

                default:
                    if (attribute.HasNamedArg("FixedSize"))
                        return $"instance.{variableName} = new string(reader.ReadChars({attribute.GetNamedArg("FixedSize", 0)})).TrimEnd('\\0'){reverseString};";

                    return $"instance.{variableName} = new string(reader.ReadChars({attribute.AddCollectionSizeRead()})).TrimEnd('\\0'){reverseString};";
            }
        }
    }
}