// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections.Concurrent;
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
    private readonly ConcurrentDictionary<uint, IWoWClientSession> _clientSessions = [];
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

    public int ConnectionCount => _clientSessions.Count;

    public IEnumerable<T> GetClientSessions<T>() where T : IWoWClientSession => _clientSessions.Values.OfType<T>();

    public bool TryGetClientSession<T>(uint accountId, out T session) where T : IWoWClientSession
    {
        if (_clientSessions.TryGetValue(accountId, out var value))
        {
            session = (T)value;
            return true;
        }

        session = default!;
        return false;
    }

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

    internal void AddClientSession(IWoWClientSession session)
    {
        if (_clientSessions.TryGetValue(session.Security.Account.Id, out var existingSession)) // if the client is already connected, disconnect the old session
            existingSession.Dispose();

        _clientSessions[session.Security.Account.Id] = session;
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
        // Remove the buffer associated with the disconnected client
        if (e.ClientSession == null)
            return;

        if (!_clientSessions.TryRemove(e.ClientSession.Security.Account.Id, out var value))
            return;

        value.Dispose();
        _connectionCounter.Add(-1);
    }

    private void DataReceived(object? sender, DataReceivedEventArgs e)
    {
        if (e.Client.ClientSession == null)
            e.Client.ClientSession = _classFactory.Container.Locate<IWoWClientSession>(e.Client);

        var session = e.Client.ClientSession;

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
                    _ = _packetRouter.Route(session, packetId);
                    break;

                case PacketRouter.RouteType.DirectPacket:
                    _ = _packetRouter.RouteDirect(session, packetId, session.Network.PacketBuffer);
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
}