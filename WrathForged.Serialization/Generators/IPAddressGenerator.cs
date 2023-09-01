// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization.Generators
{
    public class IPAddressGenerator : IForgedTypeGenerator
    {
        public string GenerateTypeCodeSerializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
        {
            return $"if ({variableName} != null) {{ writer.Write({variableName}.GetAddressBytes()); }} else {{ writer.Write(IPAddress.Loopback.GetAddressBytes()); }}";
        }

        public string GenerateTypeCodeDeserializeForType(ITypeSymbol typeSymbol, AttributeData attribute, ForgedTypeCode typeCode, Compilation compilation, INamedTypeSymbol symbol, string variableName)
        {
            return $"instance.{variableName} = new IPAddress(reader.ReadBytes(4));"; // Assuming IPv4 for simplicity
        }
    }
}