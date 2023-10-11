// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Serialization;
using WrathForged.Models.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Networking;

public class WoWClientPacketOut : IDisposable
{
    private bool _disposedValue;
    private readonly ForgedModelSerializer _forgedModelSerializer;
    private readonly PacketHeaderType _headerType;
    private readonly ContentLengthType _contentLengthType;
    private readonly byte[]? _header;
    private int _headerSize;

    public WoWClientPacketOut(ForgedModelSerializer forgedModelSerializer, PacketId packetId, PacketHeaderType headerType, ContentLengthType contentLengthType = ContentLengthType.None, byte[]? header = null)
    {
        _forgedModelSerializer = forgedModelSerializer;
        PacketId = packetId;
        _headerType = headerType;
        _contentLengthType = contentLengthType;
        Writer = new PrimitiveWriter();
        MemoryStream = (MemoryStream)Writer.BaseStream;
        _header = header;

        switch (headerType)
        {
            case PacketHeaderType.OnlyOpCode:
                _headerSize = 1;
                break;
            case PacketHeaderType.NullTerminatedOpCode:
                _headerSize = 2;
                break;
            case PacketHeaderType.NullTerminatedWithLength:
                _headerSize = 2;
                AddContentLengthTypeToHeaderSize();
                break;
            case PacketHeaderType.WithBELength:
            case PacketHeaderType.WithLength:
                _headerSize = 1;
                AddContentLengthTypeToHeaderSize();
                break;
            case PacketHeaderType.Custom:
                ArgumentNullException.ThrowIfNull(header);
                _headerSize = header.Length;
                break;
        }

        if (packetId.Type != PacketId.PacketIdType.Auth)
            _headerSize++; // non auth op codes are short not byte

        Writer.Write(new byte[_headerSize]);
    }

    public PacketId PacketId { get; }

    public PrimitiveWriter Writer { get; }

    public MemoryStream MemoryStream { get; }

    /// <summary>
    ///     We use memory to avoid copying the buffer, and manipulating the buffer in the stream directly.
    /// </summary>
    /// <returns></returns>
    public Memory<byte> GetBuffer(PacketEncryption? packetEncryption = null)
    {
        int dataPos = (int)Writer.BaseStream.Position;

        // Step 3: Write the header to the start of the existing buffer.
        switch (_headerType)
        {
            case PacketHeaderType.OnlyOpCode:
            case PacketHeaderType.NullTerminatedOpCode:
                Writer.BaseStream.Position = 0;
                WriteOpCode();
                break;
            case PacketHeaderType.NullTerminatedWithLength:
                HeaderWithLenNullT();
                break;
            case PacketHeaderType.WithLength:
                HeaderWithLen();
                break;
            case PacketHeaderType.WithBELength:
                HeaderWithBELen();
                break;
            case PacketHeaderType.Custom:
                Writer.BaseStream.Position = 0;

                if (_header != null)
                    Writer.Write(_header);
                break;
        }

        MemoryStream.Flush();

        // For realm and instance packets, we need to encrypt the header and the data.
        // Its always 4 bytes.
        packetEncryption?.Encrypt(MemoryStream.GetBuffer(), 0, _headerSize);

        var buffer = MemoryStream.GetBuffer();
        return new Memory<byte>(buffer, 0, dataPos);
    }

    public void WriteObject<T>(T obj)
    {
        if (obj == null)
            return;

        _forgedModelSerializer.Serialize(Writer, obj);
    }

    private void HeaderWithLenNullT()
    {
        MemoryStream.Position = 0;
        WriteOpCode();
        WriteContentLength();
        Writer.Write((byte)0); // Zero terminator
    }

    private void HeaderWithLen()
    {
        MemoryStream.Position = 0;
        WriteOpCode();
        WriteContentLength();
    }

    private void HeaderWithBELen()
    {
        MemoryStream.Position = 0;
        WriteContentLengthBE();
        WriteOpCode();
    }

    private void WriteOpCode()
    {
        if (PacketId.Type == PacketId.PacketIdType.Auth)
            Writer.Write((byte)PacketId.Id);
        else
            Writer.Write((ushort)PacketId.Id);
    }

    private void WriteContentLength()
    {
        switch (_contentLengthType)
        {
            case ContentLengthType.Byte:
                Writer.Write((byte)(MemoryStream.Length - _headerSize));
                break;
            case ContentLengthType.Short:
                Writer.Write((short)(MemoryStream.Length - _headerSize));
                break;
            case ContentLengthType.UShort:
                Writer.Write((ushort)(MemoryStream.Length - _headerSize));
                break;
            case ContentLengthType.Int:
                Writer.Write((int)(MemoryStream.Length - _headerSize));
                break;
            case ContentLengthType.UInt:
                Writer.Write((uint)(MemoryStream.Length - _headerSize));
                break;
            case ContentLengthType.Long:
                Writer.Write(MemoryStream.Length - _headerSize);
                break;
            case ContentLengthType.ULong:
                Writer.Write((ulong)(MemoryStream.Length - _headerSize));
                break;
        }
    }

    private void WriteContentLengthBE()
    {
        switch (_contentLengthType)
        {
            case ContentLengthType.Byte:
                Writer.WriteByte((byte)(MemoryStream.Length - _headerSize));
                break;
            case ContentLengthType.Short:
                Writer.WriteShortBE((short)(MemoryStream.Length - _headerSize));
                break;
            case ContentLengthType.UShort:
                Writer.WriteUShortBE((ushort)(MemoryStream.Length - _headerSize));
                break;
            case ContentLengthType.Int:
                Writer.WriteIntBE((int)(MemoryStream.Length - _headerSize));
                break;
            case ContentLengthType.UInt:
                Writer.WriteUInt((uint)(MemoryStream.Length - _headerSize));
                break;
            case ContentLengthType.Long:
                Writer.WriteLongBE(MemoryStream.Length - _headerSize);
                break;
            case ContentLengthType.ULong:
                Writer.WriteULong((ulong)(MemoryStream.Length - _headerSize));
                break;
        }
    }

    private void AddContentLengthTypeToHeaderSize()
    {
        switch (_contentLengthType)
        {
            case ContentLengthType.Byte:
                _headerSize += 1;
                break;
            case ContentLengthType.Short:
            case ContentLengthType.UShort:
                _headerSize += 2;
                break;
            case ContentLengthType.Int:
            case ContentLengthType.UInt:
                _headerSize += 4;
                break;
            case ContentLengthType.Long:
            case ContentLengthType.ULong:
                _headerSize += 8;
                break;
        }
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