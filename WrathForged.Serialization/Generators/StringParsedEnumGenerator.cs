// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization.Generators
{
    public class StringParsedEnumGenerator : IForgedTypeGenerator
    {
        public string GenerateTypeCodeSerializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
        {
            var serialization = new StringBuilder();

            if (attribute.NamedArguments.Any(arg => arg.Key == "FixedSize"))
            {
                var fixedSize = attribute.NamedArguments.FirstOrDefault(arg => arg.Key == "FixedSize").Value.Value;
                serialization.AppendLine($"var fixedSizeString = instance.{variableName}?.PadRight({fixedSize}, '\\0').Substring(0, {fixedSize}) ?? string.Empty;");
                variableName = "fixedSizeString";
            }

            var reverseSerialization = (bool?)attribute.NamedArguments.First(arg => arg.Key == "ReversedString").Value.Value;
            var reverseString = reverseSerialization == true ? ".Reverse()" : "";

            switch (typeCode)
            {
                case ForgedTypeCode.CString:
                    serialization.AppendLine($"if ({variableName} != null) {{ writer.Write({variableName}{reverseString}.ToCString()); }} else {{ writer.Write(string.Empty.ToCString()); }}");
                    break;

                case ForgedTypeCode.ASCIIString:
                    serialization.AppendLine($"if ({variableName} != null) {{ writer.Write(Encoding.ASCII.GetBytes({variableName}){reverseString}); }} else {{ writer.Write(Encoding.ASCII.GetBytes(string.Empty)); }}");
                    break;

                default:
                    serialization.AppendLine($"if ({variableName} != null) {{ writer.Write({variableName}{reverseString}); }} else {{ writer.Write(string.Empty); }}");
                    break;
            }

            return serialization.ToString();
        }

        public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
        {
            var reverseSerialization = (bool?)attribute.NamedArguments.FirstOrDefault(arg => arg.Key == "ReversedString").Value.Value;
            var reverseString = reverseSerialization == true ? ".Reverse()" : "";

            switch (typeCode)
            {
                case ForgedTypeCode.CString:
                    return $"if (Enum.TryParse(typeof({typeSymbol.Name}), Encoding.ASCII.GetString(reader.ReadCString()).TrimEnd('\\0'){reverseString}, out var {variableName}Val)) {{ instance.{variableName} = {variableName}Val; }}";

                case ForgedTypeCode.ASCIIString:
                    if (attribute.NamedArguments.Any(arg => arg.Key == "FixedSize"))
                    {
                        var fixedSize = attribute.NamedArguments.First(arg => arg.Key == "FixedSize").Value.Value;
                        return $"if (Enum.TryParse(typeof({typeSymbol.Name}), Encoding.ASCII.GetString(reader.ReadBytes({fixedSize})).TrimEnd('\\0'){reverseString}, out var {variableName}Val)) {{ instance.{variableName} = {variableName}Val; }}";
                    }
                    else
                    {
                        return $"if (Enum.TryParse(typeof({typeSymbol.Name}), Encoding.ASCII.GetString(reader.ReadByteArray()).TrimEnd('\\0'){reverseString}, out var {variableName}Val)) {{ instance.{variableName} = {variableName}Val; }}";
                    }

                default:
                    return $"if (Enum.TryParse(typeof({typeSymbol.Name}), reader.ReadString().TrimEnd('\\0'){reverseString}, out var {variableName}Val)) {{ instance.{variableName} = {variableName}Val; }}";
            }
        }
    }
}