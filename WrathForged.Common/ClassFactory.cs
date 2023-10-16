﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Grace.DependencyInjection;

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

    /// <summary>
    ///     Gets a object from the container with the given parameters. The parameters must be keyed by the parameter name. At time of registration the type must be registered with the container. <see cref="Container"/> to register a type.
    /// </summary>
    /// <typeparam name="T">The object type</typeparam>
    /// <param name="parameters">Additional parameters keyed by the parameter name</param>
    /// <returns>The resolved object</returns>
    public T Locate<T>(Dictionary<string, object> parameters) => Container.Locate<T>(extraData: parameters);

    /// <summary>
    ///     Gets a object from the container with the given parameters in the order they appear in the constructor. At time of registration the type must be registered with the container. <see cref="Container"/> to register a type.
    /// </summary>
    /// <typeparam name="T">The object type</typeparam>
    /// <param name="parameters">The parameters in the order they appear in the constructor</param>
    /// <returns>The resolved object</returns>
    public T Locate<T>(dynamic parameters) => Container.Locate<T>(extraData: parameters);
}