// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks.Dataflow;
using Serilog;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace WrathForged.Common.Networking
{
    public class ClientSocket
    {
        private readonly TcpClient _client;
        private readonly ILogger _logger;
        private readonly ActionBlock<DataReceivedEventArgs> _actionBlock;
        private readonly AutoResetEvent _writeSemaphore = new(true);
        private readonly ConcurrentQueue<WoWClientPacketOut> _writeClientPacketQueue = new();
        private readonly ConcurrentQueue<byte[]> _writeQueue = new();

        private readonly NetworkStream _stream;

        public ClientSocket(TcpClient client, ILogger logger, ActionBlock<DataReceivedEventArgs> actionBlock)
        {
            _client = client;
            _logger = logger;
            _actionBlock = actionBlock;
            _client.ReceiveBufferSize = 0x4000;
            _client.NoDelay = true;
            _client.LingerState = new LingerOption(true, 0);

            if (_client.Client.RemoteEndPoint is IPEndPoint iPEndPoint)
            {
                IPEndPoint = iPEndPoint;
            }

            _stream = _client.GetStream();
            _ = StartListening();
            _ = ProcessWriteQueue();
        }

        private EventHandler _onDisconnect;
        private EventHandler<DataReceivedEventArgs> _onDataReceived;

#pragma warning disable CS8601 // Possible null reference assignment. -= is causing this warning for some reason.

        // with client disconnects, we need to remove the delegates from the backing fields so the GC can collect them
        public event EventHandler OnDisconnect
        {
            add => _onDisconnect += value;
            remove
            {
                if (_onDisconnect != null && value != null)
                {
                    _onDisconnect -= value;
                }
            }
        }

        public event EventHandler<DataReceivedEventArgs> OnDataReceived
        {
            add => _onDataReceived += value;
            remove
            {
                if (_onDataReceived != null && value != null)
                {
                    _onDataReceived -= value;
                }
            }
        }

#pragma warning restore CS8601 // Possible null reference assignment.

        public bool IsConnected => _client.Connected;

        public IPEndPoint IPEndPoint { get; }

        public void EnqueueWrite(WoWClientPacketOut data)
        {
            _writeClientPacketQueue.Enqueue(data);
            _ = _writeSemaphore.Set();
        }

        public void EnqueueWrite(byte[] data)
        {
            _writeQueue.Enqueue(data);
            _ = _writeSemaphore.Set();
        }

        public void Disconnect()
        {
            _client.Close();

            // Raise the OnDisconnect event
            _onDisconnect?.Invoke(this, EventArgs.Empty);

#pragma warning disable CS8601 // Possible null reference assignment. -= is causing this warning for some reason.
            // Clear all delegates from the backing fields
            if (_onDisconnect != null)
            {
                foreach (var d in _onDisconnect.GetInvocationList())
                {
                    if (d != null)
                        _onDisconnect -= (EventHandler)d;
                }
            }

            if (_onDataReceived != null)
            {
                foreach (var d in _onDataReceived.GetInvocationList())
                {
                    if (d != null)
                        _onDataReceived -= (EventHandler<DataReceivedEventArgs>)d;
                }
            }
#pragma warning restore CS8601 // Possible null reference assignment.
        }

        private async Task StartListening()
        {
            var buffer = new Memory<byte>(new byte[0x4000]);
            while (_client.Connected)
            {
                try
                {
                    var bytesRead = await _stream.ReadAsync(buffer);
                    if (bytesRead > 0)
                    {
                        var data = buffer[..bytesRead].ToArray();
                        _ = _actionBlock.Post(new DataReceivedEventArgs(this, data, _onDataReceived));
                    }
                }
                catch (Exception ex)
                {
                    Disconnect();
                    _logger.Debug(ex, "Error while reading from client");
                    break;
                }
            }
        }

        private async Task ProcessWriteQueue()
        {
            while (_client.Connected)
            {
                _ = _writeSemaphore.WaitOne(1000); // Wait until there's data to write, or 1 second has passed. Im paranoid about this, so I added a timeout.

                while (_writeClientPacketQueue.TryDequeue(out var data))
                {
                    try
                    {
                        await _stream.WriteAsync(data.GetBuffer());
                        data.Dispose();
                    }
                    catch (Exception ex)
                    {
                        _logger.Debug(ex, "Error while sending data to client");
                        Disconnect();
                    }
                }

                while (_writeQueue.TryDequeue(out var data))
                {
                    try
                    {
                        await _stream.WriteAsync(data);
                    }
                    catch (Exception ex)
                    {
                        _logger.Debug(ex, "Error while sending data to client");
                        Disconnect();
                    }
                }
            }
        }
    }
}