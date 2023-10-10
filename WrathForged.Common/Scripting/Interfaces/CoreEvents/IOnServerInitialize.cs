// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Scripting.Interfaces.CoreEvents;

/// <summary>
///     Called after dependencies are injected and resolved and is the initialization of the
///     server starting. <see cref="ClassFactory"/> is available for use.
/// </summary>
public interface IOnServerInitialize : IForgedScript
{
    /// <summary>
    ///     Called after dependencies are injected and resolved and is the initialization of the
    ///     server starting. <see cref="ClassFactory"/> is available for use.
    /// </summary>
    void OnServerInitialize();
}