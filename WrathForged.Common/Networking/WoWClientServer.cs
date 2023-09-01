// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Serilog;
using WrathForged.Models.Networking;
using WrathForged.Serialization;

namespace WrathForged.Common.Networking
{
    public class WoWClientServer
    {
        public const int HEADER_SIZE = 6;
        public const int LARGE_PACKET_HEADER_SIZE = 7;
        public const int LARGE_PACKET_THRESHOLD = 32767;

        private readonly PacketScope _packetScope;
        private readonly ForgedModelDeserialization _forgedModelDeserialization;
        private readonly PacketRouter _packetRouter;
        private readonly ILogger _logger;
        private readonly Dictionary<ClientSocket, WoWClientSession> _clientSessions = new();

        public WoWClientServer(PacketScope packetScope, ForgedModelDeserialization forgedModelDeserialization, TCPServer tCPServer, PacketRouter packetRouter, ILogger logger)
        {
            _packetScope = packetScope;
            _forgedModelDeserialization = forgedModelDeserialization;
            TCPServer = tCPServer;
            _packetRouter = packetRouter;
            _logger = logger;
            TCPServer.OnClientConnected += TCPServer_OnClientConnected;
        }

        public TCPServer TCPServer { get; }

        private void TCPServer_OnClientConnected(object? sender, ClientSocket e)
        {
            e.OnDataReceived += DataReceived;
            e.OnDisconnect += Disconnected;
        }

        private void Disconnected(object? sender, EventArgs e)
        {
            if (sender != null && sender is ClientSocket clientSocket)
            {
                // Remove the buffer associated with the disconnected client
                if (_clientSessions.ContainsKey(clientSocket))
                {
                    _clientSessions[clientSocket].PacketBuffer.Dispose();
                    _clientSessions.Remove(clientSocket);
                }
            }
        }

        private void DataReceived(object? sender, DataReceivedEventArgs e)
        {
            var session = GetOrCreateSessionForClient(e.Client);
            session.PacketBuffer.AppendData(e.Data);

            do
            {
                PacketId packetId;
                int headerSize;

                if (_packetScope == PacketScope.Auth)
                {
                    if (session.PacketBuffer.CanReadLength(sizeof(byte)))
                        packetId = new PacketId(session.PacketBuffer.Reader.ReadByte(), PacketScope.Auth);
                    else
                        return;
                }
                else
                {
                    var currentBufferPosition = (int)session.PacketBuffer.Reader.BaseStream.Position;
                    var packetLength = 0;

                    if (session.IsEncrypted)
                    {
                        var firstByte = session.GetDecryptedByte(session.PacketBuffer.GetBuffer().Slice(currentBufferPosition, 1), 0);
                        var isLargePacket = (firstByte & 0x80) != 0;

                        if (isLargePacket)
                        {
                            if (session.PacketBuffer.Reader.BaseStream.Length - currentBufferPosition < LARGE_PACKET_HEADER_SIZE)
                            {
                                session.DecryptUntil = 0;
                                return;
                            }

                            packetLength = (firstByte & 0x7F) << 16;
                            packetLength |= session.GetDecryptedByte(session.PacketBuffer.GetBuffer().Slice(currentBufferPosition + 1, 1), 1) << 8;
                            packetLength |= session.GetDecryptedByte(session.PacketBuffer.GetBuffer().Slice(currentBufferPosition + 2, 1), 2);

                            packetId = new PacketId(session.GetDecryptedOpcode(session.PacketBuffer.GetBuffer().Slice(currentBufferPosition + 3, 4)), _packetScope);
                            headerSize = LARGE_PACKET_HEADER_SIZE;
                        }
                        else
                        {
                            packetLength |= firstByte << 8;
                            packetLength |= session.GetDecryptedByte(session.PacketBuffer.GetBuffer().Slice(currentBufferPosition + 1, 1), 1);

                            packetId = new PacketId(session.GetDecryptedOpcode(session.PacketBuffer.GetBuffer().Slice(currentBufferPosition + 2, 3)), _packetScope);
                            headerSize = HEADER_SIZE;
                        }
                    }
                    else
                    {
                        var bufferSpan = session.PacketBuffer.GetBuffer().Span.Slice(currentBufferPosition, HEADER_SIZE);
                        packetLength = bufferSpan[0] << 8 | bufferSpan[1];

                        // the opcode is actually 4 bytes, but can never go over 2, so we skip the last 2
                        packetId = new PacketId((bufferSpan[2] | bufferSpan[3] << 8), _packetScope);
                        headerSize = HEADER_SIZE;
                    }

                    if (!session.PacketBuffer.CanReadLength(packetLength))
                    {
                        if (session.IsEncrypted)
                            session.DecryptUntil = headerSize;

                        return;
                    }
                }

                var packetIdPosition = session.PacketBuffer.Reader.BaseStream.Position;
                var result = _forgedModelDeserialization.TryDeserialize(_packetScope, packetId.Id, session.PacketBuffer, out var packet);

                if (result == DeserializationResult.Success && packet != null)
                    _packetRouter.Route(session, packetId, packet);
                else
                {
                    if (result == DeserializationResult.EndOfStream)
                        session.PacketBuffer.Reader.BaseStream.Position = packetIdPosition;
                    else
                        session.PacketBuffer.Clear();

                    break;
                }
            } while (session.PacketBuffer.Reader.BaseStream.Position < session.PacketBuffer.Reader.BaseStream.Length);
        }

        private WoWClientSession GetOrCreateSessionForClient(ClientSocket client)
        {
            if (!_clientSessions.TryGetValue(client, out var session))
            {
                session = new WoWClientSession(client, new PacketBuffer(), _logger);
                _clientSessions[client] = session;
            }

            return session;
        }
    }
}