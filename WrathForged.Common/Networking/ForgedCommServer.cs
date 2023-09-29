// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.Net;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common.Serialization;
using WrathForged.Models.Networking;
using WrathForged.Serialization;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Networking
{
    public class ForgedCommServer
    {
        public const int HEADER_SIZE = 6;
        public const int LARGE_PACKET_HEADER_SIZE = 7;
        public const int LARGE_PACKET_THRESHOLD = 32767;

        private readonly PacketScope _packetScope;
        private readonly ForgedModelSerializer _forgedModelDeserialization;
        private readonly PacketRouter _packetRouter;
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        private readonly Dictionary<ClientSocket, PacketBuffer> _packetBuffers = new();

        public ForgedCommServer(PacketScope packetScope, ForgedModelSerializer forgedModelDeserialization, TCPServer tCPServer, PacketRouter packetRouter, ILogger logger, IConfiguration configuration)
        {
            _packetScope = packetScope;
            _forgedModelDeserialization = forgedModelDeserialization;
            TCPServer = tCPServer;
            _packetRouter = packetRouter;
            _logger = logger;
            _configuration = configuration;
            TCPServer.OnClientConnected += TCPServer_OnClientConnected;
        }

        public TCPServer TCPServer { get; }

        /// <summary>
        ///     Starts the server on the configured port "ClientTCPServer:Port" or default port of 8085 if not configured.
        /// </summary>
        /// <param name="defaultPort"></param>
        public void Start(int defaultPort = 8085)
        {
            var bindIp = GertBindIP();

            TCPServer.Start(_configuration.GetDefaultValue("ClientTCPServer:Port", defaultPort), bindIp);
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
            if (_forgedModelDeserialization.TryDeserialize<ForgePacket>(buffer, out var packet) == DeserializationResult.Success)
            {
                if (_forgedModelDeserialization.TryDeserialize(packet.Scope, packet.Id, buffer, out var packetData) == DeserializationResult.Success)
                {
                    _packetRouter.Route(e.Client, new PacketId(packet.Id, _packetScope), packetData);
                }
                else
                {
                    _logger.Error("Failed to deserialize packet data for packet {PacketId} in scope {PacketScope}", packet.Id, packet.Scope);
                }
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
}