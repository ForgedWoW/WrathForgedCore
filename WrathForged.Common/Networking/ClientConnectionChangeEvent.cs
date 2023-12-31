﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Networking;

public class ClientConnectionChangeEvent(ClientSocket client, EventHandler<ClientSocket> eventHandler, TCPServer.ConnectionState connectionState) : EventArgs
{
    public ClientSocket Client { get; } = client;
    internal EventHandler<ClientSocket> EventHandler { get; } = eventHandler;
    public TCPServer.ConnectionState ConnectionState { get; } = connectionState;
}