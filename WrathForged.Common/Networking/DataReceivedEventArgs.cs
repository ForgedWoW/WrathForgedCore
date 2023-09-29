// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Networking
{
    public class DataReceivedEventArgs : EventArgs
    {
        public ClientSocket Client { get; }
        public byte[] Data { get; }
        internal EventHandler<DataReceivedEventArgs> EventHandler { get; }

        public DataReceivedEventArgs(ClientSocket client, byte[] data, EventHandler<DataReceivedEventArgs> eventHandler)
        {
            Client = client;
            Data = data;
            EventHandler = eventHandler;
        }
    }
}