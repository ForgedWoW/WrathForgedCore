// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using System.Numerics;
using System.Text;
using Serilog;

namespace WrathForged.Common.Networking
{
    public class PrimitiveReader : BinaryReader
    {
        public static Encoding DefaultEncoding = Encoding.UTF8;
        private readonly ILogger _logger;

        public PrimitiveReader(MemoryStream memoryStream, ILogger logger)
            : base(memoryStream, DefaultEncoding) => _logger = logger;

        /// <summary>
        /// Number of bytes available in the packet data.
        /// </summary>
        public int RemainingLength => (int)(BaseStream.Length - BaseStream.Position);

        private bool EnsureData(int length)
        {
            if (RemainingLength < length)
            {
                _logger.Error("Not enough data available - Available: {0}, Required: {1}", RemainingLength, length);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Reads a 2-byte big endian integer value from the current stream and advances the current position of the stream by two bytes.
        /// </summary>
        /// <returns>A 2-byte big endian integer value read from the current stream.</returns>
        public ushort ReadUInt16BE() => (ushort)((ReadByte() << 8) | ReadByte());

        /// <summary>
        /// Reads a 4-byte floating point value from the current stream and advances the current position of the stream by four bytes.
        /// </summary>
        /// <returns>A 4-byte floating point value read from the current stream.</returns>
        public float ReadFloat() => ReadSingle();

        /// <summary>
        /// Reads a null-terminated UTF-8 encoded string.
        /// </summary>
        /// <returns>the string that was read</returns>
        public string ReadCString()
        {
            byte tempByte;
            var chrBuffer = new List<byte>();

            while ((tempByte = ReadByte()) != 0)
            {
                chrBuffer.Add(tempByte);
            }

            return DefaultEncoding.GetString(chrBuffer.ToArray());
        }

        /// <summary>
        /// Reads a string from the current stream, and reverses it. The string is ended with a NULL byte.
        /// </summary>
        /// <returns>The string being read.</returns>
        public string ReadReversedString()
        {
            byte tempByte;
            var chrBuffer = new List<byte>();

            while ((tempByte = ReadByte()) != 0)
            {
                chrBuffer.Add(tempByte);
            }

            var stringChrs = DefaultEncoding.GetChars(chrBuffer.ToArray());
            _ = stringChrs.Reverse();

            return new string(stringChrs);
        }

        /// <summary>
        /// Reads a string from the current stream. The string is prefixed with the length, encoded as an integer seven bits at a time.
        /// </summary>
        /// <returns>The string being read.</returns>
        public string ReadPascalString()
        {
            int size = ReadByte();

            return !EnsureData(size) ? "" : new string(ReadChars(size));
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>The string being read.</returns>
        public string ReadPascalStringUShort()
        {
            int size = ReadUInt16();

            return !EnsureData(size) ? "" : new string(ReadChars(size));
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>The string being read.</returns>
        public string ReadPascalStringUInt()
        {
            var size = ReadInt32();

            return !EnsureData(size) ? "" : new string(ReadChars(size));
        }

        /// <summary>
        /// Reads a string from the current stream, and reverses it. The string read is of length bytes.
        /// </summary>
        /// <returns>The string being read.</returns>
        public string ReadReversedPascalString(int length)
        {
            if (length < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "string length must be greater than zero!");
            }

            if (!EnsureData(length))
            {
                return "";
            }

            var chrs = ReadChars(length);
            _ = chrs.Reverse();

            return new string(chrs);
        }

        public string ReadFourCC()
        {
            if (!EnsureData(4))
            {
                return "";
            }

            var chrs = ReadChars(4);
            //if the fourcc is null terminated
            //then we dont want to move the termination
            //character!
            if (chrs[3] == 0)
            {
                (chrs[2], chrs[0]) = (chrs[0], chrs[2]);
            }
            else
            {
                _ = chrs.Reverse();
            }

            return new string(chrs);
        }

        /// <summary>
        /// Reads a <see cref="BigInteger" /> from the current stream. The <see cref="BigInteger" /> is of length bytes.
        /// </summary>
        /// <param name="length">The length in bytes of the <see cref="BigInteger" />.</param>
        /// <returns>The <see cref="BigInteger" /> representation of the bytes.</returns>
        public BigInteger ReadBigInteger(int length)
        {
            if (length < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "BigInteger length must be greater than zero!");
            }

            if (!EnsureData(length))
            {
                return new BigInteger(0);
            }

            var data = ReadBytes(length);

            return data.Length < length ? new BigInteger(0) : new BigInteger(data);
        }

        /// <summary>
        /// Reads a <see cref="BigInteger" /> from the current stream. The <see cref="BigInteger" /> is prefixed by the length.
        /// </summary>
        /// <returns>The <see cref="BigInteger" /> representation of the bytes.</returns>
        public BigInteger ReadBigIntegerLengthValue()
        {
            var length = ReadByte();

            return length != 0 ? ReadBigInteger(length) : new BigInteger();
        }

        /// <summary>
        /// Reads an <see cref="XmlIPAddress" /> from the current stream.
        /// </summary>
        /// <returns>The <see cref="XmlIPAddress" /> representation of the bytes.</returns>
        public IPAddress ReadIPAddress()
        {
            if (!EnsureData(4))
            {
                return IPAddress.Any;
            }

            var data = ReadBytes(4);

            return new IPAddress(data);
        }

        /// <summary>
        /// Reads a <see cref="Vector3" /> from the current stream.
        /// </summary>
        /// <returns>The <see cref="Vector3" /> representation of the bytes.</returns>
        public Vector3 ReadVector3() => new(ReadSingle(), ReadSingle(), ReadSingle());

        /// <summary>
        /// Reads a <see cref="Vector4" /> from the current stream.
        /// </summary>
        /// <returns>The <see cref="Vector4" /> representation of the bytes.</returns>
        public Vector4 ReadVector4() => new(ReadSingle(), ReadSingle(), ReadSingle(), ReadSingle());

        /// <summary>
        /// Reads an EntityId from this stream and advances the current position of the stream by eight bytes.
        /// </summary>
        /// <returns>An EntityId read from the current stream.</returns>
        public EntityId ReadEntityId()
        {
            _ = EnsureData(8);

            return new EntityId(ReadBytes(8));
        }

        /// <summary>
        /// Reads an EntitiyId packed
        /// </summary>
        /// <returns></returns>
        public EntityId ReadPackedEntityId()
        {
            var mask = ReadByte();
            var guid = new byte[8];

            for (var i = 0; i < 8; i++)
            {
                if ((mask & (1 << i)) != 0)
                {
                    guid[i] = ReadByte();
                }
            }

            return new EntityId(guid);
        }
    }
}