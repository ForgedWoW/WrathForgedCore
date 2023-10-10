// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Diagnostics.Metrics;
using System.Net;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Common.Observability;
using WrathForged.Common.Serialization;
using WrathForged.Models.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Networking;

public class WoWClientServer
{
    public const int HEADER_SIZE = 6;
    public const int LARGE_PACKET_HEADER_SIZE = 7;
    public const int LARGE_PACKET_THRESHOLD = 32767;

    private readonly PacketScope _packetScope;
    private readonly ForgedModelSerializer _forgedModelDeserialization;
    private readonly PacketRouter _packetRouter;
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;
    private readonly ClassFactory _classFactory;
    private readonly Dictionary<ClientSocket, WoWClientSession> _clientSessions = new();
    private readonly Meter _meter;
    private readonly Counter<long> _connectionCounter;

    public WoWClientServer(PacketScope packetScope, ForgedModelSerializer forgedModelDeserialization, TCPServer tCPServer, PacketRouter packetRouter, ILogger logger,
                           MeterFactory meterFactory, IConfiguration configuration, ClassFactory classFactory)
    {
        _packetScope = packetScope;
        _forgedModelDeserialization = forgedModelDeserialization;
        TCPServer = tCPServer;
        _packetRouter = packetRouter;
        _logger = logger;
        _configuration = configuration;
        _classFactory = classFactory;
        TCPServer.OnClientConnected += TCPServer_OnClientConnected;
        _meter = meterFactory.GetOrCreateMeter(MeterKeys.WRATHFORGED_COMMON);
        _connectionCounter = _meter.CreateCounter<long>("WoWClientConnections", "Number of connections from WoW Clients");
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
        _connectionCounter.Add(1);
    }

    private void Disconnected(object? sender, ClientSocket e)
    {
        if (sender is not ClientSocket clientSocket)
            return;

        // Remove the buffer associated with the disconnected client
        if (!_clientSessions.TryGetValue(clientSocket, out var value))
            return;

        value.Network.PacketBuffer.Dispose();
        _ = _clientSessions.Remove(clientSocket);
        _connectionCounter.Add(-1);
    }

    private void DataReceived(object? sender, DataReceivedEventArgs e)
    {
        WoWClientSession session = GetOrCreateSessionForClient(e.Client);
        session.Network.PacketBuffer.AppendData(e.Data);
        var packetLength = 0;
        var packetReadTryCount = 0;

        do
        {
            PacketId packetId;

            if (_packetScope == PacketScope.ClientToAuth)
            {
                if (session.Network.PacketBuffer.CanReadLength(sizeof(byte)))
                    packetId = new PacketId(session.Network.PacketBuffer.Reader.ReadByte(), PacketScope.ClientToAuth);
                else
                    continue;
            }
            else
            {
                var currentBufferPosition = (int)session.Network.PacketBuffer.Reader.BaseStream.Position;

                int headerSize;

                if (session.Security.IsEncrypted)
                {
                    if (session.Security.PacketEncryption == null)
                        continue;

                    var firstByte = session.Security.PacketEncryption.GetDecryptedByte(session.Network.PacketBuffer.GetBuffer().Slice(currentBufferPosition, 1), 0);
                    var isLargePacket = (firstByte & 0x80) != 0;

                    if (isLargePacket)
                    {
                        if (session.Network.PacketBuffer.Reader.BaseStream.Length - currentBufferPosition < LARGE_PACKET_HEADER_SIZE)
                        {
                            session.Security.PacketEncryption.DecryptUntil = 0;
                            continue;
                        }

                        packetLength = (firstByte & 0x7F) << 16;
                        packetLength |= session.Security.PacketEncryption.GetDecryptedByte(session.Network.PacketBuffer.GetBuffer().Slice(currentBufferPosition + 1, 1), 1) << 8;
                        packetLength |= session.Security.PacketEncryption.GetDecryptedByte(session.Network.PacketBuffer.GetBuffer().Slice(currentBufferPosition + 2, 1), 2);

                        packetId = new PacketId(session.Security.PacketEncryption.GetDecryptedOpcode(session.Network.PacketBuffer.GetBuffer().Slice(currentBufferPosition + 3, 4)), _packetScope);
                        headerSize = LARGE_PACKET_HEADER_SIZE;
                    }
                    else
                    {
                        packetLength |= firstByte << 8;
                        packetLength |= session.Security.PacketEncryption.GetDecryptedByte(session.Network.PacketBuffer.GetBuffer().Slice(currentBufferPosition + 1, 1), 1);

                        packetId = new PacketId(session.Security.PacketEncryption.GetDecryptedOpcode(session.Network.PacketBuffer.GetBuffer().Slice(currentBufferPosition + 2, 3)), _packetScope);
                        headerSize = HEADER_SIZE;
                    }
                }
                else
                {
                    var bufferSpan = session.Network.PacketBuffer.GetBuffer().Span.Slice(currentBufferPosition, HEADER_SIZE);
                    packetLength = (bufferSpan[0] << 8) | bufferSpan[1];

                    // the opcode is actually 4 bytes, but can never go over 2, so we skip the last 2
                    packetId = new PacketId(bufferSpan[2] | (bufferSpan[3] << 8), _packetScope);
                    headerSize = HEADER_SIZE;
                }

                if (!session.Network.PacketBuffer.CanReadLength(packetLength))
                {
                    if (session.Security.IsEncrypted && session.Security.PacketEncryption != null)
                        session.Security.PacketEncryption.DecryptUntil = headerSize;

                    continue;
                }
            }

            _logger.Verbose("Received packet {PacketId} from {Client}. Unread buffer size: {BufferSize}", packetId, e.Client.IPEndPoint, session.Network.PacketBuffer.UnreadData);

            switch (_packetRouter.GetRouteType(packetId.Scope, packetId.Id))
            {
                case PacketRouter.RouteType.None:
                    session.Network.PacketBuffer.Clear(packetLength);
                    break;

                case PacketRouter.RouteType.NoPacket:
                    _packetRouter.Route(session, packetId);
                    break;

                case PacketRouter.RouteType.DirectPacket:
                    _packetRouter.RouteDirect(session, packetId, session.Network.PacketBuffer);
                    break;

                case PacketRouter.RouteType.DeserializedPacket:
                    if (session.Network.PacketBuffer.UnreadData == 0)
                        continue;

                    var posBeforeDeserialization = session.Network.PacketBuffer.Reader.BaseStream.Position;
                    var result = _forgedModelDeserialization.TryDeserialize(_packetScope, packetId.Id, session.Network.PacketBuffer, out var packet);
                    packetReadTryCount++;

                    if (result == DeserializationResult.Success && packet != null)
                    {
                        packetReadTryCount = 0;
                        _packetRouter.Route(session, packetId, packet);
                    }
                    else
                    {
                        if (result == DeserializationResult.EndOfStream &&
                            ((_packetScope == PacketScope.ClientToAuth && packetReadTryCount >= 2) // we need to read the rest of the packet yet. if we cannot read it after 2 tries, we clear the buffer there's no packet that big.
                            || _packetScope != PacketScope.ClientToAuth))
                            session.Network.PacketBuffer.Reader.BaseStream.Position = posBeforeDeserialization;
                        else
                            session.Network.PacketBuffer.Clear();
                    }
                    break;
            }

        } while (e.Client.IsConnected && session.Network.PacketBuffer.Reader.BaseStream.Position < session.Network.PacketBuffer.Reader.BaseStream.Length);
    }

    private WoWClientSession GetOrCreateSessionForClient(ClientSocket client)
    {
        if (!_clientSessions.TryGetValue(client, out var session))
        {
            session = _classFactory.Locate<WoWClientSession>(new { clientSocket = client });
            _clientSessions[client] = session;
        }

        return session;
    }
}