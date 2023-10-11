// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using Serilog;

namespace WrathForged.Common.Networking;

public class PacketBuffer : IDisposable
{
    private readonly MemoryStream _internalStream;
    private bool _disposedValue;

    public PrimitiveReader Reader { get; }

    public long UnreadData => _internalStream.Length - _internalStream.Position;

    public PacketBuffer(ILogger logger)
    {
        _internalStream = new MemoryStream();
        Reader = new PrimitiveReader(_internalStream, logger);
    }

    /// <summary>
    ///     Sets the internal stream to the specified packet buffer.
    /// </summary>
    /// <param name="packetBuffer"></param>
    /// <param name="logger"></param>
    public PacketBuffer(byte[] packetBuffer, ILogger logger)
    {
        _internalStream = new MemoryStream(packetBuffer);
        Reader = new PrimitiveReader(_internalStream, logger);
    }

    /// <summary>
    ///     Sets the internal stream to the specified packet buffer.
    /// </summary>
    /// <param name="packetBuffer"></param>
    /// <param name="logger"></param>
    public PacketBuffer(Memory<byte> packetBuffer, ILogger logger)
    {
        _internalStream = new MemoryStream(packetBuffer.ToArray());
        Reader = new PrimitiveReader(_internalStream, logger);
    }

    /// <summary>
    ///     Copies the data from the specified packet buffer into a new packet buffer.
    /// </summary>
    /// <param name="packetBuffer"></param>
    /// <param name="logger"></param>
    public PacketBuffer(PacketBuffer packetBuffer, ILogger logger)
    {
        _internalStream = new MemoryStream(packetBuffer._internalStream.ToArray());
        Reader = new PrimitiveReader(_internalStream, logger);
    }

    /// <summary>
    ///     Clears the read data from the buffer. If data is unread, it will be compacted to the beginning of the buffer. The buffer position will be reset to 0.
    /// </summary>
    public void ClearReadData()
    {
        var unreadData = UnreadData;
        if (unreadData > 0)
        {
            var memory = new Memory<byte>(_internalStream.GetBuffer());
            var slice = memory.Slice((int)_internalStream.Position, (int)unreadData);
            _internalStream.SetLength(0);
            _internalStream.Write(slice.Span);
        }
        else
        {
            _internalStream.SetLength(0); // If no unread data, simply reset the stream
        }

        _internalStream.Position = 0; // Reset position for reading
    }

    public void AppendData(byte[] data)
    {
        // If there's unread data at the end of the stream, we need to compact the buffer
        if (_internalStream.Position > 0)
        {
            ClearReadData();
        }

        _internalStream.Position = _internalStream.Length; // Move position to the end for appending
        _internalStream.Write(data, 0, data.Length);
        _internalStream.Position = 0; // Reset position for reading
    }

    public bool CanReadLength(int length) => (_internalStream.Length - _internalStream.Position) >= length;

    public Memory<byte> GetBuffer() => new(_internalStream.GetBuffer(), 0, (int)_internalStream.Length);

    public void Clear(int? length = null)
    {
        if (length == null || length == 0 || length.Value >= _internalStream.Length)
        {
            _internalStream.SetLength(0);
            _internalStream.Position = 0;
        }
        else
        {
            var bufferSpan = new Span<byte>(_internalStream.GetBuffer());
            var remainingSpan = bufferSpan[length.Value..];
            remainingSpan.CopyTo(bufferSpan);
            _internalStream.SetLength(_internalStream.Length - length.Value);
            _internalStream.Position = 0;
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                Reader.Dispose();
                _internalStream.Dispose();
            }

            _disposedValue = true;
        }
    }

    ~PacketBuffer()
    {
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}