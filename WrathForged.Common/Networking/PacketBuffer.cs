// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Common.Networking;

public class PacketBuffer : IDisposable
{
    private readonly MemoryStream _internalStream;
    private bool _disposedValue;

    public BinaryReader Reader { get; }

    public PacketBuffer()
    {
        _internalStream = new MemoryStream();
        Reader = new BinaryReader(_internalStream);
    }

    public void AppendData(byte[] data)
    {
        // If there's unread data at the end of the stream, we need to compact the buffer
        if (_internalStream.Position > 0)
        {
            var unreadData = _internalStream.Length - _internalStream.Position;
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
        }

        _internalStream.Position = _internalStream.Length; // Move position to the end for appending
        _internalStream.Write(data, 0, data.Length);
        _internalStream.Position = 0; // Reset position for reading
    }

    public bool CanReadLength(int length)
    {
        return (_internalStream.Length - _internalStream.Position) >= length;
    }

    public Memory<byte> GetBuffer()
    {
        return new Memory<byte>(_internalStream.GetBuffer(), 0, (int)_internalStream.Length);
    }

    public void Clear()
    {
        _internalStream.SetLength(0);
        _internalStream.Position = 0;
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