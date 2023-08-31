// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Buffers.Binary;
using Serilog;
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
        private readonly Dictionary<ClientSocket, PacketBuffer> _clientBuffers = new();
        private readonly PacketEncryption _packetEncryption;
        private readonly int _encrypt;
        private int _decryptSeq;
        private int _decryptUntil = -1;

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
                if (_clientBuffers.ContainsKey(clientSocket))
                {
                    _clientBuffers[clientSocket].Dispose();
                    _clientBuffers.Remove(clientSocket);
                }
            }
        }

        private void DataReceived(object? sender, DataReceivedEventArgs e)
        {
            var clientBuffer = GetOrCreateBufferForClient(e.Client);
            clientBuffer.AppendData(e.Data);

            // Assuming the packet header is just a UInt16 for the code
            var headerSize = sizeof(byte);

            if (_packetScope != PacketScope.Auth)
            {
                headerSize = HEADER_SIZE;
                var currentBufferPosition = (int)clientBuffer.Reader.BaseStream.Position;
                var firstByte = GetDecryptedByte(clientBuffer.GetBuffer().Slice(currentBufferPosition, 1), 0, 0);
                var isLargePacket = (firstByte & 0x80) != 0;

                if (isLargePacket)
                {
                    // packetLength has 23 bits
                    if (clientBuffer.Reader.BaseStream.Length - currentBufferPosition < LARGE_PACKET_HEADER_SIZE)
                    {
                        _decryptUntil = 0;
                        return;
                    }

                    packetLength = (firstByte & 0x7F) << 16;
                    packetLength |= GetDecryptedByte(recvBuffer, offset, 1) << 8;
                    packetLength |= GetDecryptedByte(recvBuffer, offset, 2);

                    opcode = GetDecryptedOpcode(recvBuffer, offset, 3);
                    headerSize = RealmPacketIn.LARGE_PACKET_HEADER_SIZE;
                }
                else
                {
                    // packetLength has 15 bits
                    packetLength |= firstByte << 8;
                    packetLength |= GetDecryptedByte(recvBuffer, offset, 1);

                    opcode = (RealmServerOpCode)GetDecryptedOpcode(recvBuffer, offset, 2);
                    headerSize = RealmPacketIn.HEADER_SIZE;
                }
            }

            while (clientBuffer.CanReadLength(headerSize))
            {
                var packetIdPosition = clientBuffer.Reader.BaseStream.Position;
                var packetId = clientBuffer.Reader.ReadUInt16();
                var result = _forgedModelDeserialization.TryDeserialize(_packetScope, packetId, clientBuffer, out var packet);

                if (result == DeserializationResult.Success && packet != null)
                    _packetRouter.Route(e.Client, _packetScope, packetId, packet);
                else
                {
                    // If packet is null, it means the packet is incomplete.
                    // Reset the position to before the code and break out of the loop.
                    // if the result is not due to EndOfStream, it means the packet is unknown or the deserialization failed. We should clear the buffer to get rid of the unknown packet.
                    if (result == DeserializationResult.EndOfStream)
                        clientBuffer.Reader.BaseStream.Position = packetIdPosition;
                    else
                        clientBuffer.Clear(); // Clear the buffer if the packet is unknown

                    break;
                }
            }
        }

        private PacketBuffer GetOrCreateBufferForClient(ClientSocket client)
        {
            if (!_clientBuffers.TryGetValue(client, out var buffer))
            {
                buffer = new PacketBuffer();
                _clientBuffers[client] = buffer;
            }

            return buffer;
        }

        private byte GetDecryptedByte(Memory<byte> inputData, int baseOffset, int offset)
        {
            if (Interlocked.Exchange(ref _decryptSeq, 1) == 1)
                _logger.Warning("Decrypting out of order packet");

            var dataStartOffset = baseOffset + offset;
            if (_decryptUntil < offset)
            {
                _packetEncryption.Decrypt(inputData, dataStartOffset, 1);
            }

            Interlocked.Exchange(ref _decryptSeq, 0);

            return inputData.Span[dataStartOffset];
        }

        private int GetDecryptedOpcode(PacketBuffer packetBuffer, int baseOffset, int offset)
        {
            var inputData = packetBuffer.GetBuffer();
            var dataStartOffset = baseOffset + offset;

            if (_decryptUntil < offset + 4)
            {
                _packetEncryption.Decrypt(inputData, dataStartOffset, 4);
            }

            return BinaryPrimitives.ReadInt32LittleEndian(inputData.Span[dataStartOffset..]);
        }
    }
}