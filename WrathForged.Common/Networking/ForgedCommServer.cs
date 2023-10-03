// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common.Serialization;
using WrathForged.Models.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Networking;

public class ForgedCommServer
{
    private readonly ForgedModelSerializer _forgedModelDeserialization;
    private readonly PacketRouter _packetRouter;
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;
    private readonly Dictionary<ClientSocket, PacketBuffer> _packetBuffers = new();

    public ForgedCommServer(ForgedModelSerializer forgedModelDeserialization, TCPServer tCPServer, PacketRouter packetRouter, ILogger logger, IConfiguration configuration)
    {
        _forgedModelDeserialization = forgedModelDeserialization;
        TCPServer = tCPServer;
        _packetRouter = packetRouter;
        _logger = logger;
        _configuration = configuration;
        TCPServer.OnClientConnected += TCPServer_OnClientConnected;
    }

    public TCPServer TCPServer { get; }

    /// <summary>
    ///     Starts the server on the configured port
    /// </summary>
    /// <param name="port"></param>
    public void Start(int port)
    {
        var bindIp = GertBindIP();

        TCPServer.Start(port, bindIp);
    }

    /// <summary>
    ///     Starts the server on the specified port.
    /// </summary>
    /// <param name="ipAddress"></param>
    /// <param name="port"></param>
    public void StartOnPort(string ipAddress, int port)
    {
        var bindIp = GertBindIP(ipAddress);

        TCPServer.Start(port, bindIp);
    }

    private IPAddress GertBindIP(string? bindIpString = null)
    {
        bindIpString ??= _configuration.GetDefaultValue("ClientTCPServer:BindIP", "*");
        var bindIp = IPAddress.Any;

        if (bindIpString != "*")
        {
            if (IPAddress.TryParse(bindIpString, out var newAddress))
            {
                bindIp = newAddress;
            }
            else
            {
                _logger.Error("Invalid IP address specified for configuration: ClientTCPServer:BindIP");
            }
        }

        return bindIp;
    }

    private void TCPServer_OnClientConnected(object? sender, ClientSocket e)
    {
        e.OnDataReceived += DataReceived;
        e.OnDisconnect += Disconnected;
    }

    private void Disconnected(object? sender, EventArgs e)
    {
        if (sender is not ClientSocket clientSocket)
            return;

        // Remove the buffer associated with the disconnected client
        if (!_packetBuffers.ContainsKey(clientSocket))
            return;

        _packetBuffers[clientSocket].Dispose();
        _ = _packetBuffers.Remove(clientSocket);
    }

    private void DataReceived(object? sender, DataReceivedEventArgs e)
    {
        var buffer = GetOrCreateBufferForClient(e.Client);
        buffer.AppendData(e.Data);

        while (buffer.Reader.RemainingLength > 0)
        {
            if (_forgedModelDeserialization.TryDeserialize<ForgedPacket>(buffer, out var packet) == DeserializationResult.Success)
            {
                var result = _forgedModelDeserialization.TryDeserialize(packet.Scope, (uint)packet.OpCode, buffer, out var packetData);
                if (result == DeserializationResult.Success)
                {
                    _packetRouter.Route(e.Client, new PacketId(packet.OpCode, PacketScope.System), packetData);
                }
                else if (result is DeserializationResult.UnknownPacket or DeserializationResult.Error)
                {
                    buffer.Clear();
                    _logger.Error("Failed to deserialize packet data for packet {PacketId} in scope {PacketScope}", packet.OpCode, packet.Scope);
                }
            }

            buffer.ClearReadData();
        }
    }

    private PacketBuffer GetOrCreateBufferForClient(ClientSocket client)
    {
        if (!_packetBuffers.TryGetValue(client, out var session))
        {
            session = new PacketBuffer(_logger);
            _packetBuffers[client] = session;
        }

        return session;
    }
}