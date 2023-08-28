using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization
{
    internal interface IForgedTypeGenerator
    {
        string GenerateTypeCode(IPropertySymbol prop, AttributeData attribute, ForgedTypeCode typeCode);
    }
}
