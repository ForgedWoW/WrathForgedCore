using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization.Generators
{
    internal class StringGenerator : IForgedTypeGenerator
    {
        public string GenerateTypeCode(IPropertySymbol prop, AttributeData attribute, ForgedTypeCode typeCode)
        {
            switch (typeCode)
            {
                case ForgedTypeCode.CString:
                    return $"        writer.Write(instance.{prop.Name}.ToCString());";
                case ForgedTypeCode.ASCIIString:
                    return $"        writer.Write(Encoding.ASCII.GetBytes(instance.{prop.Name}));";
            }

            return $"        writer.Write(instance.{prop.Name});";
        }

       
    }
}
