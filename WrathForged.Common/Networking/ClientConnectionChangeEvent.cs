// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Networking
{
    public class ClientConnectionChangeEvent : EventArgs
    {
        public ClientSocket Client { get; }
        internal EventHandler<ClientSocket> EventHandler { get; }

        public ClientConnectionChangeEvent(ClientSocket client, EventHandler<ClientSocket> eventHandler)
        {
            Client = client;
            EventHandler = eventHandler;
        }
    }
}