// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using WrathForged.Serialization;
using WrathForged.Serialization.Generators;

public class StringGenerator : IForgedTypeGenerator
{
    public string GenerateTypeCodeSerializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
    {
        var serialization = new StringBuilder();

        if (attribute.NamedArguments.Any(arg => arg.Key == "FixedSize"))
        {
            var fixedSize = attribute.NamedArguments.First(arg => arg.Key == "FixedSize").Value.Value;
            serialization.AppendLine($"var fixedSizeString = instance.{variableName}?.PadRight({fixedSize}, '\\0').Substring(0, {fixedSize}) ?? string.Empty;");
            variableName = "fixedSizeString";
        }

        switch (typeCode)
        {
            case ForgedTypeCode.CString:
                serialization.AppendLine($"if ({variableName} != null) {{ writer.Write({variableName}.ToCString()); }} else {{ writer.Write(string.Empty.ToCString()); }}");
                break;

            case ForgedTypeCode.ASCIIString:
                serialization.AppendLine($"if ({variableName} != null) {{ writer.Write(Encoding.ASCII.GetBytes({variableName})); }} else {{ writer.Write(Encoding.ASCII.GetBytes(string.Empty)); }}");
                break;

            default:
                serialization.AppendLine($"if ({variableName} != null) {{ writer.Write({variableName}); }} else {{ writer.Write(string.Empty); }}");
                break;
        }

        return serialization.ToString();
    }

    public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
    {
        switch (typeCode)
        {
            case ForgedTypeCode.CString:
                return $"{variableName} = Encoding.ASCII.GetString(reader.ReadCString());";

            case ForgedTypeCode.ASCIIString:
                if (attribute.NamedArguments.Any(arg => arg.Key == "FixedSize"))
                {
                    var fixedSize = attribute.NamedArguments.First(arg => arg.Key == "FixedSize").Value.Value;
                    return $"{variableName} = Encoding.ASCII.GetString(reader.ReadBytes({fixedSize})).TrimEnd('\\0');";
                }
                else
                {
                    return $"{variableName} = Encoding.ASCII.GetString(reader.ReadByteArray());";
                }

            default:
                return $"instance.{variableName} = reader.ReadString();";
        }
    }
}