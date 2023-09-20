// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using Grace.DependencyInjection;

#pragma warning disable CS8618

namespace WrathForged.Common
{
    public class ClassFactory
    {
        public DependencyInjectionContainer Container { get; private set; }

        public void Initialize(DependencyInjectionContainer container) => Container = container;

        public T Resolve<T>() => Container.Locate<T>();

        public IEnumerable<T> ResolveAll<T>() => Container.Locate<IEnumerable<T>>();

        /// <summary>
        ///     Gets a object from the container with the given parameters
        /// </summary>
        /// <typeparam name="T">The object type</typeparam>
        /// <param name="parameters">Addtional parameters keyed by the parameter name</param>
        /// <returns>The resolved object</returns>
        public T Resolve<T>(Dictionary<string, object> parameters) => Container.Locate<T>(parameters);

        /// <summary>
        ///     Gets a object from the container with the given parameters in the order they appear in the constructor
        /// </summary>
        /// <typeparam name="T">The object type</typeparam>
        /// <param name="parameters">The parameters in the order they appear in the constructor</param>
        /// <returns>The resloved object</returns>
        public T ResolveWithPositionalParameters<T>(params object[] parameters)
        {
            return Container.Locate<T>(parameters);
        }
    }
}