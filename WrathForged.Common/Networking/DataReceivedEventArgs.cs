// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Networking;

public class DataReceivedEventArgs(ClientSocket client, byte[] data, EventHandler<DataReceivedEventArgs> eventHandler) : EventArgs
{
    public ClientSocket Client { get; } = client;
    public byte[] Data { get; } = data;
    internal EventHandler<DataReceivedEventArgs> EventHandler { get; } = eventHandler;
}