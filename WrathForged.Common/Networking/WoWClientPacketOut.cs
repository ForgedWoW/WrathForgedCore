// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Serialization;
using WrathForged.Models.Networking;

namespace WrathForged.Common.Networking;

public class WoWClientPacketOut : IDisposable
{

    private bool _disposedValue;
    private readonly ForgedModelSerializer _forgedModelSerializer;
    private readonly PacketHeaderType _headerType;
    private readonly byte[]? _header;

    public WoWClientPacketOut(ForgedModelSerializer forgedModelSerializer, PacketId packetId, PacketHeaderType headerType, byte[]? header = null)
    {
        _forgedModelSerializer = forgedModelSerializer;
        PacketId = packetId;
        _headerType = headerType;
        Writer = new PrimitiveWriter();
        MemoryStream = (MemoryStream)Writer.BaseStream;
        _header = header;

        int headerSize = -1;

        switch (headerType)
        {
            case PacketHeaderType.OnlyOpCode:
                headerSize = 1;
                break;
            case PacketHeaderType.NullTerminatedOpCode:
                headerSize = 2;
                break;
            case PacketHeaderType.NullTerminatedWithLength:
                headerSize = 4;
                break;
            case PacketHeaderType.WithLength:
                headerSize = 3;
                break;
            case PacketHeaderType.Custom:
                ArgumentNullException.ThrowIfNull(header);
                headerSize = header.Length;
                break;
        }

        Writer.Write(new byte[headerSize]);
    }

    public PacketId PacketId { get; }

    public PrimitiveWriter Writer { get; }

    public MemoryStream MemoryStream { get; }

    /// <summary>
    ///     We use memory to avoid copying the buffer, and manipulating the buffer in the stream directly.
    /// </summary>
    /// <returns></returns>
    public Memory<byte> GetBuffer()
    {
        int dataPos = (int)Writer.BaseStream.Position;

        // Step 3: Write the header to the start of the existing buffer.
        switch (_headerType)
        {
            case PacketHeaderType.OnlyOpCode:
            case PacketHeaderType.NullTerminatedOpCode:
                Writer.BaseStream.Position = 0;
                Writer.Write((byte)PacketId.Id);
                break;
            case PacketHeaderType.NullTerminatedWithLength:
                HeaderWithLenNullT();
                break;
            case PacketHeaderType.WithLength:
                HeaderWithLen();
                break;
            case PacketHeaderType.Custom:
                Writer.BaseStream.Position = 0;

                if (_header != null)
                    Writer.Write(_header);
                break;
        }

        MemoryStream.Flush();

        var buffer = MemoryStream.GetBuffer();
        return new Memory<byte>(buffer, 0, dataPos);
    }

    private void HeaderWithLenNullT()
    {
        var buffer = MemoryStream.GetBuffer();
        var headerSize = 4; // 1 byte for content length, 2 bytes for PacketId.Id, and 1 byte for terminator
        var contentLength = buffer.Length - headerSize;

        var span = buffer.AsSpan();
        span[0] = (byte)contentLength;
        _ = BitConverter.TryWriteBytes(span.Slice(1, 2), (ushort)PacketId.Id);
        span[3] = 0; // Zero terminator
    }

    private void HeaderWithLen()
    {
        var buffer = MemoryStream.GetBuffer();
        var headerSize = 3; // 1 byte for content length, 2 bytes for PacketId.Id, and 1 byte for terminator
        var contentLength = buffer.Length - headerSize;

        var span = buffer.AsSpan();
        span[0] = (byte)contentLength;
        _ = BitConverter.TryWriteBytes(span.Slice(1, 2), (ushort)PacketId.Id);
    }

    public void WriteObject<T>(T obj)
    {
        if (obj == null)
            return;

        _forgedModelSerializer.Serialize(PacketId, PacketId, Writer, obj);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                Writer.Dispose();
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