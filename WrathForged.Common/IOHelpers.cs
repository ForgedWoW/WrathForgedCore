// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;

namespace WrathForged.Common
{
    public static class IOHelpers
    {
        /// <summary>
        ///     Compares the values of 2 objects
        /// </summary>
        /// <returns> if types are equal and have the same property values </returns>
        public static bool AreObjectsEqual(object obj1, object obj2)
        {
            if (obj1 == null || obj2 == null)
                return obj1 == obj2;

            Type type = obj1.GetType();

            if (type != obj2.GetType())
                return false;

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                object? value1 = property.GetValue(obj1);
                object? value2 = property.GetValue(obj2);

                if (!Equals(value1, value2))
                    return false;
            }

            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                object? value1 = field.GetValue(obj1);
                object? value2 = field.GetValue(obj2);

                if (!Equals(value1, value2))
                    return false;
            }

            return true;
        }

        public static bool AreObjectsNotEqual(object obj1, object obj2)
        {
            return !AreObjectsEqual(obj1, obj2);
        }

        public static bool DoesTypeSupportInterface(Type type, Type inter)
        {
            if (type == inter) return false;

            if (inter.IsAssignableFrom(type))
                return true;

            return type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == inter) || type.GetInterfaces().Any(i => i == inter);
        }

        public static List<Assembly> GetAllAssembliesInDir(string? path = null, bool loadGameAssembly = true, bool loadScriptsDll = true)
        {
            path ??= ".\\Scripts";
            List<Assembly> assemblies = new();

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            DirectoryInfo dir = new(path);

            FileInfo[] dlls = dir.GetFiles("*.dll", SearchOption.AllDirectories);

            assemblies.AddRange(dlls.Select(dll => Assembly.LoadFile(dll.FullName)));

            if (loadGameAssembly)
                assemblies.Add(Assembly.GetEntryAssembly());

            if (loadScriptsDll && File.Exists(AppContext.BaseDirectory + "Scripts.dll"))
                assemblies.Add(Assembly.LoadFile(AppContext.BaseDirectory + "Scripts.dll"));

            return assemblies;
        }

        public static IEnumerable<T> GetAllObjectsFromAssemblies<T>(string path)
        {
            List<Assembly> assemblies = GetAllAssembliesInDir(path);

            foreach (Type? type in from assembly in assemblies from type in assembly.GetTypes() where DoesTypeSupportInterface(type, typeof(T)) select type)
                yield return (T)Activator.CreateInstance(type);
        }
    }
}