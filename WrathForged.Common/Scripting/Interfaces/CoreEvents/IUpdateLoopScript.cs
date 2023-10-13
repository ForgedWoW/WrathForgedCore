// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Scripting.Interfaces.CoreEvents;

/// <summary>
///     This is of type <see cref="IForgedScript" /> and <see cref="IUpdateLoop" />.
///     This will automatically register the script to the update loop as a singleton.
///     These will live for the lifetime of the server. If you need a shorter lifetime, use <see cref="IUpdateLoop"/> and manage the
///     Registration manually with <see cref="ServerUpdateLoop"/>
/// </summary>
public interface IUpdateLoopScript : IForgedScript, IUpdateLoop
{
}
