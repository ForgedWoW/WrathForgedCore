// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Linq;
using Microsoft.CodeAnalysis;

namespace WrathForged.Serialization
{
    public static class Ext
    {
        public static T GetNamedArg<T>(this AttributeData attribute, string attributeName, T defaultVal)
        {
            if (attribute.HasNamedArg(attributeName))
                return (T)attribute.NamedArguments.First(arg => arg.Key == attributeName).Value.Value;

            return defaultVal;
        }

        public static bool HasNamedArg(this AttributeData attribute, string attributeName)
        {
            return attribute.NamedArguments.Any(arg => arg.Key == attributeName);
        }
    }
}