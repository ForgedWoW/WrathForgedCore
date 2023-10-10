// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Scripting.Interfaces.CoreEvents
{
    /// <summary>
    ///     Inherit this interface to get access to the update loop.
    ///     You must register the implementation of this interface manually to <see cref="ServerUpdateLoop"/>
    ///     You can use the scripting interface <see cref="IUpdateLoopScript"/> to automatically register the script as a singleton
    ///     or you can manually register the implementation of this interface with <see cref="IOnServerInitialize"/> or any point in time.
    ///     If your instance is not static and not around for the entire lifetime of the server you must unregister it with <see cref="ServerUpdateLoop"/>
    ///     you can do this through several methods including when a player disconnects with <see cref="SessionNetwork.ClientSocket.OnDisconnect"/>
    /// </summary>
    public interface IUpdateLoop
    {
        void UpdateTick(uint diff);
    }
}
