// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Serialization;

namespace WrathForged.Common.Networking
{
    public class WoWClientServer
    {
        private readonly PacketScope _packetScope;
        private readonly ForgedModelDeserialization _forgedModelDeserialization;
        private readonly PacketRouter _packetRouter;
        private readonly Dictionary<ClientSocket, PacketBuffer> _clientBuffers = new();

        public WoWClientServer(PacketScope packetScope, ForgedModelDeserialization forgedModelDeserialization, TCPServer tCPServer, PacketRouter packetRouter)
        {
            _packetScope = packetScope;
            _forgedModelDeserialization = forgedModelDeserialization;
            TCPServer = tCPServer;
            _packetRouter = packetRouter;
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
            const int headerSize = sizeof(ushort);

            while (clientBuffer.CanReadLength(headerSize))
            {
                var packetIdPosition = clientBuffer.Reader.BaseStream.Position;
                var packetId = clientBuffer.Reader.ReadUInt16();
                var result = _forgedModelDeserialization.TryDeserialize(_packetScope, packetId, clientBuffer, out var packet);
                if (result == DeserializationResult.Success && packet != null)
                    _packetRouter.Route(_packetScope, packetId, packet);
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
    }
}