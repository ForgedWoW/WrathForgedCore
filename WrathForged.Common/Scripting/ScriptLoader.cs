// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections.ObjectModel;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common.Scripting.Interfaces.CoreEvents;

namespace WrathForged.Common.Scripting;

/// <summary>
///     Loads assemblies and registers all objects to Dependency Injected in and available to use via <see cref="ClassFactory" />
/// </summary>
public class ScriptLoader(ClassFactory classFactory, ILogger logger, IConfiguration configuration)
{
    private readonly ClassFactory _classFactory = classFactory;
    private readonly ILogger _logger = logger;
    private readonly IConfiguration _configuration = configuration;

    public ReadOnlyCollection<Assembly> Assemblies { get; private set; } = new ReadOnlyCollection<Assembly>(IOHelpers.GetAllAssembliesInDir(configuration.GetDefaultValue("Scripting:Directory", ".\\Scripts")).ToList());

    /// <summary>
    ///    Loads the assembly at the path provided
    /// </summary>
    /// <param name="assemblyPath"></param>
    public void LoadAssembly(string assemblyPath)
    {
        var assembly = Assembly.LoadFrom(assemblyPath);
        var assemblies = new List<Assembly>(Assemblies) { assembly };
        Assemblies = new ReadOnlyCollection<Assembly>(assemblies);
        _classFactory.Container.Configure(c =>
        {
            foreach (var di in assembly.GetAllObjectsThatUseInterface<IRegisterDependancyInjection>())
                di.RegisterDependancyInjection(c, _configuration, _logger);
        });
    }

    /// <summary>
    ///     Loads all the assemblies in the path provided. This will recursively search for all dlls in the path provided.
    /// </summary>
    /// <param name="path"></param>
    public void LoadAssemblies(string path)
    {
        var assemblies = new List<Assembly>(Assemblies);
        _classFactory.Container.Configure(c =>
        {
            foreach (var assemblyPath in Directory.GetFiles(path, "*.dll", SearchOption.AllDirectories))
            {
                var assembly = Assembly.LoadFrom(assemblyPath);
                assemblies.Add(assembly);

                foreach (var di in assembly.GetAllObjectsThatUseInterface<IRegisterDependancyInjection>())
                    di.RegisterDependancyInjection(c, _configuration, _logger);
            }
        });

        Assemblies = new ReadOnlyCollection<Assembly>(assemblies);
    }

    /// <summary>
    ///     Provide a list of paths to load dlls from. This will recursively search for all dlls in the paths provided.
    /// </summary>
    /// <param name="paths"></param>
    public void LoadAssemblies(params string[] paths)
    {
        var assemblies = new List<Assembly>(Assemblies);
        _classFactory.Container.Configure(c =>
        {
            foreach (var path in paths)
            {
                foreach (var assemblyPath in Directory.GetFiles(path, "*.dll", SearchOption.AllDirectories))
                {
                    var assembly = Assembly.LoadFrom(assemblyPath);
                    assemblies.Add(assembly);

                    foreach (var di in assembly.GetAllObjectsThatUseInterface<IRegisterDependancyInjection>())
                        di.RegisterDependancyInjection(c, _configuration, _logger);
                }
            }
        });

        Assemblies = new ReadOnlyCollection<Assembly>(assemblies);
    }

    /// <summary>
    ///     Gets all the types that have the attribute
    /// </summary>
    /// <typeparam name="T">The type of attribute on the class</typeparam>
    /// <returns></returns>
    public List<Type> GetAllTypesWithClassAttribute<T>()
    {
        var types = new List<Type>();
        var t = typeof(T);

        foreach (var assembly in Assemblies)
        {
            var assemblyTypes = assembly.GetTypes();
            foreach (var type in assemblyTypes)
            {
                if (type.GetCustomAttribute(t, false) != null)
                    types.Add(type);
            }
        }

        return types;
    }

    /// <summary>
    ///     Gets all the types that use the interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public List<Type> GetAllTypesThatUseInterface<T>()
    {
        var types = new List<Type>();
        foreach (var assembly in Assemblies)
        {
            foreach (var type in assembly.GetTypes())
            {
                if (type.IsClass && IOHelpers.DoesTypeSupportInterface(type, typeof(T)))
                    types.Add(type);
            }
        }

        return types;
    }

    /// <summary>
    ///     Gets all the interfaces that is not the interface provided that use the interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public List<Type> GetAllInterfacesThatUseInterface<T>()
    {
        var types = new List<Type>();
        var interF = typeof(T);
        foreach (var assembly in Assemblies)
        {
            foreach (var type in assembly.GetTypes())
            {
                if (type.IsInterface && IOHelpers.DoesTypeSupportInterface(type, typeof(T)) && type != interF)
                    types.Add(type);
            }
        }

        return types;
    }

    /// <summary>
    ///     Creates new instances of all the objects that use the interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public IEnumerable<T> GetAllObjectsWithInterface<T>()
    {
        var types = GetAllTypesThatUseInterface<T>();
        foreach (var type in types)
        {
            var obj = Activator.CreateInstance(type);

            if (obj != null)
                yield return (T)obj;
        }
    }

    /// <summary>
    ///     Adds all the objects that use the interface to the <see cref="ClassFactory" /> container
    /// </summary>
    /// <typeparam name="T">A interface</typeparam>
    public void RegisterAllObjectsWithInterface<T>()
    {
        var types = GetAllTypesThatUseInterface<T>();
        _classFactory.Container.Configure(c =>
        {
            foreach (var t in types)
            {
                if (t != null)
                    _ = c.Export(t).As(typeof(T));
            }
        });
    }

    /// <summary>
    ///     Searches registered assemblies for all types that use the interface as a base and registers them to the <see cref="ClassFactory" /> container
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public void RegisterAllTypesThatUseBaseInterface<T>() => RegisterAllObjectsWithInterfaces([.. GetAllInterfacesThatUseInterface<T>()]);

    /// <summary>
    ///     Registers all interfaces to the <see cref="ClassFactory" /> container
    /// </summary>
    /// <param name="interfaces"></param>
    public void RegisterAllObjectsWithInterfaces(params Type[] interfaces)
    {
        _classFactory.Container.Configure(c =>
        {
            foreach (var iFace in interfaces)
            {
                foreach (var assembly in Assemblies)
                {
                    foreach (var t in assembly.GetTypes())
                    {
                        if (t.IsClass && IOHelpers.DoesTypeSupportInterface(t, iFace))
                            _ = c.Export(t).As(iFace);
                    }
                }
            }
        });
    }
}