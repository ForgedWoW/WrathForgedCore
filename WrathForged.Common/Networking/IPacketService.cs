// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Scripting.Interfaces;

namespace WrathForged.Common.Networking;

/// <summary>
///     Used at the time of DI to register a packet handler. Multiple packet handlers can be registered for the same container.
/// </summary>
public interface IPacketService : IForgedScript
{
}