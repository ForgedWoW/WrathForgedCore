using System;
using System.Buffers.Binary;

namespace DotRecast.Core;

public class RcByteBuffer(byte[] bytes)
{
    private RcByteOrder _order = BitConverter.IsLittleEndian
            ? RcByteOrder.LITTLE_ENDIAN
            : RcByteOrder.BIG_ENDIAN;
    private readonly byte[] _bytes = bytes;
    private int _position = 0;

    public RcByteOrder Order() => _order;

    public void Order(RcByteOrder order) => _order = order;

    public int Limit() => _bytes.Length - _position;

    public int Remaining()
    {
        var rem = Limit();
        return rem > 0 ? rem : 0;
    }

    public void Position(int pos) => _position = pos;

    public int Position() => _position;

    public Span<byte> ReadBytes(int length)
    {
        var nextPos = _position + length;
        (nextPos, _position) = (_position, nextPos);

        return _bytes.AsSpan(nextPos, length);
    }

    public byte Get()
    {
        var span = ReadBytes(1);
        return span[0];
    }

    public short GetShort()
    {
        var span = ReadBytes(2);
        return _order == RcByteOrder.BIG_ENDIAN ? BinaryPrimitives.ReadInt16BigEndian(span) : BinaryPrimitives.ReadInt16LittleEndian(span);
    }

    public int GetInt()
    {
        var span = ReadBytes(4);
        return _order == RcByteOrder.BIG_ENDIAN ? BinaryPrimitives.ReadInt32BigEndian(span) : BinaryPrimitives.ReadInt32LittleEndian(span);
    }

    public float GetFloat()
    {
        var span = ReadBytes(4);
        if (_order == RcByteOrder.BIG_ENDIAN && BitConverter.IsLittleEndian)
        {
            span.Reverse();
        }
        else if (_order == RcByteOrder.LITTLE_ENDIAN && !BitConverter.IsLittleEndian)
        {
            span.Reverse();
        }

        return BitConverter.ToSingle(span);
    }

    public long GetLong()
    {
        var span = ReadBytes(8);
        return _order == RcByteOrder.BIG_ENDIAN ? BinaryPrimitives.ReadInt64BigEndian(span) : BinaryPrimitives.ReadInt64LittleEndian(span);
    }

    public void PutFloat(float v)
    {
        // if (_order == ByteOrder.BIG_ENDIAN)
        // {
        //     BinaryPrimitives.WriteInt32BigEndian(_bytes[_position]);
        // }
        // else
        // {
        //     BinaryPrimitives.ReadInt64LittleEndian(span);
        // }

        // ?
    }

    public void PutInt(int v)
    {
        // ?
    }
}
