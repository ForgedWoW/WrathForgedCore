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
        private readonly NetworkStream _stream;

        public ClientSocket(TcpClient client, ILogger logger, ActionBlock<DataReceivedEventArgs> actionBlock)
        {
            _client = client;
            _logger = logger;
            _actionBlock = actionBlock;
            _client.ReceiveBufferSize = 0x4000;
            _client.NoDelay = true;
            _client.LingerState = new LingerOption(true, 0);
            IPEndPoint = _client.Client.RemoteEndPoint as IPEndPoint;

            _stream = _client.GetStream();
            StartListening();
        }

        public event EventHandler OnDisconnect;

        public bool IsConnected => _client.Connected;

        public event EventHandler<DataReceivedEventArgs> OnDataReceived;

        public IPEndPoint? IPEndPoint { get; }

        public void Disconnect()
        {
            _client.Close();
            OnDisconnect?.Invoke(this, EventArgs.Empty);
        }

        private async void StartListening()
        {
            var buffer = new byte[0x4000];
            int bytesRead;

            while (_client.Connected)
            {
                try
                {
                    bytesRead = await _stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        var data = new byte[bytesRead];
                        System.Buffer.BlockCopy(buffer, 0, data, 0, bytesRead);
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