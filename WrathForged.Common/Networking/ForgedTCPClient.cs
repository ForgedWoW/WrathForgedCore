// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks.Dataflow;
using Serilog;
using WrathForged.Common.Caching;
using WrathForged.Common.Serialization;
using WrathForged.Models;
using WrathForged.Models.Core.Comm;
using WrathForged.Models.Networking;
using WrathForged.Serialization.Models;

#pragma warning disable CS8618

namespace WrathForged.Common.Networking;

/// <summary>
///     For communication between realm and instance servers.
/// </summary>
public class ForgedTCPClient
{
    private readonly string _address;
    private readonly int _port;
    private readonly ILogger _logger;
    private readonly ForgedModelSerializer _forgedModelSerializer;
    private readonly PacketRouter _packetRouter;
    private readonly AttributeCache<ForgedSerializableAttribute> _forgedSerializableAttributeCache;
    private readonly ActionBlock<DataReceivedEventArgs> _dataProcessingBlock;
    private PrimitiveWriter _writeBuffer;
    private bool _loggedDisconnect;

    public ForgedTCPClient(string bindIP, string address, int port, ILogger logger, ProgramExitNotifier programExitNotifier,
                            ForgedModelSerializer forgedModelDeserialization, PacketRouter packetRouter, AttributeCache<ForgedSerializableAttribute> forgedSerializableAttributeCache)
    {
        _address = address;
        _port = port;
        _logger = logger;
        _forgedModelSerializer = forgedModelDeserialization;
        _packetRouter = packetRouter;
        _forgedSerializableAttributeCache = forgedSerializableAttributeCache;
        IncomingDataBuffer = new PacketBuffer(logger);
        ModelPacketBuffer = new PacketBuffer(logger);

        _dataProcessingBlock = new ActionBlock<DataReceivedEventArgs>(data =>
                            {
                                if (data.EventHandler == null)
                                {
                                    return;
                                }

                                foreach (var handler in data.EventHandler.GetInvocationList().Cast<EventHandler<DataReceivedEventArgs>>())
                                {
                                    try
                                    {
                                        handler?.Invoke(this, data);
                                    }
                                    catch (Exception ex)
                                    {
                                        _logger.Error(ex, "Error processing data from client");
                                    }
                                }

                                HandleData(data);
                            },
                            new ExecutionDataflowBlockOptions
                            {
                                MaxDegreeOfParallelism = 1,
                                CancellationToken = programExitNotifier.GetCancellationToken(),
                                EnsureOrdered = true,
                                NameFormat = "ForgedTCPClient Data Processing Thread {1}"
                            });

        if (string.IsNullOrEmpty(bindIP) || bindIP == "*")
            LowerClient = new TcpClient();
        else
        {
            if (IPAddress.TryParse(bindIP, out var newAddress))
                LowerClient = new TcpClient(new IPEndPoint(newAddress, 0));
            else
            {
                _logger.Error("Invalid IP address specified for bindIP");
                LowerClient = new TcpClient();
            }
        }

        ClientSocket = new ClientSocket(LowerClient, _logger, _dataProcessingBlock);
    }

    public TcpClient LowerClient { get; set; }
    public ClientSocket ClientSocket { get; set; }
    public PacketBuffer IncomingDataBuffer { get; set; }
    public PacketBuffer ModelPacketBuffer { get; set; }

    public void Connect()
    {
        if (LowerClient.Connected)
            return;

        while (!LowerClient.Connected)
        {
            if (IPAddress.TryParse(_address, out var ipAddress) && ipAddress != null)
                LowerClient.Connect(new IPEndPoint(ipAddress, _port));
            else if (string.IsNullOrEmpty(_address) || _address == "*")
                LowerClient.Connect(new IPEndPoint(IPAddress.Any, _port));
            else
                LowerClient.Connect(_address, _port);

            if (!LowerClient.Connected)
            {
                if (!_loggedDisconnect)
                {
                    _logger.Warning("Failed to connect to {Address}:{Port}. Retrying every 5 seconds...", _address, _port);
                    _loggedDisconnect = true;
                }

                Task.Delay(5000).Wait();
            }
        }

        _logger.Information("Connected to {Address}:{Port}", _address, _port);
        _loggedDisconnect = false;
        _writeBuffer = new PrimitiveWriter(LowerClient.GetStream());
    }

    public void Send<T>(T data)
    {
        if (data == null)
        {
            _logger.Error("Attempted to write null data to client");
            return;
        }

        if (!LowerClient.Connected)
            Connect();

        var type = typeof(T);

        if (!_forgedSerializableAttributeCache.TryGetAttribute(type, out var serializableAttribute))
        {
            _logger.Error("Failed to find serializable attribute for type {Type}", type);
            return;
        }

        var packet = new ForgedPacket
        {
            Scope = serializableAttribute.Scope,
            OpCode = (ForgedCoreOpCode)serializableAttribute.PacketIDs[0] // always 1 packet ID for system packets
        };

        using var stream = new MemoryStream();
        using var writer = new PrimitiveWriter(stream);
        _forgedModelSerializer.Serialize(packet.Scope, (uint)packet.OpCode, writer, data);

        packet.Data = stream.ToArray();
        packet.Size = packet.Data.Length;

        try
        {
            _forgedModelSerializer.Serialize(_writeBuffer, packet);
        }
        catch (SocketException sex)
        {
            _logger.Error(sex, "Failed to write data to client");
            Connect();
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Failed to write data to client");
        }
    }

    private void HandleData(DataReceivedEventArgs e)
    {
        IncomingDataBuffer.AppendData(e.Data);

        while (IncomingDataBuffer.Reader.RemainingLength > 0)
        {
            var position = IncomingDataBuffer.Reader.BaseStream.Position;
            if (_forgedModelSerializer.TryDeserialize<ForgedPacket>(IncomingDataBuffer, out var packet) == DeserializationResult.Success)
            {
                ModelPacketBuffer.AppendData(packet.Data);

                if (!ModelPacketBuffer.CanReadLength(packet.Size)) // ensure we got the entire packet. if not reset the position and wait for more data
                {
                    IncomingDataBuffer.Reader.BaseStream.Position = position;
                    break;
                }

                var result = _forgedModelSerializer.TryDeserialize(packet.Scope, (uint)packet.OpCode, ModelPacketBuffer, out var packetData);
                if (result == DeserializationResult.Success)
                {
                    _packetRouter.Route(e.Client, new PacketId(packet.OpCode, PacketScope.System), packetData);
                }
                else if (result is DeserializationResult.UnknownPacket or DeserializationResult.Error)
                {
                    IncomingDataBuffer.Clear();
                    _logger.Error("Failed to deserialize packet data for packet {PacketId} in scope {PacketScope}", packet.OpCode, packet.Scope);
                }

                ModelPacketBuffer.Clear();
            }

            IncomingDataBuffer.ClearReadData();
        }
    }
}