// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using SSDI;

#pragma warning disable CS8618

namespace WrathForged.Common;

public class ClassFactory
{
    /// <summary>
    ///     The base Grace container. See <see cref="https://github.com/ipjohnson/Grace"/> for usage information.
    /// </summary>
    public DependencyInjectionContainer Container { get; private set; }

    internal void SetContainer(DependencyInjectionContainer container) => Container = container;

    /// <summary>
    ///     Gets a object based on the type from the container. At time of registration the type must be registered with the container. <see cref="Container"/> to register a type with Container.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T Locate<T>() => Container.Locate<T>();

    /// <summary>
    ///     Gets all instances of specified type from the container. Useful for when you have multiple implementations of a interface. At time of registration the type must be registered with the container. <see cref="Container"/> to register a type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public IEnumerable<T> LocateAll<T>() => Container.Locate<IEnumerable<T>>();

}