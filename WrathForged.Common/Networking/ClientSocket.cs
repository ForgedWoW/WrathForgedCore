// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks.Dataflow;
using Serilog;

namespace WrathForged.Common.Networking
{
    public class ClientSocket
    {
        private readonly TcpClient _client;
        private readonly ILogger _logger;
        private readonly ActionBlock<DataReceivedEventArgs> _actionBlock;

        public ClientSocket(TcpClient client, ILogger logger, ActionBlock<DataReceivedEventArgs> actionBlock)
        {
            _client = client;
            _logger = logger;
            _actionBlock = actionBlock;
            _client.ReceiveBufferSize = 0x4000;
            _client.NoDelay = true;
            _client.LingerState = new LingerOption(true, 0);
            IPEndPoint = _client.Client.RemoteEndPoint as IPEndPoint;

            Stream = _client.GetStream();
            _ = StartListening();
        }

        public event EventHandler OnDisconnect;

        public bool IsConnected => _client.Connected;

        public event EventHandler<DataReceivedEventArgs> OnDataReceived;

        public IPEndPoint? IPEndPoint { get; }

        public NetworkStream Stream { get; }

        public void Disconnect()
        {
            _client.Close();
            OnDisconnect?.Invoke(this, EventArgs.Empty);
        }

        private async Task StartListening()
        {
            var buffer = new Memory<byte>(new byte[0x4000]);
            while (_client.Connected)
            {
                try
                {
                    var bytesRead = await Stream.ReadAsync(buffer);
                    if (bytesRead > 0)
                    {
                        var data = buffer[..bytesRead].ToArray();
                        _actionBlock.Post(new DataReceivedEventArgs(this, data, OnDataReceived));
                    }
                }
                catch (Exception ex)
                {
                    Disconnect();
                    _logger.Error(ex, "Error while reading from client");
                    break;
                }
            }
        }
    }
}