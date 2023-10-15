// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common;
public static class TypeExtensionMethods
{
    public static object? GetDefault(this Type type) => type.IsValueType ? Activator.CreateInstance(type) : null;
}
