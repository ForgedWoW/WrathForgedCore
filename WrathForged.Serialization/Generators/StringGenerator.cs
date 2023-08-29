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
            serialization.AppendLine($"var fixedSizeString = instance.{variableName}.PadRight({fixedSize}, '\\0').Substring(0, {fixedSize});");
            variableName = "fixedSizeString";
        }

        switch (typeCode)
        {
            case ForgedTypeCode.CString:
                serialization.AppendLine($"writer.Write({variableName}.ToCString());");
                break;

            case ForgedTypeCode.ASCIIString:
                serialization.AppendLine($"writer.Write(Encoding.ASCII.GetBytes({variableName}));");
                break;

            default:
                serialization.AppendLine($"writer.Write({variableName});");
                break;
        }

        return serialization.ToString();
    }

    public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
    {
        var deserialization = new StringBuilder();

        switch (typeCode)
        {
            case ForgedTypeCode.CString:
                deserialization.AppendLine($"instance.{variableName} = Encoding.ASCII.GetString(reader.ReadCString());");
                break;

            case ForgedTypeCode.ASCIIString:
                if (attribute.NamedArguments.Any(arg => arg.Key == "FixedSize"))
                {
                    var fixedSize = attribute.NamedArguments.First(arg => arg.Key == "FixedSize").Value.Value;
                    deserialization.AppendLine($"instance.{variableName} = Encoding.ASCII.GetString(reader.ReadBytes({fixedSize})).TrimEnd('\\0');");
                }
                else
                {
                    deserialization.AppendLine($"instance.{variableName} = Encoding.ASCII.GetString(reader.ReadByteArray());");
                }

                break;

            default:
                deserialization.AppendLine($"instance.{variableName} = reader.ReadString();");
                break;
        }

        return deserialization.ToString();
    }

    public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol) => throw new System.NotImplementedException();
}