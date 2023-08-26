﻿using System.Reflection;
using Autofac;
using Autofac.Core;

namespace WrathForged.Common
{
    public class ClassFactory
    {
        public IContainer? Container { get; private set; }

        public void Initialize(IContainer container)
        {
            Container = container;
        }

        public T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        public T Resolve<T>(params Parameter[] parameters)
        {
            return Container.Resolve<T>(parameters);
        }

        public T ResolveWithPositionalParameters<T>(params object[] parameters)
        {
            var positionalParameters = new Parameter[parameters.Length];
            for (var i = 0; i < parameters.Length; i++)
                positionalParameters[i] = new PositionalParameter(i, parameters[i]);

            return Container.Resolve<T>(positionalParameters);
        }

        /// <summary>
        ///     Create a instance of any class with dependency injection that was not registered in the container at program start
        /// </summary>
        /// <typeparam name="T">The object type you wish to activate</typeparam>
        /// <param name="args">Arguments in order that they appear in the constructor. Must be the first args of the constructor.</param>
        /// <returns>A new instance of T</returns>
        public T ActiveNonRegistered<T>(params object[] args) where T : class
        {
            args ??= Array.Empty<object>();
            var constructors = typeof(T).GetConstructors();
            var highest = constructors.OrderByDescending(x => x.GetParameters().Length).First();

            return highest.GetParameters().Length switch
            {
                0 or 99 => Activator.CreateInstance(typeof(T)) as T,
                _ => Activator.CreateInstance(typeof(T), args.Combine(highest.GetParameters().Where(p => p.ParameterType.IsClass).Select(param => Container.Resolve(param.ParameterType)).ToArray())) as T
            };
        }

        /// <summary>
        ///     Create a instance of any class with dependency injection that was not registered in the container at program start
        /// </summary>
        /// <typeparam name="T">The object type you wish to activate</typeparam>
        /// <param name="constructor">the explicit constructor you wish to use</param>
        /// <param name="args">Arguments in order that they appear in the constructor. Must be the first args of the constructor.</param>
        /// <returns>A new instance of T</returns>
        public T ActiveNonRegistered<T>(ConstructorInfo constructor, params object[] args) where T : class
        {
            args ??= Array.Empty<object>();
            return constructor.GetParameters().Length switch
            {
                0 or 99 => Activator.CreateInstance(typeof(T)) as T,
                _ => Activator.CreateInstance(typeof(T), args.Combine(constructor.GetParameters().Where(p => p.ParameterType.IsClass).Select(param => Container.Resolve(param.ParameterType)).ToArray())) as T
            };
        }

        public IEnumerable<T> ResolveAllNonRegistered<T>(string? scriptDir = null)
        {
            var assemblies = IOHelpers.GetAllAssembliesInDir(scriptDir);

            foreach (var type in from assembly in assemblies from type in assembly.GetTypes() where IOHelpers.DoesTypeSupportInterface(type, typeof(T)) select type)
            {

                var constructors = type.GetConstructors();
                var highest = constructors.OrderByDescending(x => x.GetParameters().Length).First();

                yield return highest.GetParameters().Length switch
                {
                    0 or 99 => (T)Activator.CreateInstance(type),
                    _ => (T)Activator.CreateInstance(type, highest.GetParameters().Where(p => p.ParameterType.IsClass).Select(param => Container.Resolve(param.ParameterType)).ToArray())
                };
            }
        }
    }
}