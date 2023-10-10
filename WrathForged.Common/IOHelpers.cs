// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;

#pragma warning disable CS8600
#pragma warning disable CS8603

namespace WrathForged.Common;

public static class IOHelpers
{
    /// <summary>
    ///     Compares the values of 2 objects
    /// </summary>
    /// <returns>if types are equal and have the same property values</returns>
    public static bool AreObjectsEqual(object obj1, object obj2)
    {
        if (obj1 == null || obj2 == null)
            return obj1 == obj2;

        var type = obj1.GetType();

        if (type != obj2.GetType())
            return false;

        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var property in properties)
        {
            var value1 = property.GetValue(obj1);
            var value2 = property.GetValue(obj2);

            if (!Equals(value1, value2))
                return false;
        }

        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        foreach (var field in fields)
        {
            var value1 = field.GetValue(obj1);
            var value2 = field.GetValue(obj2);

            if (!Equals(value1, value2))
                return false;
        }

        return true;
    }

    public static bool AreObjectsNotEqual(object obj1, object obj2) => !AreObjectsEqual(obj1, obj2);

    public static bool DoesTypeSupportInterface(Type type, Type inter)
    {
        return type != inter
               && (inter.IsAssignableFrom(type)
                   || type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == inter) || type.GetInterfaces().Any(i => i == inter));
    }

    public static HashSet<Assembly> GetAllAssembliesInDir(params string[] path)
    {
        if (path.Length == 0)
            path = [".\\Scripts"];

        HashSet<Assembly> assemblies = [];

        foreach (var pathPart in path)
        {
            if (!Directory.Exists(pathPart))
                _ = Directory.CreateDirectory(pathPart);

            DirectoryInfo dir = new(pathPart);

            var dlls = dir.GetFiles("*.dll", SearchOption.AllDirectories);

            assemblies.AddRange(dlls.Select(dll => Assembly.LoadFile(dll.FullName)));
        }

        assemblies.AddRange(AppDomain.CurrentDomain.GetAssemblies().Where(a => a.GetName()?.Name?.Contains("WrathForged") == true));

        return assemblies;
    }

    public static IEnumerable<T> GetAllObjectsThatUseInterface<T>(this Assembly assembly)
    {
        var interF = typeof(T);
        var types = assembly.GetTypes().Where(t => DoesTypeSupportInterface(t, interF));

        foreach (var type in types)
        {
            yield return (T)Activator.CreateInstance(type);
        }
    }
}