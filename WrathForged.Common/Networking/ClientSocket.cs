// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks.Dataflow;
using Serilog;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace WrathForged.Common.Networking;

public class ClientSocket : IDisposable
{
    private readonly TcpClient _client;
    private readonly ILogger _logger;
    private readonly ActionBlock<DataReceivedEventArgs> _actionBlock;
    private readonly AutoResetEvent _writeSemaphore = new(true);
    private readonly ConcurrentQueue<WoWClientPacketOut> _writeClientPacketQueue = new();
    private readonly ConcurrentQueue<byte[]> _writeQueue = new();

    private readonly NetworkStream _stream;
    private bool _processedDisconnect;
    private bool _disconnectAfterWrite;

    public ClientSocket(TcpClient client, ILogger logger, ActionBlock<DataReceivedEventArgs> actionBlock)
    {
        _client = client;
        _logger = logger;
        _actionBlock = actionBlock;
        _client.ReceiveBufferSize = 0x4000;
        _client.LingerState = new LingerOption(true, 0);

        if (_client.Client.RemoteEndPoint is IPEndPoint iPEndPoint)
        {
            IPEndPoint = iPEndPoint;
        }

        _stream = _client.GetStream();
        _stream.ReadTimeout = -1;
        _ = Task.Run(StartListening);
        _ = Task.Run(ProcessWriteQueue);
    }

    private EventHandler<ClientSocket> _onDisconnect;
    private EventHandler<DataReceivedEventArgs> _onDataReceived;
    private EventHandler<Memory<byte>> _onDataSent;
    private bool _disposedValue;

#pragma warning disable CS8601 // Possible null reference assignment. -= is causing this warning for some reason.

    // with client disconnects, we need to remove the delegates from the backing fields so the GC can collect them
    public event EventHandler<ClientSocket> OnDisconnect
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

    public event EventHandler<Memory<byte>> OnDataSent
    {
        add => _onDataSent += value;
        remove
        {
            if (_onDataSent != null && value != null)
            {
                _onDataSent -= value;
            }
        }
    }

#pragma warning restore CS8601 // Possible null reference assignment.

    public bool IsConnected => _client.Connected;

    public IPEndPoint IPEndPoint { get; }

    public IWoWClientSession? ClientSession { get; set; }

    public void EnqueueWrite(WoWClientPacketOut data)
    {
        if (_processedDisconnect)
            return;

        _writeClientPacketQueue.Enqueue(data);
        _ = _writeSemaphore.Set();
    }

    public void EnqueueWrite(byte[] data)
    {
        if (_processedDisconnect)
            return;

        _writeQueue.Enqueue(data);
        _ = _writeSemaphore.Set();
    }

    /// <summary>
    ///     Finishes writing all data in the write queue, then disconnects the client.
    /// </summary>
    public void Disconnect()
    {
        if (_processedDisconnect)
            return;

        if (!_writeClientPacketQueue.IsEmpty || !_writeQueue.IsEmpty)
        {
            _disconnectAfterWrite = true;
            return;
        }

        InternalDisconnect();
    }

    /// <summary>
    ///     Does not wait for the write queue to finish, and disconnects the client immediately.
    /// </summary>
    public void DisconnectNoDelay() => InternalDisconnect();

    private void InternalDisconnect()
    {
        if (_processedDisconnect)
            return;

        _processedDisconnect = true;
        _logger.Debug("Disconnecting client {IPEndPoint}", IPEndPoint);
        _client.Close();

        // Raise the OnDisconnect event
        _onDisconnect?.Invoke(this, this);

#pragma warning disable CS8601 // Possible null reference assignment. -= is causing this warning for some reason.
        // Clear all delegates from the backing fields
        if (_onDisconnect != null)
        {
            foreach (var d in _onDisconnect.GetInvocationList())
            {
                if (d != null)
                    _onDisconnect -= (EventHandler<ClientSocket>)d;
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

        if (_onDataSent != null)
        {
            foreach (var d in _onDataSent.GetInvocationList())
            {
                if (d != null)
                    _onDataSent -= (EventHandler<Memory<byte>>)d;
            }
        }
#pragma warning restore CS8601 // Possible null reference assignment.
    }

    private void StartListening()
    {
        var buffer = new byte[0x4000];
        while (_client.Connected)
        {
            try
            {
                var bytesRead = _stream.Read(buffer, 0, buffer.Length);
                if (bytesRead > 0)
                {
                    var data = buffer[..bytesRead].ToArray();
                    _ = _actionBlock.Post(new DataReceivedEventArgs(this, data, _onDataReceived));
                }
                else
                {
                    // read of 0 is disconnect
                    InternalDisconnect();
                    break;
                }
            }
            catch (Exception ex)
            {
                if (!_processedDisconnect)
                    _logger.Debug(ex, "Error while reading from client");

                InternalDisconnect();
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
                if (_processedDisconnect)
                    break;

                try
                {
                    var buffer = data.GetBuffer(ClientSession?.Security?.PacketEncryption);
                    _logger.Verbose("Sending packet {Opcode} to {IPEndPoint} with length {Length}", data.PacketId, IPEndPoint, buffer.Length);
                    await _stream.WriteAsync(buffer);
                    _onDataSent?.Invoke(this, buffer);
                    data.Dispose();
                }
                catch (Exception ex)
                {
                    if (!_processedDisconnect)
                        _logger.Debug(ex, "Error while sending data to client");

                    InternalDisconnect();
                }
            }

            while (_writeQueue.TryDequeue(out var data))
            {
                if (_processedDisconnect)
                    break;

                _logger.Verbose("Sending data to {IPEndPoint} with length {Length}", IPEndPoint, data.Length);

                try
                {
                    await _stream.WriteAsync(data);
                    _onDataSent?.Invoke(this, data);
                }
                catch (Exception ex)
                {
                    if (!_processedDisconnect)
                        _logger.Debug(ex, "Error while sending data to client");
                    InternalDisconnect();
                }
            }

            if (_disconnectAfterWrite)
            {
                InternalDisconnect();
                break;
            }
        }

        InternalDisconnect();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                Disconnect();
                _stream.Dispose();
                _client.Dispose();
            }

            _disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}